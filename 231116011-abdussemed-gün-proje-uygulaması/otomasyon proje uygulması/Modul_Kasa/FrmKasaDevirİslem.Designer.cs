namespace otomasyon_proje_uygulması.Modul_Kasa
{
    partial class FrmKasaDevirİslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmKasaDevirİslem));
            this.BTNKAPAT = new DevExpress.XtraEditors.SimpleButton();
            this.BTNSİL = new DevExpress.XtraEditors.SimpleButton();
            this.BTNKAYDET = new DevExpress.XtraEditors.SimpleButton();
            this.txtKasaKodu = new DevExpress.XtraEditors.ButtonEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtKasaAdi = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.txtBelgeNo = new DevExpress.XtraEditors.ButtonEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.rbtnCikis = new System.Windows.Forms.RadioButton();
            this.rbtnGiris = new System.Windows.Forms.RadioButton();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNKAPAT
            // 
            this.BTNKAPAT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNKAPAT.ImageOptions.Image")));
            this.BTNKAPAT.Location = new System.Drawing.Point(563, 153);
            this.BTNKAPAT.Name = "BTNKAPAT";
            this.BTNKAPAT.Size = new System.Drawing.Size(158, 35);
            this.BTNKAPAT.TabIndex = 12;
            this.BTNKAPAT.Text = "KAPAT";
            this.BTNKAPAT.Click += new System.EventHandler(this.BTNKAPAT_Click);
            // 
            // BTNSİL
            // 
            this.BTNSİL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNSİL.ImageOptions.Image")));
            this.BTNSİL.Location = new System.Drawing.Point(563, 97);
            this.BTNSİL.Name = "BTNSİL";
            this.BTNSİL.Size = new System.Drawing.Size(158, 35);
            this.BTNSİL.TabIndex = 11;
            this.BTNSİL.Text = "SİL";
            this.BTNSİL.Click += new System.EventHandler(this.BTNSİL_Click);
            // 
            // BTNKAYDET
            // 
            this.BTNKAYDET.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNKAYDET.ImageOptions.Image")));
            this.BTNKAYDET.Location = new System.Drawing.Point(563, 41);
            this.BTNKAYDET.Name = "BTNKAYDET";
            this.BTNKAYDET.Size = new System.Drawing.Size(158, 35);
            this.BTNKAYDET.TabIndex = 10;
            this.BTNKAYDET.Text = "KAYDET";
            this.BTNKAYDET.Click += new System.EventHandler(this.BTNKAYDET_Click);
            // 
            // txtKasaKodu
            // 
            this.txtKasaKodu.Location = new System.Drawing.Point(106, 109);
            this.txtKasaKodu.Name = "txtKasaKodu";
            this.txtKasaKodu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtKasaKodu.Properties.ReadOnly = true;
            this.txtKasaKodu.Size = new System.Drawing.Size(238, 20);
            this.txtKasaKodu.TabIndex = 3;
            this.txtKasaKodu.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtKasaKodu_ButtonClick);
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(12, 168);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 13);
            this.labelControl6.TabIndex = 18;
            this.labelControl6.Text = "Açıklama :";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(12, 89);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(57, 13);
            this.labelControl7.TabIndex = 16;
            this.labelControl7.Text = "İşlem Türü :";
            // 
            // txtKasaAdi
            // 
            this.txtKasaAdi.Location = new System.Drawing.Point(106, 150);
            this.txtKasaAdi.Name = "txtKasaAdi";
            this.txtKasaAdi.Properties.ReadOnly = true;
            this.txtKasaAdi.Size = new System.Drawing.Size(238, 20);
            this.txtKasaAdi.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 153);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Kasa Adı :";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 112);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(57, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Kasa Kodu :";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(413, 45);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(33, 13);
            this.labelControl9.TabIndex = 12;
            this.labelControl9.Text = "Tutar :";
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(12, 49);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(31, 13);
            this.labelControl10.TabIndex = 10;
            this.labelControl10.Text = "Tarih :";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(106, 112);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(645, 185);
            this.txtAciklama.TabIndex = 19;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 63);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Belge Makbuz No :";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.BTNKAPAT);
            this.groupControl1.Controls.Add(this.BTNSİL);
            this.groupControl1.Controls.Add(this.BTNKAYDET);
            this.groupControl1.Controls.Add(this.txtKasaAdi);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtKasaKodu);
            this.groupControl1.Controls.Add(this.txtBelgeNo);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(766, 220);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "Kasa/ Cari Bilgileri";
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(106, 60);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtBelgeNo.Size = new System.Drawing.Size(238, 20);
            this.txtBelgeNo.TabIndex = 1;
            this.txtBelgeNo.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtBelgeNo_ButtonClick);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.rbtnCikis);
            this.groupControl2.Controls.Add(this.rbtnGiris);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.labelControl10);
            this.groupControl2.Controls.Add(this.txtAciklama);
            this.groupControl2.Controls.Add(this.txtTarih);
            this.groupControl2.Controls.Add(this.txtTutar);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(0, 220);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(766, 335);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "İşlem Bilgileri";
            // 
            // rbtnCikis
            // 
            this.rbtnCikis.AutoSize = true;
            this.rbtnCikis.Location = new System.Drawing.Point(242, 89);
            this.rbtnCikis.Name = "rbtnCikis";
            this.rbtnCikis.Size = new System.Drawing.Size(88, 17);
            this.rbtnCikis.TabIndex = 21;
            this.rbtnCikis.TabStop = true;
            this.rbtnCikis.Text = "ÇIKIŞ İŞLEMİ";
            this.rbtnCikis.UseVisualStyleBackColor = true;
            // 
            // rbtnGiris
            // 
            this.rbtnGiris.AutoSize = true;
            this.rbtnGiris.Location = new System.Drawing.Point(106, 87);
            this.rbtnGiris.Name = "rbtnGiris";
            this.rbtnGiris.Size = new System.Drawing.Size(89, 17);
            this.rbtnGiris.TabIndex = 20;
            this.rbtnGiris.TabStop = true;
            this.rbtnGiris.Text = "GİRİŞ İŞLEMİ";
            this.rbtnGiris.UseVisualStyleBackColor = true;
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = null;
            this.txtTarih.Location = new System.Drawing.Point(87, 42);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.DisplayFormat.FormatString = "";
            this.txtTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTarih.Properties.EditFormat.FormatString = "";
            this.txtTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTarih.Properties.MaskSettings.Set("mask", "");
            this.txtTarih.Size = new System.Drawing.Size(283, 20);
            this.txtTarih.TabIndex = 13;
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(468, 42);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTutar.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTutar.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtTutar.Properties.MaskSettings.Set("mask", "c");
            this.txtTutar.Size = new System.Drawing.Size(283, 20);
            this.txtTutar.TabIndex = 11;
            // 
            // FrmKasaDevirİslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(766, 555);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.IconOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("FrmKasaDevirİslem.IconOptions.LargeImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmKasaDevirİslem";
            this.Text = "KASA DEVİR İŞLEM";
            this.Load += new System.EventHandler(this.FrmKasaDevirİslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaKodu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKasaAdi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton BTNKAPAT;
        private DevExpress.XtraEditors.SimpleButton BTNSİL;
        private DevExpress.XtraEditors.SimpleButton BTNKAYDET;
        private DevExpress.XtraEditors.ButtonEdit txtKasaKodu;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtKasaAdi;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private System.Windows.Forms.RadioButton rbtnCikis;
        private System.Windows.Forms.RadioButton rbtnGiris;
        private DevExpress.XtraEditors.DateEdit txtTarih;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private DevExpress.XtraEditors.ButtonEdit txtBelgeNo;
    }
}