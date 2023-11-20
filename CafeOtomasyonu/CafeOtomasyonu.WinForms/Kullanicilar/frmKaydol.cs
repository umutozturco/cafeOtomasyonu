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
using CafeOtomasyon.Entities.Mapping;
using CafeOtomasyonu.WinForms.AnaMenu;
using CafeOtomasyonu.WinForms.Masalar;
using DevExpress.XtraEditors.Filtering.Templates;
using DevExpress.XtraBars;

namespace CafeOtomasyonu.WinForms.Kullanicilar
{
    public partial class frmKaydol : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private KullanicilarDal kullanicilarDal= new KullanicilarDal();
        private CafeOtomasyon.Entities.Models.Kullanicilar _entity;
        private KullaniciHareketleri kullaniciHareketleri = new KullaniciHareketleri();
        private KullaniciHareketleriDal kullaniciHareketleriDal = new KullaniciHareketleriDal();
        
        public frmKaydol(CafeOtomasyon.Entities.Models.Kullanicilar entity)
        {
            InitializeComponent();
            _entity = entity;
            toggleAktifMi.DataBindings.Add("EditValue", _entity, "aktifMi");
            txtAdSoyad.DataBindings.Add("Text", _entity, "adSoyad");
            txtTelefon.DataBindings.Add("Text", _entity, "telefon");
            txtEmail.DataBindings.Add("Text", _entity, "email");
            txtAdres.DataBindings.Add("Text", _entity, "adres");
            txtGorevi.DataBindings.Add("Text", _entity, "gorevi");
            txtKullaniciAdi.DataBindings.Add("Text", _entity, "kullaniciAdi");
            txtParola.DataBindings.Add("Text", _entity, "parola");
            txtHatirlatmaSorusu.DataBindings.Add("Text", _entity, "hatirlatmaSorusu");
            txtCevap.DataBindings.Add("Text", _entity, "cevap");
            txtAciklama.DataBindings.Add("Text", _entity, "aciklama");
           
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtParola.Text==txtParolaTekrar.Text)
            {
                _entity.kayitTarihi = DateTime.Now;
                if (kullanicilarDal.AddOrUpdate(context, _entity))
                {
                    kullanicilarDal.Save(context);
                    var model = context.Kullanicilar.Max(k => k.Id);
                    kullaniciHareketleri.kullaniciId = model;
                    string aciklama = "Yeni kullanıcı eklendi.";
                    kullaniciHareketleriDal.KullaniciHareketleriEkle(context,kullaniciHareketleri,aciklama);
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
                                    kullaniciId = context.Kullanicilar.Max(k=>k.Id),
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
                    MessageBox.Show("Yeni kullanıcı eklendi.");
                    this.Close();
                } 
            }
            else
            {
                MessageBox.Show("Parola ve parola tekrarı birbiri ile eşleşmiyor.");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmKaydol_Load(object sender, EventArgs e)
        {

        }
    }
}