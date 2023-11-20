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

namespace CafeOtomasyonu.WinForms.Masalar
{
    public partial class frmRezervYap : DevExpress.XtraEditors.XtraForm
    {
        private int _masaId;
        public bool islemyapildi;
        private CafeOtomasyon.Entities.Models.Masalar masalar;
        private MasalarDal masalarDal = new MasalarDal();
        private CafeContext context = new CafeContext();
        public frmRezervYap(int masaId)
        {
            _masaId = masaId;
            InitializeComponent();
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            masalar = masalarDal.GetByFilter(context, m => m.Id == _masaId);
            masalar.islem = txtIslem.Text;
            masalar.sonIslemTarihi =Convert.ToDateTime(dateEditTarih.EditValue) ;
            masalar.kullaniciId = KullaniciAyarlari.kullaniciId;
            masalar.rezerveMi = true;
            masalarDal.Save(context);
            islemyapildi = true;
            this.Close(); 
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}