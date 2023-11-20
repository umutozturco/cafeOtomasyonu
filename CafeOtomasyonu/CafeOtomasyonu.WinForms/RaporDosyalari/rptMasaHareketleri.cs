using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using CafeOtomasyon.Entities.DAL;
using CafeOtomasyon.Entities.Models;
using DevExpress.DataAccess.ObjectBinding;

namespace CafeOtomasyonu.WinForms
{
    public partial class rptMasaHareketleri : DevExpress.XtraReports.UI.XtraReport
    {
        private CafeContext context = new CafeContext();
        private MasaHareketleriDal masaHareketleriDal = new MasaHareketleriDal();

        public rptMasaHareketleri()
        {
            InitializeComponent();
            ObjectDataSource source = new ObjectDataSource();
            source.DataSource = masaHareketleriDal.GetAll(context);
            DataSource=source;
            xrTableId.DataBindings.Add("Text", DataSource, "Id");
            xrTableSatisKodu.DataBindings.Add("Text", DataSource, "satisKodu");
            xrTableMasaAdi.DataBindings.Add("Text", DataSource, "Masalar.masaAdi");
            xrTableMenu.DataBindings.Add("Text", DataSource, "Urun.Menu.menuAdi");
            xrTableUrunAdi.DataBindings.Add("Text", DataSource, "Urun.urunAdi");
            xrTableMiktari.DataBindings.Add("Text", DataSource, "miktari");
            xrTableFiyati.DataBindings.Add("Text", DataSource, "birimFiyati");
            xrTableIndirimTutari.DataBindings.Add("Text", DataSource, "indirimTutari");
            xrTableAciklama.DataBindings.Add("Text", DataSource, "aciklama");
            xrTableTarih.DataBindings.Add("Text", DataSource, "tarih");
            
        }

      
    }
}
