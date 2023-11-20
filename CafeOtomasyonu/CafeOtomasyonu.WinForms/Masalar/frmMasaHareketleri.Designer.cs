namespace CafeOtomasyonu.WinForms.Masalar
{
    partial class frmMasaHareketleri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMasaHareketleri));
            this.lblBaslik = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsatisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasaAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMenuAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrunAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmasaId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colurunId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmiktari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colbirimFiyati = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colindirimTutari = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltarih = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasalar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUrun = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.Appearance.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBaslik.Appearance.Options.UseFont = true;
            this.lblBaslik.Appearance.Options.UseTextOptions = true;
            this.lblBaslik.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblBaslik.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(1594, 102);
            this.lblBaslik.TabIndex = 3;
            this.lblBaslik.Text = "Masa Hareketleri";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnYenile);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 726);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1594, 123);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.Appearance.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Appearance.Options.UseFont = true;
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(1464, 38);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(107, 70);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            // 
            // btnYenile
            // 
            this.btnYenile.Appearance.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.Appearance.Options.UseFont = true;
            this.btnYenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.ImageOptions.Image")));
            this.btnYenile.Location = new System.Drawing.Point(14, 38);
            this.btnYenile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(107, 70);
            this.btnYenile.TabIndex = 0;
            this.btnYenile.Text = "Yenile";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Location = new System.Drawing.Point(0, 102);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1594, 624);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colsatisKodu,
            this.colMasaAdi,
            this.colMenuAdi,
            this.colUrunAdi,
            this.colmasaId,
            this.colurunId,
            this.colmiktari,
            this.colbirimFiyati,
            this.colindirimTutari,
            this.colaciklama,
            this.coltarih,
            this.colMasalar,
            this.colUrun});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 23;
            this.colId.Name = "colId";
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 73;
            // 
            // colsatisKodu
            // 
            this.colsatisKodu.Caption = "Satış Kodu";
            this.colsatisKodu.FieldName = "satisKodu";
            this.colsatisKodu.MinWidth = 23;
            this.colsatisKodu.Name = "colsatisKodu";
            this.colsatisKodu.Visible = true;
            this.colsatisKodu.VisibleIndex = 1;
            this.colsatisKodu.Width = 86;
            // 
            // colMasaAdi
            // 
            this.colMasaAdi.Caption = "Masa Adı";
            this.colMasaAdi.FieldName = "Masalar.masaAdi";
            this.colMasaAdi.MinWidth = 23;
            this.colMasaAdi.Name = "colMasaAdi";
            this.colMasaAdi.Visible = true;
            this.colMasaAdi.VisibleIndex = 2;
            this.colMasaAdi.Width = 131;
            // 
            // colMenuAdi
            // 
            this.colMenuAdi.Caption = "Menü Adı";
            this.colMenuAdi.FieldName = "Urun.Menu.menuAdi";
            this.colMenuAdi.MinWidth = 23;
            this.colMenuAdi.Name = "colMenuAdi";
            this.colMenuAdi.Visible = true;
            this.colMenuAdi.VisibleIndex = 3;
            this.colMenuAdi.Width = 142;
            // 
            // colUrunAdi
            // 
            this.colUrunAdi.Caption = "Ürün Adı";
            this.colUrunAdi.FieldName = "Urun.urunAdi";
            this.colUrunAdi.MinWidth = 23;
            this.colUrunAdi.Name = "colUrunAdi";
            this.colUrunAdi.Visible = true;
            this.colUrunAdi.VisibleIndex = 4;
            this.colUrunAdi.Width = 126;
            // 
            // colmasaId
            // 
            this.colmasaId.FieldName = "masaId";
            this.colmasaId.MinWidth = 23;
            this.colmasaId.Name = "colmasaId";
            this.colmasaId.Width = 143;
            // 
            // colurunId
            // 
            this.colurunId.FieldName = "urunId";
            this.colurunId.MinWidth = 23;
            this.colurunId.Name = "colurunId";
            this.colurunId.Width = 143;
            // 
            // colmiktari
            // 
            this.colmiktari.Caption = "Miktarı";
            this.colmiktari.FieldName = "miktari";
            this.colmiktari.MinWidth = 23;
            this.colmiktari.Name = "colmiktari";
            this.colmiktari.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "miktari", "SUM={0:0.##}")});
            this.colmiktari.Visible = true;
            this.colmiktari.VisibleIndex = 5;
            this.colmiktari.Width = 111;
            // 
            // colbirimFiyati
            // 
            this.colbirimFiyati.Caption = "Birim Fiyatı";
            this.colbirimFiyati.DisplayFormat.FormatString = "C2";
            this.colbirimFiyati.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colbirimFiyati.FieldName = "birimFiyati";
            this.colbirimFiyati.MinWidth = 23;
            this.colbirimFiyati.Name = "colbirimFiyati";
            this.colbirimFiyati.Visible = true;
            this.colbirimFiyati.VisibleIndex = 6;
            this.colbirimFiyati.Width = 129;
            // 
            // colindirimTutari
            // 
            this.colindirimTutari.Caption = "İndirim Tutarı";
            this.colindirimTutari.DisplayFormat.FormatString = "C2";
            this.colindirimTutari.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colindirimTutari.FieldName = "indirimTutari";
            this.colindirimTutari.MinWidth = 23;
            this.colindirimTutari.Name = "colindirimTutari";
            this.colindirimTutari.Visible = true;
            this.colindirimTutari.VisibleIndex = 7;
            this.colindirimTutari.Width = 146;
            // 
            // colaciklama
            // 
            this.colaciklama.Caption = "Açıklama";
            this.colaciklama.FieldName = "aciklama";
            this.colaciklama.MinWidth = 23;
            this.colaciklama.Name = "colaciklama";
            this.colaciklama.Visible = true;
            this.colaciklama.VisibleIndex = 8;
            this.colaciklama.Width = 524;
            // 
            // coltarih
            // 
            this.coltarih.Caption = "Tarih";
            this.coltarih.DisplayFormat.FormatString = "d";
            this.coltarih.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.coltarih.FieldName = "tarih";
            this.coltarih.MinWidth = 23;
            this.coltarih.Name = "coltarih";
            this.coltarih.Visible = true;
            this.coltarih.VisibleIndex = 9;
            this.coltarih.Width = 427;
            // 
            // colMasalar
            // 
            this.colMasalar.FieldName = "Masalar";
            this.colMasalar.MinWidth = 23;
            this.colMasalar.Name = "colMasalar";
            this.colMasalar.Width = 143;
            // 
            // colUrun
            // 
            this.colUrun.FieldName = "Urun";
            this.colUrun.MinWidth = 23;
            this.colUrun.Name = "colUrun";
            this.colUrun.Width = 159;
            // 
            // frmMasaHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1594, 849);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.lblBaslik);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMasaHareketleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masa Hareketleri";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl lblBaslik;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colsatisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colmasaId;
        private DevExpress.XtraGrid.Columns.GridColumn colurunId;
        private DevExpress.XtraGrid.Columns.GridColumn colmiktari;
        private DevExpress.XtraGrid.Columns.GridColumn colbirimFiyati;
        private DevExpress.XtraGrid.Columns.GridColumn colindirimTutari;
        private DevExpress.XtraGrid.Columns.GridColumn colaciklama;
        private DevExpress.XtraGrid.Columns.GridColumn coltarih;
        private DevExpress.XtraGrid.Columns.GridColumn colMasalar;
        private DevExpress.XtraGrid.Columns.GridColumn colUrun;
        private DevExpress.XtraGrid.Columns.GridColumn colMasaAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colMenuAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colUrunAdi;
    }
}