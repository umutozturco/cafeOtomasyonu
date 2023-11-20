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
using CafeOtomasyonu.WinForms.Masalar;
using CafeOtomasyonu.WinForms.Odemeler;

namespace CafeOtomasyonu.WinForms.Satislar
{
    public partial class frmSatislar : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        SatislarDal satislarDal = new SatislarDal();
        public frmSatislar()
        {
            InitializeComponent();
            gridControl1.DataSource = satislarDal.GetAll(context);
        }

        private void btnSiparisDetaylari_Click(object sender, EventArgs e)
        {
            string satisKodu = gridView1.GetFocusedRowCellValue(colsatisKodu).ToString();
            bool paketSiparis = Convert.ToBoolean( gridView1.GetFocusedRowCellValue(colPaketSiparisMi));
            frmMasaSiparisleri frm = new frmMasaSiparisleri(satisKodu:satisKodu,paketSiparis:paketSiparis);
            frm.ShowDialog();
        }

        private void btnOdemeHareketleri_Click(object sender, EventArgs e)
        {
            string satisKodu = gridView1.GetFocusedRowCellValue(colsatisKodu).ToString();
            frmOdemeHareketleri frm = new frmOdemeHareketleri(satisKodu: satisKodu);
            frm.ShowDialog();
        }

        private void Export_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = e.Item.Tag.ToString();
            if (dialog.ShowDialog()==DialogResult.OK)
            {
                if (e.Item==btnExcelExport)
                {
                    gridView1.ExportToXlsx(dialog.FileName);
                }
                else if (e.Item==btnWordExport)
                {
                    gridView1.ExportToDocx(dialog.FileName);
                }
                else if (e.Item == btnPdfExport)
                {
                    gridView1.ExportToPdf(dialog.FileName);
                }
            }
        }

        
    }
}