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

namespace CafeOtomasyonu.WinForms.Odemeler
{
    public partial class frmOdeme : DevExpress.XtraEditors.XtraForm
    {
        private string _satisKodu;
        private string _odemeTuru;
        public OdemeHareketleri odemeHareketleri;
        public bool kaydedildi;
        public decimal _kalan;

        public frmOdeme(string odemeTuru,string satisKodu,decimal kalan)
        {
            InitializeComponent();
            
            _odemeTuru = odemeTuru;
            _satisKodu = satisKodu;
            _kalan = kalan;
            if (_odemeTuru=="Nakit")
            {
                lblBaslik.Text = "Nakit Ödeme";

            }
            else if (_odemeTuru=="Kredi Kartı")
            {
                lblBaslik.Text = "Kredi Kartı ile Ödeme";
            }

        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            odemeHareketleri = new OdemeHareketleri
            {
                satisKodu = _satisKodu,
                odemeTuru = _odemeTuru,
                odenen=calcOdenecekTutar.Value,
                aciklama = txtSatisAciklama.Text,
                tarih = Convert.ToDateTime(dateEditTarih.Text)
            };
            kaydedildi = true;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            calcOdenecekTutar.Value = _kalan;
        }
    }
}