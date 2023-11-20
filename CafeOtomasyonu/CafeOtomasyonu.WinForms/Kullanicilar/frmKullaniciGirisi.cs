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
using CafeOtomasyonu.WinForms.WinTools;

namespace CafeOtomasyonu.WinForms.Kullanicilar
{
    public partial class frmKullaniciGirisi : DevExpress.XtraEditors.XtraForm
    {
        private bool giris;
        private CafeContext context = new CafeContext();
        private KullaniciHareketleriDal kullaniciHareketleriDal = new KullaniciHareketleriDal();
        private KullaniciHareketleri entity = new KullaniciHareketleri();


        void BilgileriGetir()
        {
            if (Properties.Settings.Default.beniHatirla == true)
            {
                txtKullaniciAdi.Text = Properties.Settings.Default.kullaniciAdi;
                txtParola.Text = Properties.Settings.Default.parola;
                checkBeniHatirla.Checked = true;
            }
            else
            {
                txtKullaniciAdi.Text = null;
                txtParola.Text = null;
                checkBeniHatirla.Checked = false;
            }
        }

        void BilgileriKaydet()
        {
            if (checkBeniHatirla.Checked)
            {
                Properties.Settings.Default.kullaniciAdi = txtKullaniciAdi.Text;
                Properties.Settings.Default.parola = txtParola.Text;
                Properties.Settings.Default.beniHatirla = true;
                Properties.Settings.Default.Save();

            }
            else
            {
                Properties.Settings.Default.kullaniciAdi = null;
                Properties.Settings.Default.parola = null;
                Properties.Settings.Default.beniHatirla = false;
                Properties.Settings.Default.Save();
            }
        }
        public frmKullaniciGirisi()
        {
            InitializeComponent();
            BilgileriGetir();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (!giris)
            {
                Application.Exit();
            }
        }

        private void frmKullaniciGirisi_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!giris)
            {
                Application.Exit();
            }
        }

        private void btGiris_Click(object sender, EventArgs e)
        {
            var model = context.Kullanicilar.FirstOrDefault(k =>
                k.kullaniciAdi == txtKullaniciAdi.Text && k.parola == txtParola.Text);
            if (context.Kullanicilar.Any(k => k.kullaniciAdi == txtKullaniciAdi.Text && k.parola == txtParola.Text))
            {
                giris = true;
                BilgileriKaydet();
                KullaniciAyarlari.kullaniciId = model.Id;
                //entity.kullaniciId = model.Id;
                //string aciklama = model.kullaniciAdi + " adlı kullanıcı sisteme giriş yaptı.";
                //kullaniciHareketleriDal.KullaniciHareketleriEkle(context, entity, aciklama);
                this.Close();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış.", "Uyarı", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
        }

        private void lblKaydol_Click(object sender, EventArgs e)
        {
            frmKaydol frm = new frmKaydol(new CafeOtomasyon.Entities.Models.Kullanicilar());
            frm.ShowDialog();
        }

        private void btnParolamiUnuttum_Click(object sender, EventArgs e)
        {
            frmParolamiUnuttum frm = new frmParolamiUnuttum();
            frm.ShowDialog();
        }
    }
}