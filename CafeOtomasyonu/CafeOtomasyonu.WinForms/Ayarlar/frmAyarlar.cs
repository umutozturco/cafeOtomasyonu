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
using CafeOtomasyon.Entities.Models;

namespace CafeOtomasyonu.WinForms.Ayarlar
{
    public partial class frmAyarlar : DevExpress.XtraEditors.XtraForm
    {
        CafeContext context = new CafeContext();
        public frmAyarlar()
        {
            InitializeComponent();
            
            List < object > obj = new List<object>();
            int i= 0;
            foreach (var item in typeof(Urun).GetProperties())
            {
                if (item.Name.Contains("birimFiyati"))
                {
                    obj.Insert(i, item.Name);
                    i++;
                }
                
            }

            lookUpBirimFiyati.Properties.DataSource = obj;
            AyarGetir();
        }

        private void AyarGetir()
        {
            var model = context.ProgramAyarlari.FirstOrDefault(p => p.ayarTanimi == "Birim Fiyatı");
            if (model != null) lookUpBirimFiyati.EditValue = model.ayarAdi;
        }


        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            var modelprogram = context.ProgramAyarlari.FirstOrDefault(p => p.ayarTanimi == "Birim Fiyatı");
            if (modelprogram != null)
            {
                modelprogram.ayarAdi=lookUpBirimFiyati.EditValue.ToString();
               
            }
            else if (modelprogram==null)
            {
                ProgramAyarlari entity = new ProgramAyarlari
                {
                    ayarTanimi = "Birim Fiyatı",
                    ayarAdi = lookUpBirimFiyati.EditValue.ToString()
                };
                context.ProgramAyarlari.Add(entity);
            }
            context.SaveChanges();

            AyarGetir();
            MessageBox.Show("Ayarlar kaydedildi.");
           
        }
    }
}