namespace otomasyon_proje_uygulması.modul_kullanici
{
    partial class frmKullaniciYönetimi
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
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.btnSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnSeciliKullanici = new DevExpress.XtraEditors.SimpleButton();
            this.btnYeniKullanici = new DevExpress.XtraEditors.SimpleButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KULLANICI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ISIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.SOYISIM = new DevExpress.XtraGrid.Columns.GridColumn();
            this.AKTIF = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KODU = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.btnSil);
            this.panelControl1.Controls.Add(this.btnSeciliKullanici);
            this.panelControl1.Controls.Add(this.btnYeniKullanici);
            this.panelControl1.Location = new System.Drawing.Point(-2, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(811, 199);
            this.panelControl1.TabIndex = 0;
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(316, 20);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(134, 77);
            this.btnSil.TabIndex = 2;
            this.btnSil.Text = "SEÇİLİ KULLANICI SİL";
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnSeciliKullanici
            // 
            this.btnSeciliKullanici.Location = new System.Drawing.Point(154, 20);
            this.btnSeciliKullanici.Name = "btnSeciliKullanici";
            this.btnSeciliKullanici.Size = new System.Drawing.Size(156, 77);
            this.btnSeciliKullanici.TabIndex = 1;
            this.btnSeciliKullanici.Text = "SEÇİLİ KULLANICI GÜNCELLE";
            this.btnSeciliKullanici.Click += new System.EventHandler(this.btnSeciliKullanici_Click);
            // 
            // btnYeniKullanici
            // 
            this.btnYeniKullanici.Location = new System.Drawing.Point(27, 20);
            this.btnYeniKullanici.Name = "btnYeniKullanici";
            this.btnYeniKullanici.Size = new System.Drawing.Size(121, 77);
            this.btnYeniKullanici.TabIndex = 0;
            this.btnYeniKullanici.Text = "YENİ KULLANICI GİRİŞİ";
            this.btnYeniKullanici.Click += new System.EventHandler(this.btnYeniKullanici_Click);
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(-2, 205);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(811, 281);
            this.gridControl1.TabIndex = 1;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.KULLANICI,
            this.ISIM,
            this.SOYISIM,
            this.AKTIF,
            this.KODU});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Visible = true;
            this.ID.VisibleIndex = 0;
            // 
            // KULLANICI
            // 
            this.KULLANICI.Caption = "KULLANICI";
            this.KULLANICI.FieldName = "KULLANICI";
            this.KULLANICI.Name = "KULLANICI";
            this.KULLANICI.Visible = true;
            this.KULLANICI.VisibleIndex = 1;
            // 
            // ISIM
            // 
            this.ISIM.Caption = "İSİM";
            this.ISIM.FieldName = "İSİM";
            this.ISIM.Name = "ISIM";
            this.ISIM.Visible = true;
            this.ISIM.VisibleIndex = 2;
            // 
            // SOYISIM
            // 
            this.SOYISIM.Caption = "SOYISIM";
            this.SOYISIM.FieldName = "SOYISIM";
            this.SOYISIM.Name = "SOYISIM";
            this.SOYISIM.Visible = true;
            this.SOYISIM.VisibleIndex = 3;
            // 
            // AKTIF
            // 
            this.AKTIF.Caption = "AKTIF";
            this.AKTIF.FieldName = "AKTIF";
            this.AKTIF.Name = "AKTIF";
            this.AKTIF.Visible = true;
            this.AKTIF.VisibleIndex = 4;
            // 
            // KODU
            // 
            this.KODU.Caption = "KODU";
            this.KODU.FieldName = "KODU";
            this.KODU.Name = "KODU";
            this.KODU.Visible = true;
            this.KODU.VisibleIndex = 5;
            // 
            // frmKullaniciYönetimi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 487);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl1);
            this.IconOptions.Image = global::otomasyon_proje_uygulması.Properties.Resources.Banka_Islem16x16;
            this.Name = "frmKullaniciYönetimi";
            this.Text = "KULLANICI YÖNETİM  PANEL";
            this.Load += new System.EventHandler(this.frmKullaniciYönetimi_Load);
            this.Click += new System.EventHandler(this.frmKullaniciYönetimi_Click);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton btnSil;
        private DevExpress.XtraEditors.SimpleButton btnSeciliKullanici;
        private DevExpress.XtraEditors.SimpleButton btnYeniKullanici;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn KULLANICI;
        private DevExpress.XtraGrid.Columns.GridColumn ISIM;
        private DevExpress.XtraGrid.Columns.GridColumn SOYISIM;
        private DevExpress.XtraGrid.Columns.GridColumn AKTIF;
        private DevExpress.XtraGrid.Columns.GridColumn KODU;
    }
}