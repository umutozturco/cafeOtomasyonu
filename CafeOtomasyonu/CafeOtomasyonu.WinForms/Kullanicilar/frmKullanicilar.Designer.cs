namespace CafeOtomasyonu.WinForms.Kullanicilar
{
    partial class frmKullanicilar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmKullanicilar));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnKapat = new DevExpress.XtraEditors.SimpleButton();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.btnRoller = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeni = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladSoyad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coltelefon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.coladres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colemail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colgorevi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkullaniciAdi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colparola = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colhatirlatmaSorusu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colcevap = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaciklama = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colkayitTarihi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colaktifMi = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIsAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colKullanıcıHareketleri = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMasalar = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Appearance.Options.UseTextOptions = true;
            this.labelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl1.Location = new System.Drawing.Point(0, 0);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(1564, 128);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Kullanıcılar";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnKapat);
            this.groupControl1.Controls.Add(this.btnKaydet);
            this.groupControl1.Controls.Add(this.btnRoller);
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.btnYeni);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 707);
            this.groupControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1564, 118);
            this.groupControl1.TabIndex = 9;
            this.groupControl1.Text = "İşlemler";
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKapat.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKapat.Appearance.Options.UseFont = true;
            this.btnKapat.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKapat.ImageOptions.Image")));
            this.btnKapat.Location = new System.Drawing.Point(1435, 47);
            this.btnKapat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(107, 63);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Appearance.Options.UseFont = true;
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKaydet.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(411, 41);
            this.btnKaydet.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(110, 63);
            this.btnKaydet.TabIndex = 0;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnRoller
            // 
            this.btnRoller.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRoller.Appearance.Options.UseFont = true;
            this.btnRoller.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRoller.ImageOptions.Image")));
            this.btnRoller.Location = new System.Drawing.Point(276, 41);
            this.btnRoller.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRoller.Name = "btnRoller";
            this.btnRoller.Size = new System.Drawing.Size(110, 63);
            this.btnRoller.TabIndex = 0;
            this.btnRoller.Text = "Roller";
            this.btnRoller.Click += new System.EventHandler(this.btnRoller_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncelle.Appearance.Options.UseFont = true;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuncelle.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(146, 41);
            this.btnGuncelle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(107, 63);
            this.btnGuncelle.TabIndex = 0;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // btnYeni
            // 
            this.btnYeni.Appearance.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeni.Appearance.Options.UseFont = true;
            this.btnYeni.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnYeni.ImageOptions.Image")));
            this.btnYeni.Location = new System.Drawing.Point(14, 41);
            this.btnYeni.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnYeni.Name = "btnYeni";
            this.btnYeni.Size = new System.Drawing.Size(107, 63);
            this.btnYeni.TabIndex = 0;
            this.btnYeni.Text = "Yeni";
            this.btnYeni.Click += new System.EventHandler(this.btnYeni_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Location = new System.Drawing.Point(0, 128);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1564, 579);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.coladSoyad,
            this.coltelefon,
            this.coladres,
            this.colemail,
            this.colgorevi,
            this.colkullaniciAdi,
            this.colparola,
            this.colhatirlatmaSorusu,
            this.colcevap,
            this.colaciklama,
            this.colkayitTarihi,
            this.colaktifMi,
            this.colIsAdmin,
            this.colKullanıcıHareketleri,
            this.colMasalar});
            this.gridView1.DetailHeight = 431;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.MinWidth = 23;
            this.colId.Name = "colId";
            this.colId.OptionsColumn.AllowEdit = false;
            this.colId.Visible = true;
            this.colId.VisibleIndex = 0;
            this.colId.Width = 135;
            // 
            // coladSoyad
            // 
            this.coladSoyad.Caption = "Ad Soyad";
            this.coladSoyad.FieldName = "adSoyad";
            this.coladSoyad.MinWidth = 23;
            this.coladSoyad.Name = "coladSoyad";
            this.coladSoyad.OptionsColumn.AllowEdit = false;
            this.coladSoyad.Visible = true;
            this.coladSoyad.VisibleIndex = 1;
            this.coladSoyad.Width = 206;
            // 
            // coltelefon
            // 
            this.coltelefon.Caption = "Telefon";
            this.coltelefon.FieldName = "telefon";
            this.coltelefon.MinWidth = 23;
            this.coltelefon.Name = "coltelefon";
            this.coltelefon.OptionsColumn.AllowEdit = false;
            this.coltelefon.Visible = true;
            this.coltelefon.VisibleIndex = 2;
            this.coltelefon.Width = 189;
            // 
            // coladres
            // 
            this.coladres.Caption = "Adres";
            this.coladres.FieldName = "adres";
            this.coladres.MinWidth = 23;
            this.coladres.Name = "coladres";
            this.coladres.OptionsColumn.AllowEdit = false;
            this.coladres.Visible = true;
            this.coladres.VisibleIndex = 3;
            this.coladres.Width = 203;
            // 
            // colemail
            // 
            this.colemail.Caption = "E-Mail";
            this.colemail.FieldName = "email";
            this.colemail.MinWidth = 23;
            this.colemail.Name = "colemail";
            this.colemail.OptionsColumn.AllowEdit = false;
            this.colemail.Visible = true;
            this.colemail.VisibleIndex = 4;
            this.colemail.Width = 157;
            // 
            // colgorevi
            // 
            this.colgorevi.Caption = "Görevi";
            this.colgorevi.FieldName = "gorevi";
            this.colgorevi.MinWidth = 23;
            this.colgorevi.Name = "colgorevi";
            this.colgorevi.OptionsColumn.AllowEdit = false;
            this.colgorevi.Visible = true;
            this.colgorevi.VisibleIndex = 5;
            this.colgorevi.Width = 124;
            // 
            // colkullaniciAdi
            // 
            this.colkullaniciAdi.Caption = "Kullanıcı Adı";
            this.colkullaniciAdi.FieldName = "kullaniciAdi";
            this.colkullaniciAdi.MinWidth = 23;
            this.colkullaniciAdi.Name = "colkullaniciAdi";
            this.colkullaniciAdi.OptionsColumn.AllowEdit = false;
            this.colkullaniciAdi.Visible = true;
            this.colkullaniciAdi.VisibleIndex = 6;
            this.colkullaniciAdi.Width = 150;
            // 
            // colparola
            // 
            this.colparola.FieldName = "parola";
            this.colparola.MinWidth = 23;
            this.colparola.Name = "colparola";
            this.colparola.OptionsColumn.AllowEdit = false;
            this.colparola.Width = 87;
            // 
            // colhatirlatmaSorusu
            // 
            this.colhatirlatmaSorusu.FieldName = "hatirlatmaSorusu";
            this.colhatirlatmaSorusu.MinWidth = 23;
            this.colhatirlatmaSorusu.Name = "colhatirlatmaSorusu";
            this.colhatirlatmaSorusu.OptionsColumn.AllowEdit = false;
            this.colhatirlatmaSorusu.Width = 87;
            // 
            // colcevap
            // 
            this.colcevap.FieldName = "cevap";
            this.colcevap.MinWidth = 23;
            this.colcevap.Name = "colcevap";
            this.colcevap.OptionsColumn.AllowEdit = false;
            this.colcevap.Width = 87;
            // 
            // colaciklama
            // 
            this.colaciklama.FieldName = "aciklama";
            this.colaciklama.MinWidth = 23;
            this.colaciklama.Name = "colaciklama";
            this.colaciklama.OptionsColumn.AllowEdit = false;
            this.colaciklama.Width = 87;
            // 
            // colkayitTarihi
            // 
            this.colkayitTarihi.Caption = "Kayıt Tarihi";
            this.colkayitTarihi.FieldName = "kayitTarihi";
            this.colkayitTarihi.MinWidth = 23;
            this.colkayitTarihi.Name = "colkayitTarihi";
            this.colkayitTarihi.OptionsColumn.AllowEdit = false;
            this.colkayitTarihi.Visible = true;
            this.colkayitTarihi.VisibleIndex = 7;
            this.colkayitTarihi.Width = 160;
            // 
            // colaktifMi
            // 
            this.colaktifMi.Caption = "Aktif Mi?";
            this.colaktifMi.FieldName = "aktifMi";
            this.colaktifMi.MinWidth = 23;
            this.colaktifMi.Name = "colaktifMi";
            this.colaktifMi.Visible = true;
            this.colaktifMi.VisibleIndex = 8;
            this.colaktifMi.Width = 117;
            // 
            // colIsAdmin
            // 
            this.colIsAdmin.Caption = "Admin Mi?";
            this.colIsAdmin.FieldName = "IsAdmin";
            this.colIsAdmin.MinWidth = 23;
            this.colIsAdmin.Name = "colIsAdmin";
            this.colIsAdmin.Visible = true;
            this.colIsAdmin.VisibleIndex = 9;
            this.colIsAdmin.Width = 93;
            // 
            // colKullanıcıHareketleri
            // 
            this.colKullanıcıHareketleri.FieldName = "KullanıcıHareketleri";
            this.colKullanıcıHareketleri.MinWidth = 23;
            this.colKullanıcıHareketleri.Name = "colKullanıcıHareketleri";
            this.colKullanıcıHareketleri.Width = 87;
            // 
            // colMasalar
            // 
            this.colMasalar.FieldName = "Masalar";
            this.colMasalar.MinWidth = 23;
            this.colMasalar.Name = "colMasalar";
            this.colMasalar.Width = 87;
            // 
            // frmKullanicilar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1564, 825);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.labelControl1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmKullanicilar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kullanıcılar Formu";
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
        private DevExpress.XtraEditors.SimpleButton btnRoller;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnYeni;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn coladSoyad;
        private DevExpress.XtraGrid.Columns.GridColumn coltelefon;
        private DevExpress.XtraGrid.Columns.GridColumn coladres;
        private DevExpress.XtraGrid.Columns.GridColumn colemail;
        private DevExpress.XtraGrid.Columns.GridColumn colgorevi;
        private DevExpress.XtraGrid.Columns.GridColumn colkullaniciAdi;
        private DevExpress.XtraGrid.Columns.GridColumn colparola;
        private DevExpress.XtraGrid.Columns.GridColumn colhatirlatmaSorusu;
        private DevExpress.XtraGrid.Columns.GridColumn colcevap;
        private DevExpress.XtraGrid.Columns.GridColumn colaciklama;
        private DevExpress.XtraGrid.Columns.GridColumn colkayitTarihi;
        private DevExpress.XtraGrid.Columns.GridColumn colaktifMi;
        private DevExpress.XtraGrid.Columns.GridColumn colIsAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn colKullanıcıHareketleri;
        private DevExpress.XtraGrid.Columns.GridColumn colMasalar;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
    }
}