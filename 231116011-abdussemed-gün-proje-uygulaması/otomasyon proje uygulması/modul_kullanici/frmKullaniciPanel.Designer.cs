namespace otomasyon_proje_uygulması.modul_kullanici
{
    partial class frmKullaniciPanel
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtkullaniciadi = new DevExpress.XtraEditors.TextEdit();
            this.btnkaydet = new DevExpress.XtraEditors.SimpleButton();
            this.rbtnaktif = new System.Windows.Forms.RadioButton();
            this.txtsifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtisim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtsifret = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtsoyisim = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtkullanıcıtürü = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btntemizle = new DevExpress.XtraEditors.SimpleButton();
            this.btnkapat = new DevExpress.XtraEditors.SimpleButton();
            this.rbtnpasif = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.txtkullaniciadi.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtisim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsifret.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoyisim.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkullanıcıtürü.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 15);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(80, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "KULLANICI ADI :";
            // 
            // txtkullaniciadi
            // 
            this.txtkullaniciadi.Location = new System.Drawing.Point(122, 12);
            this.txtkullaniciadi.Name = "txtkullaniciadi";
            this.txtkullaniciadi.Size = new System.Drawing.Size(139, 20);
            this.txtkullaniciadi.TabIndex = 1;
            // 
            // btnkaydet
            // 
            this.btnkaydet.ImageOptions.Image = global::otomasyon_proje_uygulması.Properties.Resources.Banka_Hareket16x16;
            this.btnkaydet.Location = new System.Drawing.Point(319, 15);
            this.btnkaydet.Name = "btnkaydet";
            this.btnkaydet.Size = new System.Drawing.Size(86, 34);
            this.btnkaydet.TabIndex = 2;
            this.btnkaydet.Text = "KAYDET";
            this.btnkaydet.Click += new System.EventHandler(this.btnkaydet_Click);
            // 
            // rbtnaktif
            // 
            this.rbtnaktif.AutoSize = true;
            this.rbtnaktif.Location = new System.Drawing.Point(319, 145);
            this.rbtnaktif.Name = "rbtnaktif";
            this.rbtnaktif.Size = new System.Drawing.Size(54, 17);
            this.rbtnaktif.TabIndex = 3;
            this.rbtnaktif.TabStop = true;
            this.rbtnaktif.Text = "AKTİF";
            this.rbtnaktif.UseVisualStyleBackColor = true;
            // 
            // txtsifre
            // 
            this.txtsifre.Location = new System.Drawing.Point(122, 58);
            this.txtsifre.Name = "txtsifre";
            this.txtsifre.Size = new System.Drawing.Size(139, 20);
            this.txtsifre.TabIndex = 5;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 61);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "ŞİFRE :";
            // 
            // txtisim
            // 
            this.txtisim.Location = new System.Drawing.Point(122, 144);
            this.txtisim.Name = "txtisim";
            this.txtisim.Size = new System.Drawing.Size(139, 20);
            this.txtisim.TabIndex = 9;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(18, 151);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(22, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "İSİM";
            // 
            // txtsifret
            // 
            this.txtsifret.Location = new System.Drawing.Point(122, 98);
            this.txtsifret.Name = "txtsifret";
            this.txtsifret.Size = new System.Drawing.Size(139, 20);
            this.txtsifret.TabIndex = 7;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(12, 101);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(79, 13);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "ŞİFRE (TEKRAR)";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(18, 243);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(82, 13);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "KULLANICI TÜRÜ";
            // 
            // txtsoyisim
            // 
            this.txtsoyisim.Location = new System.Drawing.Point(122, 194);
            this.txtsoyisim.Name = "txtsoyisim";
            this.txtsoyisim.Size = new System.Drawing.Size(139, 20);
            this.txtsoyisim.TabIndex = 11;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(18, 197);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 13);
            this.labelControl6.TabIndex = 10;
            this.labelControl6.Text = "SOYİSİM";
            // 
            // txtkullanıcıtürü
            // 
            this.txtkullanıcıtürü.EditValue = "normal";
            this.txtkullanıcıtürü.Location = new System.Drawing.Point(122, 240);
            this.txtkullanıcıtürü.Name = "txtkullanıcıtürü";
            this.txtkullanıcıtürü.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtkullanıcıtürü.Properties.Items.AddRange(new object[] {
            "yönetici",
            "normal"});
            this.txtkullanıcıtürü.Size = new System.Drawing.Size(139, 20);
            this.txtkullanıcıtürü.TabIndex = 13;
            // 
            // btntemizle
            // 
            this.btntemizle.ImageOptions.Image = global::otomasyon_proje_uygulması.Properties.Resources.BankaEFT32x32;
            this.btntemizle.Location = new System.Drawing.Point(319, 55);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(86, 34);
            this.btntemizle.TabIndex = 14;
            this.btntemizle.Text = "TEMİZLE";
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // btnkapat
            // 
            this.btnkapat.ImageOptions.Image = global::otomasyon_proje_uygulması.Properties.Resources.Cek_Bankaya16x16;
            this.btnkapat.Location = new System.Drawing.Point(319, 95);
            this.btnkapat.Name = "btnkapat";
            this.btnkapat.Size = new System.Drawing.Size(86, 32);
            this.btnkapat.TabIndex = 15;
            this.btnkapat.Text = "KAPAT";
            this.btnkapat.Click += new System.EventHandler(this.btnkapat_Click);
            // 
            // rbtnpasif
            // 
            this.rbtnpasif.AutoSize = true;
            this.rbtnpasif.Location = new System.Drawing.Point(319, 177);
            this.rbtnpasif.Name = "rbtnpasif";
            this.rbtnpasif.Size = new System.Drawing.Size(54, 17);
            this.rbtnpasif.TabIndex = 16;
            this.rbtnpasif.TabStop = true;
            this.rbtnpasif.Text = "PASİF";
            this.rbtnpasif.UseVisualStyleBackColor = true;
            // 
            // frmKullaniciPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 339);
            this.Controls.Add(this.rbtnpasif);
            this.Controls.Add(this.btnkapat);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.txtsoyisim);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.txtisim);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.txtsifret);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.txtsifre);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.rbtnaktif);
            this.Controls.Add(this.btnkaydet);
            this.Controls.Add(this.txtkullaniciadi);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.txtkullanıcıtürü);
            this.IconOptions.Image = global::otomasyon_proje_uygulması.Properties.Resources.Banka_Kartı16x16;
            this.Name = "frmKullaniciPanel";
            this.Text = "KULLANICI PANEL";
            this.Load += new System.EventHandler(this.frmKullaniciPanel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtkullaniciadi.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtisim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsifret.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsoyisim.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtkullanıcıtürü.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtkullaniciadi;
        private DevExpress.XtraEditors.SimpleButton btnkaydet;
        private System.Windows.Forms.RadioButton rbtnaktif;
        private DevExpress.XtraEditors.TextEdit txtsifre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtisim;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtsifret;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtsoyisim;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.ComboBoxEdit txtkullanıcıtürü;
        private DevExpress.XtraEditors.SimpleButton btntemizle;
        private DevExpress.XtraEditors.SimpleButton btnkapat;
        private System.Windows.Forms.RadioButton rbtnpasif;
    }
}