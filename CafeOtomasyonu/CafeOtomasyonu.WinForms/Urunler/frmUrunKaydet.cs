using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CafeOtomasyon.Entities.DAL;
using CafeOtomasyon.Entities.Models;

namespace CafeOtomasyonu.WinForms.Urunler
{
    public partial class frmUrunKaydet : DevExpress.XtraEditors.XtraForm
    {
        private MenuDal menuDal = new MenuDal();
        private UrunDal urunDal = new UrunDal();
        private Urun _entity;
        private CafeContext context = new CafeContext();
        public bool kaydet = false;
        public frmUrunKaydet(Urun entity)
        {
            InitializeComponent();
            _entity = entity;
            lookUpMenu.Properties.DataSource = menuDal.GetAll(context);
            lookUpMenu.DataBindings.Add("EditValue", _entity, "menuId");
            txtUrunAdi.DataBindings.Add("Text", _entity, "urunAdi");
            txtUrunKodu.DataBindings.Add("Text", _entity, "urunKodu");
            calcBirimFiyati.DataBindings.Add("Text", _entity, "birimFiyati1",true);
            calcBirimFiyati2.DataBindings.Add("Text", _entity, "birimFiyati2",true);
            calcBirimFiyati3.DataBindings.Add("Text", _entity, "birimFiyati3", true);
            txtAciklama.DataBindings.Add("Text", _entity, "aciklama");
            dateEdit1.DataBindings.Add("Text", _entity, "tarih",true);
            if (_entity.Id!=0)
            {
                if (_entity.resim!=null)
                {
                    try
                    {
                        pictureEdit1.Image = Image.FromFile(_entity.resim);
                    }
                    catch (Exception e)
                    {
                       MessageBox.Show(e.Message);
                    }
                    
                }
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (pictureEdit1.GetLoadedImageLocation()!="")
            {
                string hedefyol = $"{Application.StartupPath}\\image\\{txtUrunAdi.Text}-{txtUrunKodu.Text}.png";
                if (File.Exists(hedefyol))
                {
                    File.Delete(hedefyol);
                }
                File.Copy(pictureEdit1.GetLoadedImageLocation(), hedefyol);
                _entity.resim = $"image\\{txtUrunAdi.Text}-{txtUrunKodu.Text}.png"; 
            }
            if (urunDal.AddOrUpdate(context,_entity))
            {
                urunDal.Save(context);
                kaydet = true;
                MessageBox.Show("Ürün Kaydedildi.");
                this.Close();

            }
        }

        private void lookUpMenu_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnKapat_Click(object sender, EventArgs e)
        {

        }
    }
}