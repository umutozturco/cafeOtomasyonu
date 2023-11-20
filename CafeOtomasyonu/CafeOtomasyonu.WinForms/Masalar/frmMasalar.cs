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
using CafeOtomasyon.Entities.Mapping;

namespace CafeOtomasyonu.WinForms.Masalar
{
    
    public partial class frmMasalar : DevExpress.XtraEditors.XtraForm
    {
        
        private CafeContext context = new CafeContext();
        private MasalarDal masalarDal = new MasalarDal();
        public frmMasalar()
        {
            InitializeComponent();
            Listele();
            
        }
        
        private void Listele()
        {
            gridControl1.DataSource = masalarDal.MasalariListele(context);
        }


        private void btnYeni_Click(object sender, EventArgs e)
        {
            frmMasaKaydet frm = new frmMasaKaydet(new CafeOtomasyon.Entities.Models.Masalar());
            frm.ShowDialog();
            if (frm.kaydet)
            {
                Listele();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            var masalar = masalarDal.GetByFilter(context, m=>m.Id==seciliId);
            frmMasaKaydet frm = new frmMasaKaydet(masalar);
            frm.ShowDialog();
            if (frm.kaydet)
            {
                Listele();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            if (MessageBox.Show("Seçili kayıt silinecek. Onaylıyor musunuz?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                masalarDal.Delete(context, m => m.Id == seciliId);
                masalarDal.Save(context);
                Listele();
            }
        }

        private void btnDurumDegistir_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount>0)
            {
                int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                var masalar = masalarDal.GetByFilter(context, m => m.Id == seciliId);
                if (masalar.durumu)
                {
                    masalar.durumu = false;

                }
                else if (!masalar.durumu)
                {
                    masalar.durumu = true;
                } 
                masalarDal.Save(context);
                Listele();
            }
            
        }

        private void btnRezerveDegistir_Click(object sender, EventArgs e)
        {
            if (gridView1.SelectedRowsCount > 0)
            {
                int seciliId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
                var masalar = masalarDal.GetByFilter(context, m => m.Id == seciliId);
                if (masalar.rezerveMi)
                {
                    masalar.rezerveMi = false;

                }
                else if (!masalar.rezerveMi)
                {
                    masalar.rezerveMi = true;
                }
                masalarDal.Save(context);
                Listele();
            }
        }

        private void btnMasaHareketleri_Click(object sender, EventArgs e)
        {
            int masaId = Convert.ToInt32(gridView1.GetFocusedRowCellValue(colId));
            frmMasaHareketleri frm = new frmMasaHareketleri(masaId:masaId);
            frm.ShowDialog();
        }
    }
}