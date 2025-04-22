namespace otomasyon_proje_uygulması.Modul_Kasa
{
    partial class FrmKasaAcilisKarti
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasaAcilisKarti));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KASAKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.KASAADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BAKİYE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ACIKLAMA = new DevExpress.XtraGrid.Columns.GridColumn();
            this.BTNKAPAT = new DevExpress.XtraEditors.SimpleButton();
            this.BTNSİL = new DevExpress.XtraEditors.SimpleButton();
            this.BTNKAYDET = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtKasaKodu = new DevExpress.XtraEditors.TextEdit();
            this.txtKasaAdi = new DevExpress.XtraEditors.TextEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.Liste);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 379);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(810, 293);
            this.groupControl2.TabIndex = 6;
            this.groupControl2.Text = "BANKA LİSTESİ";
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(2, 23);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(806, 268);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.KASAKODU,
            this.KASAADI,
            this.BAKİYE,
            this.ACIKLAMA});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // KASAKODU
            // 
            this.KASAKODU.Caption = "KASA KODU";
            this.KASAKODU.FieldName = "KASAKODU";
            this.KASAKODU.Name = "KASAKODU";
            this.KASAKODU.OptionsColumn.AllowEdit = false;
            this.KASAKODU.OptionsColumn.AllowFocus = false;
            this.KASAKODU.OptionsColumn.FixedWidth = true;
            this.KASAKODU.Visible = true;
            this.KASAKODU.VisibleIndex = 0;
            this.KASAKODU.Width = 100;
            // 
            // KASAADI
            // 
            this.KASAADI.Caption = "KASA ADI";
            this.KASAADI.FieldName = "KASAADI";
            this.KASAADI.Name = "KASAADI";
            this.KASAADI.OptionsColumn.AllowEdit = false;
            this.KASAADI.OptionsColumn.AllowFocus = false;
            this.KASAADI.Visible = true;
            this.KASAADI.VisibleIndex = 1;
            this.KASAADI.Width = 521;
            // 
            // BAKİYE
            // 
            this.BAKİYE.Caption = "BAKİYE";
            this.BAKİYE.FieldName = "BAKİYE";
            this.BAKİYE.Name = "BAKİYE";
            this.BAKİYE.OptionsColumn.AllowEdit = false;
            this.BAKİYE.OptionsColumn.AllowFocus = false;
            this.BAKİYE.OptionsColumn.FixedWidth = true;
            this.BAKİYE.Visible = true;
            this.BAKİYE.VisibleIndex = 2;
            this.BAKİYE.Width = 100;
            // 
            // ACIKLAMA
            // 
            this.ACIKLAMA.Caption = "ACIKLAMA";
            this.ACIKLAMA.FieldName = "ACIKLAMA";
            this.ACIKLAMA.Name = "ACIKLAMA";
            // 
            // BTNKAPAT
            // 
            this.BTNKAPAT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNKAPAT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNKAPAT.ImageOptions.Image")));
            this.BTNKAPAT.Location = new System.Drawing.Point(614, 291);
            this.BTNKAPAT.Name = "BTNKAPAT";
            this.BTNKAPAT.Size = new System.Drawing.Size(158, 50);
            this.BTNKAPAT.TabIndex = 2;
            this.BTNKAPAT.Text = "KAPAT";
            this.BTNKAPAT.Click += new System.EventHandler(this.BTNKAPAT_Click);
            // 
            // BTNSİL
            // 
            this.BTNSİL.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNSİL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNSİL.ImageOptions.Image")));
            this.BTNSİL.Location = new System.Drawing.Point(614, 188);
            this.BTNSİL.Name = "BTNSİL";
            this.BTNSİL.Size = new System.Drawing.Size(158, 50);
            this.BTNSİL.TabIndex = 1;
            this.BTNSİL.Text = "SİL";
            this.BTNSİL.Click += new System.EventHandler(this.BTNSİL_Click);
            // 
            // BTNKAYDET
            // 
            this.BTNKAYDET.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BTNKAYDET.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNKAYDET.ImageOptions.Image")));
            this.BTNKAYDET.Location = new System.Drawing.Point(614, 99);
            this.BTNKAYDET.Name = "BTNKAYDET";
            this.BTNKAYDET.Size = new System.Drawing.Size(158, 50);
            this.BTNKAYDET.TabIndex = 0;
            this.BTNKAYDET.Text = "KAYDET";
            this.BTNKAYDET.Click += new System.EventHandler(this.BTNKAYDET_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(12, 101);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(58, 13);
            this.labelControl8.TabIndex = 15;
            this.labelControl8.Text = "AÇIKLAMA :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 60);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(54, 13);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "KASA ADI :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(64, 13);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "KASA KODU :";
            // 
            // txtKasaKodu
            // 
            this.txtKasaKodu.Location = new System.Drawing.Point(108, 23);
            this.txtKasaKodu.Name = "txtKasaKodu";
            this.txtKasaKodu.Size = new System.Drawing.Size(484, 20);
            this.txtKasaKodu.TabIndex = 0;
            // 
            // txtKasaAdi
            // 
            this.txtKasaAdi.Location = new System.Drawing.Point(108, 57);
            this.txtKasaAdi.Name = "txtKasaAdi";
            this.txtKasaAdi.Size = new System.Drawing.Size(484, 20);
            this.txtKasaAdi.TabIndex = 2;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BTNKAPAT);
            this.groupControl1.Controls.Add(this.BTNSİL);
            this.groupControl1.Controls.Add(this.BTNKAYDET);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtKasaAdi);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtKasaKodu);
            this.groupControl1.Controls.Add(this.txtAciklama);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(810, 379);
            this.groupControl1.TabIndex = 5;
            this.groupControl1.Text = "BANKA BİLGİLERİ";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(107, 98);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(485, 243);
            this.txtAciklama.TabIndex = 14;
            // 
            // FrmKasaAcilisKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(810, 672);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmKasaAcilisKarti.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKasaAcilisKarti";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KASA AÇILIŞ KARTI";
            this.Load += new System.EventHandler(this.FrmKasaAcilisKarti_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn KASAKODU;
        private DevExpress.XtraGrid.Columns.GridColumn KASAADI;
        private DevExpress.XtraGrid.Columns.GridColumn BAKİYE;
        private DevExpress.XtraEditors.SimpleButton BTNKAPAT;
        private DevExpress.XtraEditors.SimpleButton BTNSİL;
        private DevExpress.XtraEditors.SimpleButton BTNKAYDET;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtKasaKodu;
        private DevExpress.XtraEditors.TextEdit txtKasaAdi;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraGrid.Columns.GridColumn ACIKLAMA;
    }
}