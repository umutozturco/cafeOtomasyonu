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
    public partial class frmMasaDurumlari : DevExpress.XtraEditors.XtraForm
    {
        private CafeContext context = new CafeContext();
        private CheckButton btnsender;
        private SatisKodu modelSatisKodu;
        private string _satisKodu;
        private int _masaId;
        private CafeOtomasyon.Entities.Models.Masalar masalar;
        private MasalarDal masalarDal = new MasalarDal();
        public frmMasaDurumlari()
        {
            InitializeComponent();
            modelSatisKodu = context.SatisKodu.First();
            MasalariGetir();

        }
        public void MasalariGetir()
        {
            flowLayoutPanel1.Controls.Clear();
            context = new CafeContext();
            var model = context.Masalars.ToList();
            for (int i = 0; i < model.Count; i++)
            {
                var btn = new CheckButton();
                btn.Text = model[i].masaAdi;
                btn.Name = model[i].Id.ToString();
                btn.Tag = model[i].SatisKodu;
                btn.Height = 75;
                btn.Width = 100;
                flowLayoutPanel1.Controls.Add(btn);
                if (model[i].rezerveMi && !model[i].durumu)
                {
                    btn.Appearance.BackColor = Color.SaddleBrown;
                }
                else if (model[i].durumu)
                {
                    btn.Appearance.BackColor = Color.IndianRed;
                }
                else if (!model[i].durumu)
                {
                    btn.Appearance.BackColor = Color.SeaGreen;
                }
                btn.Click += Btn_Click;

            }
        }

        public void DurumlariYenile()
        {
            btnSiparisEkle.Enabled = false;
            btnMasaAc.Enabled = false;
            btnRezervYap.Enabled = false;

        }
        private void Btn_Click(object sender, EventArgs e)
        {
            btnsender = sender as CheckButton;
            _masaId = Convert.ToInt32(btnsender.Name);

            DurumlariYenile();
            if (btnsender.Appearance.BackColor == Color.SaddleBrown)
            {
                btnMasaAc.Enabled = true;
            }
            else if (btnsender.Appearance.BackColor == Color.SeaGreen)
            {
                btnMasaAc.Enabled = true;
                btnRezervYap.Enabled = true;
            }
            else if (btnsender.Appearance.BackColor == Color.IndianRed)
            {
                btnSiparisEkle.Enabled = true;
            }
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            _satisKodu = btnsender.Tag.ToString();
            frmMasaSiparisleri frm = new frmMasaSiparisleri(masaId: _masaId, masaAdi: btnsender.Text,satisKodu:_satisKodu);
            frm.ShowDialog();
            btnsender = null;
            DurumlariYenile();
            MasalariGetir();
        }

        private void btnMasaAc_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(btnsender.Text + " açılsın mı?", " Bilgi", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                masalar = masalarDal.GetByFilter(context, m => m.Id == _masaId);
                masalar.SatisKodu = modelSatisKodu.satisTanimi + modelSatisKodu.sayi;
                masalar.durumu = true;
                masalar.rezerveMi = false;
                var sayiarttir = context.SatisKodu.First();
                sayiarttir.sayi++;
                masalarDal.Save(context);
                
                btnsender = null;
                DurumlariYenile();
                MasalariGetir();
                modelSatisKodu = context.SatisKodu.First();

            }

        }

        private void btnRezervYap_Click(object sender, EventArgs e)
        {
            frmRezervYap frm = new frmRezervYap(_masaId);
            frm.ShowDialog();
            DurumlariYenile();
            if (frm.islemyapildi)
            {

                MasalariGetir();

            }

            btnsender = null;
        }
    }
}