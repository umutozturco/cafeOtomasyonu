using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyon.Entities.DAL;
using CafeOtomasyon.Entities.Models;
using CafeOtomasyonu.WinForms.Odemeler;
using CafeOtomasyonu.WinForms.RaporDosyalari;
using CafeOtomasyonu.WinForms.RaporFormlari;
using CafeOtomasyonu.WinForms.Urunler;
using DevExpress.Utils;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraTab;

namespace CafeOtomasyonu.WinForms.Masalar
{
    public partial class frmMasaSiparisleri : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MusterilerDal musterilerDal = new MusterilerDal();
        private MasaHareketleriDal masaHareketleriDal = new MasaHareketleriDal(); 
        private int? _masaId = null;
        private string _satisKodu = null;
        private OdemeHareketleriDal odemeHareketleriDal = new OdemeHareketleriDal();
        private CafeOtomasyon.Entities.Models.Satislar satislar;
        private SatislarDal satislarDal=new SatislarDal();
        private CafeOtomasyon.Entities.Models.Masalar masalar;
        private MasalarDal masalarDal =new MasalarDal();
        private UrunDal urunDal =new UrunDal();
        private bool _paketSiparis = false;
        private bool yazdir;
        private MenuDal menuDal = new MenuDal();
        frmUrunSec frm = new frmUrunSec();

        public frmMasaSiparisleri( int? masaId = null,string masaAdi=null,string satisKodu=null, bool paketSiparis = false)
        {
            InitializeComponent();
            _masaId=masaId;
            _satisKodu = satisKodu;
            _paketSiparis = paketSiparis;
            context.masaHareketleri.Where(m=>m.satisKodu==_satisKodu).Load();
            context.OdemeHareketleri.Where(o=>o.satisKodu==satisKodu).Load();
            context.Urun.Load();
            

            gridControlSiparisler.DataSource=context.masaHareketleri.Local.ToBindingList();
            gridControlOdemeler.DataSource=context.OdemeHareketleri.Local.ToBindingList();
            lookUpMusteri.Properties.DataSource = musterilerDal.GetAll(context);
            if (_masaId!=null)
            {
                lblBaslik.Text = masaAdi + " Siparişleri";
                masalar = masalarDal.GetByFilter(context, m => m.Id == _masaId);
            }
            else if (_masaId==null)
            {
                lblBaslik.Text = "Paket siparişi veya veresiye işlemleri";
            }

            satislar = satislarDal.GetByFilter(context, s => s.satisKodu == satisKodu);
            if (satislar != null)
            {
                lookUpMusteri.EditValue = satislar.musterId;
                txtSatisAciklama.Text = satislar.aciklama;
                dateEditTarih.Text = satislar.sonIslemTarihi.ToString("dd.MM.yyyy");

            }
            HizliSatis();

            


        }

