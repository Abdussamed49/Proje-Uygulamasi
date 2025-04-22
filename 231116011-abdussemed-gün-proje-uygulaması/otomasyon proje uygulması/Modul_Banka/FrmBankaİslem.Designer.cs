namespace otomasyon_proje_uygulması.Modul_Banka
{
    partial class FrmBankaİslem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBankaİslem));
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.rbtnGiris = new System.Windows.Forms.RadioButton();
            this.rbtnCikis = new System.Windows.Forms.RadioButton();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtTutar = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtAciklama = new DevExpress.XtraEditors.MemoEdit();
            this.txtTarih = new DevExpress.XtraEditors.DateEdit();
            this.BTNKAPAT = new DevExpress.XtraEditors.SimpleButton();
            this.BTNSİL = new DevExpress.XtraEditors.SimpleButton();
            this.BTNKAYDET = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtHesapNo = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtBelgeNo = new DevExpress.XtraEditors.TextEdit();
            this.txtHesapAdı = new DevExpress.XtraEditors.ButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAdı.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.groupControl2);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Controls.Add(this.txtTutar);
            this.groupControl3.Controls.Add(this.labelControl4);
            this.groupControl3.Controls.Add(this.txtAciklama);
            this.groupControl3.Controls.Add(this.txtTarih);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl3.Location = new System.Drawing.Point(0, 193);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(703, 443);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.Text = "İŞLEM BİLGİLERİ";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.rbtnGiris);
            this.groupControl2.Controls.Add(this.rbtnCikis);
            this.groupControl2.Location = new System.Drawing.Point(271, 26);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(420, 133);
            this.groupControl2.TabIndex = 12;
            this.groupControl2.Text = "İŞLEM TÜRÜ";
            // 
            // rbtnGiris
            // 
            this.rbtnGiris.AutoSize = true;
            this.rbtnGiris.Checked = true;
            this.rbtnGiris.Location = new System.Drawing.Point(52, 26);
            this.rbtnGiris.Name = "rbtnGiris";
            this.rbtnGiris.Size = new System.Drawing.Size(89, 17);
            this.rbtnGiris.TabIndex = 0;
            this.rbtnGiris.TabStop = true;
            this.rbtnGiris.Text = "GİRİŞ İŞLEMİ";
            this.rbtnGiris.UseVisualStyleBackColor = true;
            // 
            // rbtnCikis
            // 
            this.rbtnCikis.AutoSize = true;
            this.rbtnCikis.Location = new System.Drawing.Point(52, 67);
            this.rbtnCikis.Name = "rbtnCikis";
            this.rbtnCikis.Size = new System.Drawing.Size(88, 17);
            this.rbtnCikis.TabIndex = 1;
            this.rbtnCikis.Text = "ÇIKIŞ İŞLEMİ";
            this.rbtnCikis.UseVisualStyleBackColor = true;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(11, 213);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(51, 13);
            this.labelControl6.TabIndex = 11;
            this.labelControl6.Text = "AÇIKLAMA";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(14, 89);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(33, 13);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "TUTAR";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(82, 86);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtTutar.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtTutar.Properties.MaskSettings.Set("mask", "c");
            this.txtTutar.Size = new System.Drawing.Size(183, 20);
            this.txtTutar.TabIndex = 8;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(14, 45);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(34, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "TARİH ";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(82, 165);
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(616, 122);
            this.txtAciklama.TabIndex = 10;
            // 
            // txtTarih
            // 
            this.txtTarih.EditValue = null;
            this.txtTarih.Location = new System.Drawing.Point(82, 42);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtTarih.Properties.DisplayFormat.FormatString = "";
            this.txtTarih.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTarih.Properties.EditFormat.FormatString = "";
            this.txtTarih.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.txtTarih.Properties.Mask.EditMask = "";
            this.txtTarih.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.txtTarih.Size = new System.Drawing.Size(183, 20);
            this.txtTarih.TabIndex = 5;
            // 
            // BTNKAPAT
            // 
            this.BTNKAPAT.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNKAPAT.ImageOptions.Image")));
            this.BTNKAPAT.Location = new System.Drawing.Point(503, 125);
            this.BTNKAPAT.Name = "BTNKAPAT";
            this.BTNKAPAT.Size = new System.Drawing.Size(158, 50);
            this.BTNKAPAT.TabIndex = 2;
            this.BTNKAPAT.Text = "KAPAT";
            this.BTNKAPAT.Click += new System.EventHandler(this.BTNKAPAT_Click);
            // 
            // BTNSİL
            // 
            this.BTNSİL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNSİL.ImageOptions.Image")));
            this.BTNSİL.Location = new System.Drawing.Point(503, 78);
            this.BTNSİL.Name = "BTNSİL";
            this.BTNSİL.Size = new System.Drawing.Size(158, 50);
            this.BTNSİL.TabIndex = 1;
            this.BTNSİL.Text = "SİL";
            this.BTNSİL.Click += new System.EventHandler(this.BTNSİL_Click);
            // 
            // BTNKAYDET
            // 
            this.BTNKAYDET.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNKAYDET.ImageOptions.Image")));
            this.BTNKAYDET.Location = new System.Drawing.Point(503, 35);
            this.BTNKAYDET.Name = "BTNKAYDET";
            this.BTNKAYDET.Size = new System.Drawing.Size(158, 50);
            this.BTNKAYDET.TabIndex = 0;
            this.BTNKAYDET.Text = "KAYDET";
            this.BTNKAYDET.Click += new System.EventHandler(this.BTNKAYDET_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtHesapNo);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.txtBelgeNo);
            this.groupControl1.Controls.Add(this.BTNKAPAT);
            this.groupControl1.Controls.Add(this.BTNSİL);
            this.groupControl1.Controls.Add(this.BTNKAYDET);
            this.groupControl1.Controls.Add(this.txtHesapAdı);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(703, 197);
            this.groupControl1.TabIndex = 4;
            this.groupControl1.Text = "TEMEL BİLGİLER";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(12, 96);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(50, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "HESAP NO";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(105, 93);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(130, 20);
            this.txtHesapNo.TabIndex = 7;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(87, 13);
            this.labelControl2.TabIndex = 6;
            this.labelControl2.Text = "HESAP ADI /TÜRÜ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 35);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "BELGE NO";
            // 
            // txtBelgeNo
            // 
            this.txtBelgeNo.Location = new System.Drawing.Point(105, 32);
            this.txtBelgeNo.Name = "txtBelgeNo";
            this.txtBelgeNo.Size = new System.Drawing.Size(130, 20);
            this.txtBelgeNo.TabIndex = 3;
            // 
            // txtHesapAdı
            // 
            this.txtHesapAdı.Location = new System.Drawing.Point(105, 65);
            this.txtHesapAdı.Name = "txtHesapAdı";
            this.txtHesapAdı.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.txtHesapAdı.Properties.ReadOnly = true;
            this.txtHesapAdı.Size = new System.Drawing.Size(130, 20);
            this.txtHesapAdı.TabIndex = 5;
            this.txtHesapAdı.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.txtHesapAdı_ButtonClick);
            // 
            // FrmBankaİslem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 636);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmBankaİslem";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BANKA İŞLEM";
            this.Load += new System.EventHandler(this.FrmBankaİslem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTutar.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAciklama.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTarih.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBelgeNo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHesapAdı.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton BTNKAPAT;
        private DevExpress.XtraEditors.SimpleButton BTNSİL;
        private DevExpress.XtraEditors.SimpleButton BTNKAYDET;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtHesapNo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtBelgeNo;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtTutar;
        private System.Windows.Forms.RadioButton rbtnCikis;
        private System.Windows.Forms.RadioButton rbtnGiris;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.MemoEdit txtAciklama;
        private DevExpress.XtraEditors.ButtonEdit txtHesapAdı;
        private DevExpress.XtraEditors.DateEdit txtTarih;
    }
}