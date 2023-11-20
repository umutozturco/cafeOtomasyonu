namespace CafeOtomasyonu.WinForms.Satislar
{
    partial class frmSatislar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSatislar));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupIslemler = new DevExpress.XtraEditors.GroupControl();
            this.dropDownButton1 = new DevExpress.XtraEditors.DropDownButton();
            this.popupMenu1 = new DevExpress.XtraBars.PopupMenu(this.components);
            this.btnExcelExport = new DevExpress.XtraBars.BarButtonItem();
            this.btnWordExport = new DevExpress.XtraBars.BarButtonItem();
            this.btnPdfExport = new DevExpress.XtraBars.BarButtonItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnOdemeHareketleri = new DevExpress.XtraEditors.SimpleButton();
            this.btnYenile = new DevExpress.XtraEditors.SimpleButton();
            this.btnSiparisDetaylari = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsatisKodu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMusteriAdSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colmusterId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltutar = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colindirimToplami = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colodenen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkalan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colsonIslemTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPaketSiparisMi = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).BeginInit();
            this.groupIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1426, 83);
            this.labelControl1.TabIndex = 2;
            this.labelControl1.Text = "Satışlar";
            // 
            // groupIslemler
            // 
            this.groupIslemler.Controls.Add(this.dropDownButton1);
            this.groupIslemler.Controls.Add(this.btnKapat);
            this.groupIslemler.Controls.Add(this.btnOdemeHareketleri);
            this.groupIslemler.Controls.Add(this.btnYenile);
            this.groupIslemler.Controls.Add(this.btnSiparisDetaylari);
            this.groupIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupIslemler.Location = new System.Drawing.Point(0, 605);
            this.groupIslemler.Name = "groupIslemler";
            this.groupIslemler.Size = new System.Drawing.Size(1426, 89);
            this.groupIslemler.TabIndex = 4;
            this.groupIslemler.Text = "İşlemler";
            // 
            // dropDownButton1
            // 
            this.dropDownButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dropDownButton1.DropDownControl = this.popupMenu1;
            this.dropDownButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("dropDownButton1.ImageOptions.Image")));
            this.dropDownButton1.Location = new System.Drawing.Point(1175, 31);
            this.dropDownButton1.Name = "dropDownButton1";
            this.dropDownButton1.Size = new System.Drawing.Size(135, 42);
            this.dropDownButton1.TabIndex = 6;
            this.dropDownButton1.Text = "Export";
            // 
            // popupMenu1
            // 
            this.popupMenu1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnExcelExport),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnWordExport),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnPdfExport)});
            this.popupMenu1.Manager = this.barManager1;
            this.popupMenu1.Name = "popupMenu1";
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.Caption = "Excel Dosyası(*.xlsx)";
            this.btnExcelExport.Id = 0;
            this.btnExcelExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelExport.ImageOptions.Image")));
            this.btnExcelExport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnExcelExport.ImageOptions.LargeImage")));
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Tag = "Excel Dosyası(*.xlsx)|*.xlsx";
            this.btnExcelExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
            // 
            // btnWordExport
            // 
            this.btnWordExport.Caption = "Word Dosyaları(*.docx)";
            this.btnWordExport.Id = 1;
            this.btnWordExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnWordExport.ImageOptions.Image")));
            this.btnWordExport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnWordExport.ImageOptions.LargeImage")));
            this.btnWordExport.Name = "btnWordExport";
            this.btnWordExport.Tag = "Word Dosyaları(*.docx)|*.docx";
            this.btnWordExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
            // 
            // btnPdfExport
            // 
            this.btnPdfExport.Caption = "Pdf Dosyaları(*.pdf)";
            this.btnPdfExport.Id = 2;
            this.btnPdfExport.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPdfExport.ImageOptions.Image")));
            this.btnPdfExport.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnPdfExport.ImageOptions.LargeImage")));
            this.btnPdfExport.Name = "btnPdfExport";
            this.btnPdfExport.Tag = "Pdf Dosyaları(*.pdf)|*.pdf";
            this.btnPdfExport.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.Export_ItemClick);
            // 
            // barManager1
            // 
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnExcelExport,
            this.btnWordExport,
            this.btnPdfExport});
            this.barManager1.MaxItemId = 3;
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1426, 0);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 694);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1426, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 0);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 694);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1426, 0);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 694);
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Appearance.Options.UseFont = true;
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(1316, 31);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(92, 42);
            this.btnKapat.TabIndex = 4;
            this.btnKapat.Text = "Kapat";
            // 
            // btnOdemeHareketleri
            // 
            this.btnOdemeHareketleri.Appearance.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOdemeHareketleri.Appearance.Options.UseFont = true;
            this.btnOdemeHareketleri.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnOdemeHareketleri.ImageOptions.Image")));
            this.btnOdemeHareketleri.Location = new System.Drawing.Point(146, 32);
            this.btnOdemeHareketleri.Name = "btnOdemeHareketleri";
            this.btnOdemeHareketleri.Size = new System.Drawing.Size(110, 42);
            this.btnOdemeHareketleri.TabIndex = 1;
            this.btnOdemeHareketleri.Text = "Ödeme \r\nHareketleri";
            this.btnOdemeHareketleri.Click += new System.EventHandler(this.btnOdemeHareketleri_Click);
            // 
            // btnYenile
            // 
            this.btnYenile.Appearance.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYenile.Appearance.Options.UseFont = true;
            this.btnYenile.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYenile.ImageOptions.Image")));
            this.btnYenile.Location = new System.Drawing.Point(262, 32);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(126, 42);
            this.btnYenile.TabIndex = 1;
            this.btnYenile.Text = "Yenile-Listele";
            // 
            // btnSiparisDetaylari
            // 
            this.btnSiparisDetaylari.Appearance.Font = new System.Drawing.Font("Calibri", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSiparisDetaylari.Appearance.Options.UseFont = true;
            this.btnSiparisDetaylari.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSiparisDetaylari.ImageOptions.Image")));
            this.btnSiparisDetaylari.Location = new System.Drawing.Point(14, 32);
            this.btnSiparisDetaylari.Name = "btnSiparisDetaylari";
            this.btnSiparisDetaylari.Size = new System.Drawing.Size(126, 42);
            this.btnSiparisDetaylari.TabIndex = 3;
            this.btnSiparisDetaylari.Text = "Sipariş Detayları";
            this.btnSiparisDetaylari.Click += new System.EventHandler(this.btnSiparisDetaylari_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 83);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1426, 522);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colsatisKodu,
            this.colMusteriAdSoyad,
            this.colmusterId,
            this.coltutar,
            this.colindirimToplami,
            this.colodenen,
            this.colkalan,
            this.colaciklama,
            this.colsonIslemTarihi,
            this.colPaketSiparisMi});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowFooter = true;
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 56;
            // 
            // colsatisKodu
            // 
            this.colsatisKodu.Caption = "Satış Kodu";
            this.colsatisKodu.FieldName = "satisKodu";
            this.colsatisKodu.Name = "colsatisKodu";
            this.colsatisKodu.OptionsColumn.AllowEdit = false;
            this.colsatisKodu.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Count, "satisKodu", "Kayıt:{0}")});
            this.colsatisKodu.Visible = true;
            this.colsatisKodu.VisibleIndex = 1;
            // 
            // colMusteriAdSoyad
            // 
            this.colMusteriAdSoyad.Caption = "Müşteri Ad Soyad";
            this.colMusteriAdSoyad.FieldName = "Musteriler.adSoyad";
            this.colMusteriAdSoyad.Name = "colMusteriAdSoyad";
            this.colMusteriAdSoyad.OptionsColumn.AllowEdit = false;
            this.colMusteriAdSoyad.Visible = true;
            this.colMusteriAdSoyad.VisibleIndex = 2;
            this.colMusteriAdSoyad.Width = 142;
            // 
            // colmusterId
            // 
            this.colmusterId.FieldName = "musterId";
            this.colmusterId.Name = "colmusterId";
            this.colmusterId.OptionsColumn.AllowEdit = false;
            this.colmusterId.Width = 66;
            // 
            // coltutar
            // 
            this.coltutar.Caption = "Tutar";
            this.coltutar.DisplayFormat.FormatString = "C2";
            this.coltutar.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.coltutar.FieldName = "tutar";
            this.coltutar.Name = "coltutar";
            this.coltutar.OptionsColumn.AllowEdit = false;
            this.coltutar.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "tutar", "Tutar={0:C2}")});
            this.coltutar.Visible = true;
            this.coltutar.VisibleIndex = 3;
            this.coltutar.Width = 97;
            // 
            // colindirimToplami
            // 
            this.colindirimToplami.Caption = "İndirim Toplamı";
            this.colindirimToplami.DisplayFormat.FormatString = "C2";
            this.colindirimToplami.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colindirimToplami.FieldName = "indirimToplami";
            this.colindirimToplami.Name = "colindirimToplami";
            this.colindirimToplami.OptionsColumn.AllowEdit = false;
            this.colindirimToplami.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "indirimToplami", "{0:C2}")});
            this.colindirimToplami.Visible = true;
            this.colindirimToplami.VisibleIndex = 4;
            this.colindirimToplami.Width = 123;
            // 
            // colodenen
            // 
            this.colodenen.Caption = "Ödenen";
            this.colodenen.DisplayFormat.FormatString = "C2";
            this.colodenen.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.colodenen.FieldName = "odenen";
            this.colodenen.Name = "colodenen";
            this.colodenen.OptionsColumn.AllowEdit = false;
            this.colodenen.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "odenen", "{0:C2}")});
            this.colodenen.Visible = true;
            this.colodenen.VisibleIndex = 5;
            this.colodenen.Width = 118;
            // 
            // colkalan
            // 
            this.colkalan.Caption = "Kalan";
            this.colkalan.FieldName = "kalan";
            this.colkalan.Name = "colkalan";
            this.colkalan.OptionsColumn.AllowEdit = false;
            this.colkalan.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "kalan", "{0:0.##}")});
            this.colkalan.Visible = true;
            this.colkalan.VisibleIndex = 6;
            this.colkalan.Width = 119;
            // 
            // colaciklama
            // 
            this.colaciklama.Caption = "Açıklama";
            this.colaciklama.FieldName = "aciklama";
            this.colaciklama.Name = "colaciklama";
            this.colaciklama.OptionsColumn.AllowEdit = false;
            this.colaciklama.Visible = true;
            this.colaciklama.VisibleIndex = 7;
            this.colaciklama.Width = 265;
            // 
            // colsonIslemTarihi
            // 
            this.colsonIslemTarihi.Caption = "Son İşlem Tarihi";
            this.colsonIslemTarihi.FieldName = "sonIslemTarihi";
            this.colsonIslemTarihi.Name = "colsonIslemTarihi";
            this.colsonIslemTarihi.OptionsColumn.AllowEdit = false;
            this.colsonIslemTarihi.Visible = true;
            this.colsonIslemTarihi.VisibleIndex = 8;
            this.colsonIslemTarihi.Width = 269;
            // 
            // colPaketSiparisMi
            // 
            this.colPaketSiparisMi.Caption = "Paket Sipariş mi";
            this.colPaketSiparisMi.FieldName = "paketSiparisMi";
            this.colPaketSiparisMi.Name = "colPaketSiparisMi";
            this.colPaketSiparisMi.OptionsColumn.AllowEdit = false;
            this.colPaketSiparisMi.Visible = true;
            this.colPaketSiparisMi.VisibleIndex = 9;
            this.colPaketSiparisMi.Width = 137;
            // 
            // frmSatislar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1426, 694);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupIslemler);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "frmSatislar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Satışlar";
            ((System.ComponentModel.ISupportInitialize)(this.groupIslemler)).EndInit();
            this.groupIslemler.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.popupMenu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupIslemler;
        private DevExpress.XtraEditors.SimpleButton btnKapat;
        private DevExpress.XtraEditors.SimpleButton btnOdemeHareketleri;
        private DevExpress.XtraEditors.SimpleButton btnYenile;
        private DevExpress.XtraEditors.SimpleButton btnSiparisDetaylari;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colsatisKodu;
        private DevExpress.XtraGrid.Columns.GridColumn colmusterId;
        private DevExpress.XtraGrid.Columns.GridColumn coltutar;
        private DevExpress.XtraGrid.Columns.GridColumn colindirimToplami;
        private DevExpress.XtraGrid.Columns.GridColumn colodenen;
        private DevExpress.XtraGrid.Columns.GridColumn colkalan;
        private DevExpress.XtraGrid.Columns.GridColumn colaciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colsonIslemTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colMusteriAdSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn colPaketSiparisMi;
        private DevExpress.XtraEditors.DropDownButton dropDownButton1;
        private DevExpress.XtraBars.PopupMenu popupMenu1;
        private DevExpress.XtraBars.BarButtonItem btnExcelExport;
        private DevExpress.XtraBars.BarButtonItem btnWordExport;
        private DevExpress.XtraBars.BarButtonItem btnPdfExport;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}