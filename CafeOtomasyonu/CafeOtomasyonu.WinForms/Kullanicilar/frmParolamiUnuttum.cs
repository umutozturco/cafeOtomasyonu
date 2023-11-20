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

namespace CafeOtomasyonu.WinForms.Kullanicilar
{
    public partial class frmParolamiUnuttum : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private KullanicilarDal kullanicilarDal = new KullanicilarDal();
        private KullaniciHareketleri kullaniciHareketleri = new KullaniciHareketleri();
        private KullaniciHareketleriDal kullaniciHareketleriDal = new KullaniciHareketleriDal();
        public frmParolamiUnuttum()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var entity = kullanicilarDal.GetByFilter(context,
                k => k.kullaniciAdi == txtKullaniciAdiEmail.Text || k.email == txtKullaniciAdiEmail.Text);
            if (entity!=null)
            {
                if (entity.hatirlatmaSorusu == txtSoru.Text && entity.cevap == txtCevap.Text) 
                {
                    if (txtYeniParola.Text==txtYeniParolaTekrar.Text)
                    {
                        entity.parola = txtYeniParola.Text;
                        if (kullanicilarDal.AddOrUpdate(context,entity))
                        {
                            kullanicilarDal.Save(context);
                            kullaniciHareketleri.kullaniciId = entity.Id;
                            string aciklama = entity.kullaniciAdi + " adlı kullanıcının parolası yenilendi.";
                            kullaniciHareketleriDal.KullaniciHareketleriEkle(context, kullaniciHareketleri, aciklama);
                            MessageBox.Show("Şifreniz değiştirildi.");
                            this.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Parola uyuşmuyor.");
                    }
                }
                else
                {
                    MessageBox.Show("Girilen soru veya cevap yanlış.");
                }
            }
            else
            {
                MessageBox.Show("Böyle bir kullanıcı bulunamadı.");
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}