namespace CafeOtomasyonu.WinForms.Urunler
{
    partial class frmUrunler
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrunler));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnMasaHareketleri = new DevExpress.XtraEditors.SimpleButton();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmenuId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colurunKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colurunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbirimFiyati1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbirimFiyati2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbirimFiyati3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colresim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.hizliSatis = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1286, 83);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "Ürünler";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.btnMasaHareketleri);
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnSil);
            this.groupControl1.Controls.Add(this.btnYenile);
            this.groupControl1.Controls.Add(this.btnDuzenle);
            this.groupControl1.Controls.Add(this.btnYeni);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 583);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1286, 100);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(447, 31);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(142, 57);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnMasaHareketleri
            // 
            this.btnMasaHareketleri.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMasaHareketleri.Appearance.Options.UseFont = true;
            this.btnMasaHareketleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMasaHareketleri.ImageOptions.Image")));
            this.btnMasaHareketleri.Location = new System.Drawing.Point(299, 31);
            this.btnMasaHareketleri.Name = "btnMasaHareketleri";
            this.btnMasaHareketleri.Size = new System.Drawing.Size(142, 57);
            this.btnMasaHareketleri.TabIndex = 2;
            this.btnMasaHareketleri.Text = "Masa Hareketleri";
            this.btnMasaHareketleri.Click += new System.EventHandler(this.btnMasaHareketleri_Click);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Appearance.Options.UseFont = true;
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(1175, 31);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(92, 57);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnSil
            // 
            this.btnSil.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSil.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Appearance.Options.UseFont = true;
            this.btnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSil.ImageOptions.Image")));
            this.btnSil.Location = new System.Drawing.Point(1077, 31);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(92, 57);
            this.btnSil.TabIndex = 0;
            this.btnSil.Text = "Sil";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.Appearance.Options.UseFont = true;
            this.btnYenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.ImageOptions.Image")));
            this.btnYenile.Location = new System.Drawing.Point(201, 31);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(92, 57);
            this.btnYenile.TabIndex = 0;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDuzenle.Appearance.Options.UseFont = true;
            this.btnDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDuzenle.ImageOptions.Image")));
            this.btnDuzenle.Location = new System.Drawing.Point(103, 31);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(92, 57);
            this.btnDuzenle.TabIndex = 0;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.Appearance.Options.UseFont = true;
            this.btnYeni.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeni.ImageOptions.Image")));
            this.btnYeni.Location = new System.Drawing.Point(5, 31);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(92, 57);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gridControl1.Location = new System.Drawing.Point(0, 83);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1286, 500);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colmenuId,
            this.colurunKodu,
            this.colurunAdi,
            this.colbirimFiyati1,
            this.colbirimFiyati2,
            this.colbirimFiyati3,
            this.colaciklama,
            this.coltarih,
            this.colresim,
            this.colMenu,
            this.colMenuAdi,
            this.hizliSatis});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 100;
            // 
            // colmenuId
            // 
            this.colmenuId.FieldName = "menuId";
            this.colmenuId.Name = "colmenuId";
            this.colmenuId.OptionsColumn.AllowEdit = false;
            // 
            // colurunKodu
            // 
            this.colurunKodu.Caption = "Ürün Kodu";
            this.colurunKodu.FieldName = "urunKodu";
            this.colurunKodu.Name = "colurunKodu";
            this.colurunKodu.OptionsColumn.AllowEdit = false;
            this.colurunKodu.Visible = true;
            this.colurunKodu.VisibleIndex = 2;
            this.colurunKodu.Width = 68;
            // 
            // colurunAdi
            // 
            this.colurunAdi.Caption = "Ürün Adı";
            this.colurunAdi.FieldName = "urunAdi";
            this.colurunAdi.Name = "colurunAdi";
            this.colurunAdi.OptionsColumn.AllowEdit = false;
            this.colurunAdi.Visible = true;
            this.colurunAdi.VisibleIndex = 3;
            this.colurunAdi.Width = 105;
            // 
            // colbirimFiyati1
            // 
            this.colbirimFiyati1.Caption = "Birim Fiyatı 1";
            this.colbirimFiyati1.FieldName = "birimFiyati1";
            this.colbirimFiyati1.Name = "colbirimFiyati1";
            this.colbirimFiyati1.OptionsColumn.AllowEdit = false;
            this.colbirimFiyati1.Visible = true;
            this.colbirimFiyati1.VisibleIndex = 4;
            this.colbirimFiyati1.Width = 87;
            // 
            // colbirimFiyati2
            // 
            this.colbirimFiyati2.Caption = "Birim Fiyatı 2";
            this.colbirimFiyati2.FieldName = "birimFiyati2";
            this.colbirimFiyati2.Name = "colbirimFiyati2";
            this.colbirimFiyati2.OptionsColumn.AllowEdit = false;
            this.colbirimFiyati2.Visible = true;
            this.colbirimFiyati2.VisibleIndex = 5;
            this.colbirimFiyati2.Width = 88;
            // 
            // colbirimFiyati3
            // 
            this.colbirimFiyati3.Caption = "Birim Fiyatı 3";
            this.colbirimFiyati3.FieldName = "birimFiyati3";
            this.colbirimFiyati3.Name = "colbirimFiyati3";
            this.colbirimFiyati3.OptionsColumn.AllowEdit = false;
            this.colbirimFiyati3.Visible = true;
            this.colbirimFiyati3.VisibleIndex = 6;
            this.colbirimFiyati3.Width = 80;
            // 
            // colaciklama
            // 
            this.colaciklama.Caption = "Açıklama";
            this.colaciklama.FieldName = "aciklama";
            this.colaciklama.Name = "colaciklama";
            this.colaciklama.OptionsColumn.AllowEdit = false;
            this.colaciklama.Visible = true;
            this.colaciklama.VisibleIndex = 7;
            this.colaciklama.Width = 143;
            // 
            // coltarih
            // 
            this.coltarih.Caption = "Tarih";
            this.coltarih.FieldName = "tarih";
            this.coltarih.Name = "coltarih";
            this.coltarih.OptionsColumn.AllowEdit = false;
            this.coltarih.Visible = true;
            this.coltarih.VisibleIndex = 8;
            this.coltarih.Width = 93;
            // 
            // colresim
            // 
            this.colresim.FieldName = "resim";
            this.colresim.Name = "colresim";
            this.colresim.OptionsColumn.AllowEdit = false;
            // 
            // colMenu
            // 
            this.colMenu.FieldName = "Menu";
            this.colMenu.Name = "colMenu";
            this.colMenu.OptionsColumn.AllowEdit = false;
            // 
            // colMenuAdi
            // 
            this.colMenuAdi.Caption = "Menü ";
            this.colMenuAdi.FieldName = "Menu.menuAdi";
            this.colMenuAdi.Name = "colMenuAdi";
            this.colMenuAdi.OptionsColumn.AllowEdit = false;
            this.colMenuAdi.Visible = true;
            this.colMenuAdi.VisibleIndex = 1;
            this.colMenuAdi.Width = 109;
            // 
            // hizliSatis
            // 
            this.hizliSatis.Caption = "Hızlı Satış";
            this.hizliSatis.FieldName = "hizliSatis";
            this.hizliSatis.Name = "hizliSatis";
            this.hizliSatis.Visible = true;
            this.hizliSatis.VisibleIndex = 9;
            // 
            // frmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 683);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmUrunler";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürünler";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnDuzenle;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colmenuId;
        private DevExpress.XtraGrid.Columns.GridColumn colurunKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colurunAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colbirimFiyati1;
        private DevExpress.XtraGrid.Columns.GridColumn colbirimFiyati2;
        private DevExpress.XtraGrid.Columns.GridColumn colbirimFiyati3;
        private DevExpress.XtraGrid.Columns.GridColumn colaciklama;
        private DevExpress.XtraGrid.Columns.GridColumn coltarih;
        private DevExpress.XtraGrid.Columns.GridColumn colresim;
        private DevExpress.XtraGrid.Columns.GridColumn colMenu;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuAdi;
        private DevExpress.XtraEditors.SimpleButton btnMasaHareketleri;
        private DevExpress.XtraGrid.Columns.GridColumn hizliSatis;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
    }
}