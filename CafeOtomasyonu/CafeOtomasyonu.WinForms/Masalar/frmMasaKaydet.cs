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

namespace CafeOtomasyonu.WinForms.Masalar
{
    public partial class frmMasaKaydet : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private MasalarDal masalarDal = new MasalarDal();
        private CafeOtomasyon.Entities.Models.Masalar _entity;
        public bool kaydet = false;
        public frmMasaKaydet(CafeOtomasyon.Entities.Models.Masalar entity)
        {
            InitializeComponent();
            _entity = entity;
            txtMasaAdi.DataBindings.Add("Text", _entity, "masaAdi");
            txtAciklama.DataBindings.Add("Text", _entity, "aciklama");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (_entity.Id==0)
            {
                _entity.durumu = false;
                _entity.rezerveMi = false;
                _entity.eklenmeTarihi = DateTime.Now;
                _entity.sonIslemTarihi = DateTime.Now;
                _entity.islem = "Yeni masa eklendi.";
                
            }
            else if (_entity.Id!=0)
            {
                _entity.sonIslemTarihi=DateTime.Now;
                _entity.islem = "Masa güncellendi.";
            }
            
            if (masalarDal.AddOrUpdate(context,_entity))
            {
                masalarDal.Save(context);
                kaydet=true;
                MessageBox.Show("Masa kaydedildi.");
                this.Close();
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}