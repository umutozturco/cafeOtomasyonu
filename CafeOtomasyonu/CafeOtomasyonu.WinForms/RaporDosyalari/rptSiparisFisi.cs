using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using CafeOtomasyon.Entities.DAL;
using CafeOtomasyon.Entities.Models;
using DevExpress.DataAccess.ObjectBinding;

namespace CafeOtomasyonu.WinForms.RaporDosyalari
{
    public partial class rptSiparisFisi : DevExpress.XtraReports.UI.XtraReport
    {
        private CafeContext context = new CafeContext();
        private MasaHareketleriDal masaHareketleriDal = new MasaHareketleriDal();
        public rptSiparisFisi(string satisKodu,string bilgi,CafeOtomasyon.Entities.Models.Satislar satislar=null)
        {
            InitializeComponent();
            ObjectDataSource source = new ObjectDataSource();
            xrLabelBilgi.Text = bilgi;
            source.DataSource = masaHareketleriDal.GetAll(context, m => m.satisKodu == satisKodu);
            this.DataSource=source;
            xrTableUrunAdi.DataBindings.Add("Text", DataSource, "Urun.urunAdi");
            xrTableMiktar.DataBindings.Add("Text", DataSource, "miktari");
            xrTableIndirim.DataBindings.Add("Text", DataSource, "indirimTutari");
            xrTableFiyat.DataBindings.Add("Text", DataSource, "birimFiyati");
            xrLabelKalan.Text = satislar.kalan.ToString("C2");
            xrLabelOdenen.Text = satislar.odenen.ToString("C2");
            

        }

    }
}
