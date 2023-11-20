using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyon.Entities.DAL;
using CafeOtomasyon.Entities.Models;
using CafeOtomasyon.Entities.Tools;
using CafeOtomasyonu.WinForms.Ayarlar;
using CafeOtomasyonu.WinForms.Kullanicilar;
using CafeOtomasyonu.WinForms.Masalar;
using CafeOtomasyonu.WinForms.Menuler;
using CafeOtomasyonu.WinForms.Musteriler;
using CafeOtomasyonu.WinForms.Odemeler;
using CafeOtomasyonu.WinForms.RaporFormlari;
using CafeOtomasyonu.WinForms.Roller;
using CafeOtomasyonu.WinForms.Satislar;
using CafeOtomasyonu.WinForms.Urunler;
using CafeOtomasyonu.WinForms.WinTools;
using DevExpress.XtraEditors;

namespace CafeOtomasyonu.WinForms.AnaMenu
{
    public partial class frmAnaMenu : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        private CafeContext context = new CafeContext();
        KullanicilarDal kullanicilarDal = new KullanicilarDal();

        void FormGetir(XtraForm frm)
        {
            frm.MdiParent = this;
            frm.Show();

        }
        public frmAnaMenu()
        {
            InitializeComponent();
            ConnectionTools.VeriDoldur(context);
            
            if (!context.Kullanicilar.Any(k => k.kullaniciAdi == "Admin"))
            {
                CafeOtomasyon.Entities.Models.Kullanicilar model = new CafeOtomasyon.Entities.Models.Kullanicilar
                {
                    adSoyad = "Deneme Ad Soyad",
                    telefon = "654654",
                    adres = "Deneme Adres",
                    email = "email@gmail.com",
                    gorevi = "deneme görev",
                    kullaniciAdi = "Admin",
                    parola = "123",
                    hatirlatmaSorusu = "1",
                    cevap = "1",
                    kayitTarihi = DateTime.Now,
                    IsAdmin = true


                };
                context.Kullanicilar.Add(model);
                context.SaveChanges();

                foreach (var item in ribbon.Items)
                {
                    if (item is BarButtonItem)
                    {
                        var btn = item as BarButtonItem;
                        if (btn.Caption!="")
                        {
                            CafeOtomasyon.Entities.Models.Roller rol = new CafeOtomasyon.Entities.Models.Roller
                            {
                                kullaniciId = 1,
                                formName = "frmAnaMenu",
                                controlCaption = btn.Caption,
                                controlName = btn.Name,
                                Visible = true

                            };
                            context.Rollers.Add(rol);
                            context.SaveChanges();
                        }
                    }
                }


            }

            

        }

        private void btnUrunler_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmUrunler();
            FormGetir(frm);
        }

        private void btnMenuler_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmMenuler();
            frm.ShowDialog();
        }

        private void btnMasalar_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmMasalar();
            frm.ShowDialog();
        }

        private void ribbon_Click(object sender, EventArgs e)
        {

        }

        private void frmAnaMenu_Load(object sender, EventArgs e)
        {
            frmKullaniciGirisi frm = new frmKullaniciGirisi();
            frm.ShowDialog();
            KullaniciYetki.YetkileriGetir(context, ribbon);
        }

        private void btnMasaDurumlari_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmMasaDurumlari();
            FormGetir(frm);
        }

        private void btnMusteriler_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmMusteriler();
            FormGetir(frm);
        }

        private void btnSatislar_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmSatislar();
            FormGetir(frm);
        }

        private void btnOdemeHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            XtraForm frm = new frmOdemeHareketleri();
            FormGetir(frm);
        }

        private void btnPaketSiparisi_ItemClick(object sender, ItemClickEventArgs e)
        {
            if (MessageBox.Show("Paket sipariş işlemini onaylıyor musunuz?","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                var model = context.SatisKodu.First();
                string satisKodu = model.satisTanimi + model.sayi;
                model.sayi++;
                context.SaveChanges();
                XtraForm frm = new frmMasaSiparisleri(satisKodu: satisKodu,paketSiparis:true);
                frm.ShowDialog(); 
            }
        }

        private void btnMasaHareketleriRaporu_ItemClick(object sender, ItemClickEventArgs e)
        {
            rptMasaHareketleri report = new rptMasaHareketleri();
            frmRaporGoruntule2 frm = new frmRaporGoruntule2(report);
            frm.ShowDialog();
        }

        private void btnOzelRapor_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmOzelRaporOlustur frm = new frmOzelRaporOlustur();
            frm.ShowDialog();
        }

        private void btnMasaHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmMasaHareketleri();
            frm.ShowDialog();
        }

        private void btnDashboard_ItemClick(object sender, ItemClickEventArgs e)
        {
            var frm = new frmDashboard();
            FormGetir(frm);
        }

        private void btnKullanicilar_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmKullanicilar frm = new frmKullanicilar();
            FormGetir(frm);
        }

        private void btnBilgilerim_ItemClick(object sender, ItemClickEventArgs e)
        {
            var model = kullanicilarDal.GetByFilter(context, k => k.Id == KullaniciAyarlari.kullaniciId);
            frmKullaniciKaydet frm = new frmKullaniciKaydet(model,"fbfb");
            frm.ShowDialog();
        }

        private void btnAyarlar_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmAyarlar frm = new frmAyarlar();
            frm.ShowDialog();
        }

        private void btnYedekle_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmBackup frm = new frmBackup();
            frm.ShowDialog();
        }

        private void btnGrafik_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmGrafik frm = new frmGrafik();
            FormGetir(frm);
        }
    }
}