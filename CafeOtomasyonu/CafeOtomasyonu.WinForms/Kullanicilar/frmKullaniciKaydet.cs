using DevExpress.XtraEditors;
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
using CafeOtomasyon.Entities.Interfaces;
using CafeOtomasyonu.WinForms.AnaMenu;
using CafeOtomasyonu.WinForms.WinTools;
using DevExpress.XtraBars;

namespace CafeOtomasyonu.WinForms.Kullanicilar
{
    public partial class frmKullaniciKaydet : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private CafeOtomasyon.Entities.Models.Kullanicilar _kullanicilar;
        private KullaniciHareketleri kullaniciHareketleri = new KullaniciHareketleri();
        private KullanicilarDal kullanicilarDal = new KullanicilarDal();
        private KullaniciHareketleriDal kullaniciHareketleriDal = new KullaniciHareketleriDal();
        private string _girisyapankullanici;
        public frmKullaniciKaydet(CafeOtomasyon.Entities.Models.Kullanicilar kullanicilar,string girisyapankullanici=null)
        {
            InitializeComponent();
            _kullanicilar=kullanicilar;
            _girisyapankullanici = girisyapankullanici;
            toggleAktifMi.DataBindings.Add("EditValue", _kullanicilar, "aktifMi", true);
            txtAdSoyad.DataBindings.Add("Text", _kullanicilar, "adSoyad", true);
            txtAdres.DataBindings.Add("Text", _kullanicilar, "adres", true);
            txtTelefon.DataBindings.Add("Text", _kullanicilar, "telefon", true);
            txtEmail.DataBindings.Add("Text", _kullanicilar, "email", true);
            txtGorevi.DataBindings.Add("Text", _kullanicilar, "gorevi", true);
            txtKullaniciAdi.DataBindings.Add("Text", _kullanicilar, "kullaniciAdi", true);
            txtParola.DataBindings.Add("Text", _kullanicilar, "parola", true);
            txtHatirlatmaSorusu.DataBindings.Add("Text", _kullanicilar, "hatirlatmaSorusu", true);
            txtCevap.DataBindings.Add("Text", _kullanicilar, "cevap", true);
            txtAciklama.DataBindings.Add("Text", _kullanicilar, "aciklama", true);
            if (_kullanicilar.Id == 0)
            {
                lblBaslik.Text = "Yeni Kullanıcı Ekleme Sayfası";
            }
            else if (_kullanicilar.Id != 0)
            {
                lblBaslik.Text = _kullanicilar.kullaniciAdi + " Bilgileri Sayfası";
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (lblBaslik.Text == "Yeni Kullanıcı Ekleme Sayfası")
            {
                _kullanicilar.kayitTarihi = DateTime.Now;
                if (kullanicilarDal.AddOrUpdate(context, _kullanicilar))
                {
                    kullanicilarDal.Save(context);
                    var idMax = context.Kullanicilar.Max(k => k.Id);
                    kullaniciHareketleri.kullaniciId = idMax;
                    string aciklama = "Yeni kullanıcı eklendi.";
                    kullaniciHareketleriDal.KullaniciHareketleriEkle(context, kullaniciHareketleri, aciklama);
                    frmAnaMenu frm = new frmAnaMenu();
                    foreach (var item in frm.ribbon.Items)
                    {
                        if (item is BarButtonItem)
                        {
                            var btn = item as BarButtonItem;
                            if (btn.Caption != "")
                            {
                                CafeOtomasyon.Entities.Models.Roller rol = new CafeOtomasyon.Entities.Models.Roller
                                {
                                    kullaniciId = context.Kullanicilar.Max(k => k.Id),
                                    formName = "frmAnaMenu",
                                    controlCaption = btn.Caption,
                                    controlName = btn.Name,
                                    Visible = false

                                };
                                context.Rollers.Add(rol);
                                context.SaveChanges();
                            }
                        }
                    }


                    this.Close();
                }
                
            }
            else
            {
                if (kullanicilarDal.AddOrUpdate(context, _kullanicilar))
                {
                    kullanicilarDal.Save(context);
                    var id = _kullanicilar.Id;
                    kullaniciHareketleri.kullaniciId = id;
                    string aciklama;
                    if (_girisyapankullanici!=null)
                    {
                        
                        aciklama = _kullanicilar.kullaniciAdi + " bilgilerini değiştirdi.";
                    }

                    else
                    {
                        aciklama = "Yönetici tarafından" + _kullanicilar.kullaniciAdi + "'nın bilgileri güncellendi.";
                        
                    }
                    kullaniciHareketleriDal.KullaniciHareketleriEkle(context, kullaniciHareketleri, aciklama);
                    this.Close();
                }
            }

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}