        public void HizliSatis()
        {
            var model = menuDal.GetAll(context);
            foreach (var item in model)
            {
                var page = new XtraTabPage();
                page.Text = item.menuAdi;
                page.Name = item.Id.ToString();
                page.Dock = DockStyle.Fill;
                xtraTabControl1.TabPages.Add(page);
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.Dock= DockStyle.Fill;
                page.Controls.Add(panel);

                var modelHizliSatis = urunDal.GetAll(context, u => u.hizliSatis && u.menuId == item.Id);
                foreach (var urun in modelHizliSatis)
                {
                    SimpleButton btn = new SimpleButton();
                    btn.Text = urun.urunAdi;
                    btn.Name = urun.Id.ToString();
                    btn.Appearance.TextOptions.VAlignment = VertAlignment.Bottom;
                    btn.ImageToTextAlignment = ImageAlignToText.TopCenter;
                    btn.Size = new Size(width: 80, height: 100);
                    var image = Image.FromFile(urun.resim);
                    ımageList1.Images.Add(image);
                    btn.ImageList = ımageList1.Images;
                    btn.Image = ımageList1.Images[0];
                    ımageList1.Images.RemoveAt(0);
                    btn.Appearance.BackColor = Control.DefaultBackColor;
                    btn.BorderStyle = BorderStyles.NoBorder;
                    panel.Controls.Add(btn);
                    btn.Click += Btn_Click;
                }
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            var senderbtn = sender as SimpleButton;
            int urunId = Convert.ToInt32(senderbtn.Name);
            var model = urunDal.GetByFilter(context, u => u.Id == urunId);
            MasaHareketleri entity = new MasaHareketleri
            {
                satisKodu = _satisKodu,
                urunId = urunId,
                masaId = _masaId,
                miktari = 1,
                indirimOrani = 0,
                birimFiyati = Fiyat(model),
                aciklama = "",
                tarih = DateTime.Now

                
            };
            masaHareketleriDal.AddOrUpdate(context, entity);

        }

        void Hesapla()
        {
            calcIndirimToplami.Value = Convert.ToDecimal(colindirimTutari1.SummaryItem.SummaryValue);
            calcIndirimliToplam.Value = Convert.ToDecimal(colTutar.SummaryItem.SummaryValue);
            calcToplam.Value = calcIndirimToplami.Value + calcIndirimliToplam.Value;
            calcOdenen.Value = Convert.ToDecimal(colodenen.SummaryItem.SummaryValue);
            calcKalan.Value = calcIndirimliToplam.Value - calcOdenen.Value;
            // indirim oranı

            if (calcToplam.Value!=0)
            {
                calcIndirimOrani.Value = 100 * Convert.ToDecimal(colindirimTutari1.SummaryItem.SummaryValue) /
                                         (Convert.ToDecimal(colTutar.SummaryItem.SummaryValue) +
                                         Convert.ToDecimal(colindirimTutari1.SummaryItem.SummaryValue));
            }
            else if (calcToplam.Value==0)
            {
                calcIndirimOrani.Value = 0;
            }

        }

        private void btnMusteriReset_Click(object sender, EventArgs e)
        {
            lookUpMusteri.EditValue = null;
        }

        private void repositorySiparisSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili siparişin silinmesini onaylıyor musunuz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                gridviewSiparisler.DeleteSelectedRows();
                Hesapla();
            }
        }

        decimal Fiyat(Urun model)
        {
            decimal birimFiyat = model.birimFiyati1;
            var modelprogram = context.ProgramAyarlari.FirstOrDefault(p => p.ayarTanimi == "Birim Fiyatı");
            if (modelprogram != null)
            {
                switch (modelprogram.ayarAdi)
                {
                    case "birimFiyati1":
                        birimFiyat = model.birimFiyati1;
                        break;
                    case "birimFiyati2":
                        birimFiyat = model.birimFiyati2;
                        break;
                    case "birimFiyati3":
                        birimFiyat = model.birimFiyati3;
                        break;
                }
            }
            return birimFiyat;
        }

        private void repositoryOdemeSil_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (MessageBox.Show("Seçili ödemenin silinmesini onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                gridView1.DeleteSelectedRows();
                Hesapla();
            }
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
           
            frm.ShowDialog();
            if (frm.secildi)
            {
                MasaHareketleri entity = new MasaHareketleri
                {
                    satisKodu = _satisKodu,
                    masaId = _masaId,
                    urunId = frm.urunModel.Id,
                    miktari = 1,
                    birimFiyati = Fiyat(frm.urunModel),
                    indirimOrani = 0,
                    aciklama = "",
                    tarih = DateTime.Now
                };
                masaHareketleriDal.AddOrUpdate(context, entity);
            }
        }

        private void gridviewSiparisler_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            Hesapla();
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            Hesapla();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {

            if (gridviewSiparisler.RowCount>0)
            {
                if (dateEditTarih.EditValue != null)
                {
                    if (gridviewSiparisler.RowCount > 0)
                    {
                        if (satislar == null)
                        {
                            satislar = new CafeOtomasyon.Entities.Models.Satislar();
                            satislar.satisKodu = _satisKodu;

                        }

                        satislar.musterId = (int?)lookUpMusteri.EditValue;
                        satislar.aciklama = txtSatisAciklama.Text;
                        satislar.sonIslemTarihi = Convert.ToDateTime(dateEditTarih.EditValue);
                        satislar.kalan = calcKalan.Value;
                        satislar.odenen = calcOdenen.Value;
                        satislar.tutar = calcToplam.Value;
                        satislar.indirimToplami = calcIndirimToplami.Value;
                        satislar.paketSiparisMi = _paketSiparis;
                        satislarDal.AddOrUpdate(context, satislar);

                        context.SaveChanges();
                        yazdir = true;
                    }
                    else
                    {
                        MessageBox.Show("Tarih girilmesi gerekir.");
                    }
                }
                else
                {
                    MessageBox.Show("Kaydedilecek kayıt bulunamadı.");
                } 
            }
        }

       

        private void Odemeler_Click(object sender, EventArgs e)
        {
            if (gridviewSiparisler.RowCount>0)
            {
                var btn = sender as SimpleButton;
                frmOdeme frm = new frmOdeme(btn.Text, _satisKodu, calcKalan.Value);
                frm.ShowDialog();
                if (frm.kaydedildi)
                {
                    if (odemeHareketleriDal.AddOrUpdate(context, frm.odemeHareketleri))
                    {
                        gridView1.RefreshData();
                        Hesapla();
                    }
                } 
            }
        }

        private void gridView1_RowCellStyle(object sender, DevExpress.XtraGrid.Views.Grid.RowCellStyleEventArgs e)
        {
            Hesapla();
        }

        private void btnSonuclandir_Click(object sender, EventArgs e)
        {
            if (gridviewSiparisler.RowCount>0)
            {
                if (_masaId != null)
                {
                    if (calcKalan.Value > 0)
                    {
                        if (MessageBox.Show("Bu işlemi onaylarsanız müşteriye borç işlemi kaydedilecektir.",
                                "Ozturco", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                        {
                            if (satislar != null)
                            {
                                if (satislar.musterId == null)
                                {
                                    MessageBox.Show("Önce müşteri seçmelisiniz.", "Ozturco");
                                }
                                else
                                {
                                    Sonuclandir();
                                    this.Close();
                                }
                            }
                        }

                    }
                    else if (calcKalan.Value == 0)
                    {
                        Sonuclandir();
                        this.Close();
                    }

                } 
            }
        }

        private void Sonuclandir()
        {
            masalar.SatisKodu = null;
            masalar.durumu = false;
            masalar.islem = null;
            masalar.kullaniciId = null;
            masalarDal.AddOrUpdate(context, masalar);
            masalarDal.Save(context);
        }

        private void repositoryFiyat_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int urunId = Convert.ToInt32(gridviewSiparisler.GetFocusedRowCellValue(colurunId1));
            var model = urunDal.GetByFilter(context, u => u.Id == urunId);
            btnFiyat1.Caption = model.birimFiyati1.ToString();
            btnFiyat2.Caption = model.birimFiyati2.ToString();
            btnFiyat3.Caption = model.birimFiyati3.ToString();

            radialMenu1.ShowPopup(MousePosition);
        }

        private void Fiyatlar(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            gridviewSiparisler.SetFocusedRowCellValue(colbirimFiyati1, e.Item.Caption);
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            btnKaydet.PerformClick();
            if (yazdir)
            {
                if (_masaId!=null)
                {
                    rptSiparisFisi rpt = new rptSiparisFisi(_satisKodu, masalar.masaAdi, satislar);
                    frmRaporGoruntule frm = new frmRaporGoruntule(rpt);
                    frm.ShowDialog(); 
                } 
                else if (_masaId==null)
                {
                    if (satislar.musterId==null)
                    {
                        rptSiparisFisi rpt = new rptSiparisFisi(_satisKodu, _satisKodu, satislar);
                        frmRaporGoruntule frm = new frmRaporGoruntule(rpt);
                        frm.ShowDialog();
                    }
                    else if (satislar.musterId!=null)
                    {
                        rptSiparisFisi rpt = new rptSiparisFisi(_satisKodu, _satisKodu+""+satislar.Musteriler.adSoyad, satislar);
                        frmRaporGoruntule frm = new frmRaporGoruntule(rpt);
                        frm.ShowDialog();
                    }
                    
                } 
            }
        }

        private void groupIslemler_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}  