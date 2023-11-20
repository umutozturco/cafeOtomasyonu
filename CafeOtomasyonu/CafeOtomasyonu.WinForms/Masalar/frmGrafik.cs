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
using DevExpress.XtraLayout.Customization.Controls;

namespace CafeOtomasyonu.WinForms.Masalar
{
    public partial class frmGrafik : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();

        public frmGrafik()
        {
            InitializeComponent();
            var model = context.masaHareketleri.GroupBy(m => m.Urun.urunAdi).Select(s => new
            {
                urunAdi = s.Key,
                Miktar=s.Sum(m=>m.miktari)

            }).ToList();
            foreach (var item in model)
            {
                chartControl1.Series["Satış Grafiği"].Points.AddPoint(item.urunAdi,Convert.ToDouble(item.Miktar));
            }
        }
    }
}