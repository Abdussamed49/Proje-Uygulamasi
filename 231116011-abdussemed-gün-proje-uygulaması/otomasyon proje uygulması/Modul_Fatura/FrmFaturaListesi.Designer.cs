namespace otomasyon_proje_uygulması.Modul_Fatura
{
    partial class FrmFaturaListesi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFaturaListesi));
            this.STOKBARKOD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.STOKKKODU = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.STOKADI = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Liste = new DevExpress.XtraGrid.GridControl();
            this.BTNSİL = new DevExpress.XtraEditors.SimpleButton();
            this.BTNARA = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TXTSTOKADİ = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.TXTSTOKKODU = new DevExpress.XtraEditors.ComboBoxEdit();
            this.TXTBARKOD = new DevExpress.XtraEditors.DateEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTSTOKADİ.Properties)).BeginInit();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).BeginInit();
            this.splitContainerControl1.Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).BeginInit();
            this.splitContainerControl1.Panel2.SuspendLayout();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TXTSTOKKODU.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTBARKOD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTBARKOD.Properties.CalendarTimeProperties)).BeginInit();
            this.SuspendLayout();
            // 
            // STOKBARKOD
            // 
            this.STOKBARKOD.Caption = "BARKOD";
            this.STOKBARKOD.FieldName = "STOKBARKOD";
            this.STOKBARKOD.Name = "STOKBARKOD";
            this.STOKBARKOD.OptionsColumn.AllowEdit = false;
            this.STOKBARKOD.OptionsColumn.AllowFocus = false;
            this.STOKBARKOD.OptionsColumn.FixedWidth = true;
            this.STOKBARKOD.Visible = true;
            this.STOKBARKOD.VisibleIndex = 2;
            // 
            // STOKKKODU
            // 
            this.STOKKKODU.Caption = "STOK KODU";
            this.STOKKKODU.FieldName = "STOKKODU";
            this.STOKKKODU.Name = "STOKKKODU";
            this.STOKKKODU.OptionsColumn.AllowEdit = false;
            this.STOKKKODU.OptionsColumn.AllowFocus = false;
            this.STOKKKODU.OptionsColumn.FixedWidth = true;
            this.STOKKKODU.Visible = true;
            this.STOKKKODU.VisibleIndex = 0;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 291;
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.STOKKKODU,
            this.STOKADI,
            this.STOKBARKOD});
            this.gridView1.GridControl = this.Liste;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // STOKADI
            // 
            this.STOKADI.Caption = "STOK ADI";
            this.STOKADI.FieldName = "STOKSTOKADI";
            this.STOKADI.Name = "STOKADI";
            this.STOKADI.OptionsColumn.AllowEdit = false;
            this.STOKADI.OptionsColumn.AllowFocus = false;
            this.STOKADI.OptionsColumn.FixedWidth = true;
            this.STOKADI.Visible = true;
            this.STOKADI.VisibleIndex = 1;
            // 
            // Liste
            // 
            this.Liste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Liste.Location = new System.Drawing.Point(0, 0);
            this.Liste.MainView = this.gridView1;
            this.Liste.Name = "Liste";
            this.Liste.Size = new System.Drawing.Size(449, 614);
            this.Liste.TabIndex = 0;
            this.Liste.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // BTNSİL
            // 
            this.BTNSİL.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNSİL.ImageOptions.Image")));
            this.BTNSİL.Location = new System.Drawing.Point(89, 197);
            this.BTNSİL.Name = "BTNSİL";
            this.BTNSİL.Size = new System.Drawing.Size(80, 39);
            this.BTNSİL.TabIndex = 7;
            this.BTNSİL.Text = "TEMİZLE";
            // 
            // BTNARA
            // 
            this.BTNARA.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BTNARA.ImageOptions.Image")));
            this.BTNARA.Location = new System.Drawing.Point(3, 197);
            this.BTNARA.Name = "BTNARA";
            this.BTNARA.Size = new System.Drawing.Size(80, 41);
            this.BTNARA.TabIndex = 6;
            this.BTNARA.Text = "ARA";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(3, 152);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(34, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "TARİH ";
            // 
            // TXTSTOKADİ
            // 
            this.TXTSTOKADİ.Location = new System.Drawing.Point(3, 104);
            this.TXTSTOKADİ.Name = "TXTSTOKADİ";
            this.TXTSTOKADİ.Size = new System.Drawing.Size(166, 20);
            this.TXTSTOKADİ.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(3, 85);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(58, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "FATURA NO";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(3, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "FATURA TÜRÜ";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.BTNSİL);
            this.xtraTabPage1.Controls.Add(this.BTNARA);
            this.xtraTabPage1.Controls.Add(this.labelControl3);
            this.xtraTabPage1.Controls.Add(this.TXTSTOKADİ);
            this.xtraTabPage1.Controls.Add(this.labelControl2);
            this.xtraTabPage1.Controls.Add(this.labelControl1);
            this.xtraTabPage1.Controls.Add(this.TXTSTOKKODU);
            this.xtraTabPage1.Controls.Add(this.TXTBARKOD);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(193, 589);
            this.xtraTabPage1.Text = "ARAMA";
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(195, 614);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1});
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            // 
            // splitContainerControl1.Panel1
            // 
            this.splitContainerControl1.Panel1.Controls.Add(this.xtraTabControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            // 
            // splitContainerControl1.Panel2
            // 
            this.splitContainerControl1.Panel2.Controls.Add(this.Liste);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(654, 614);
            this.splitContainerControl1.SplitterPosition = 195;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // TXTSTOKKODU
            // 
            this.TXTSTOKKODU.EditValue = "SATIŞ FATURASI";
            this.TXTSTOKKODU.Location = new System.Drawing.Point(3, 31);
            this.TXTSTOKKODU.Name = "TXTSTOKKODU";
            this.TXTSTOKKODU.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TXTSTOKKODU.Properties.Items.AddRange(new object[] {
            "SATIŞ FATURASI",
            "SATIŞ İADE FATURASI",
            "ALIŞ FATURASI",
            "ALIŞ İADE FATURASI"});
            this.TXTSTOKKODU.Size = new System.Drawing.Size(166, 20);
            this.TXTSTOKKODU.TabIndex = 1;
            // 
            // TXTBARKOD
            // 
            this.TXTBARKOD.EditValue = null;
            this.TXTBARKOD.Location = new System.Drawing.Point(3, 171);
            this.TXTBARKOD.Name = "TXTBARKOD";
            this.TXTBARKOD.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TXTBARKOD.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TXTBARKOD.Properties.DisplayFormat.FormatString = "";
            this.TXTBARKOD.Properties.EditFormat.FormatString = "";
            this.TXTBARKOD.Properties.Mask.EditMask = "";
            this.TXTBARKOD.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.None;
            this.TXTBARKOD.Size = new System.Drawing.Size(166, 20);
            this.TXTBARKOD.TabIndex = 5;
            // 
            // FrmFaturaListesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 614);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "FrmFaturaListesi";
            this.Text = "FATURA LİSTESİ";
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Liste)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTSTOKADİ.Properties)).EndInit();
            this.xtraTabPage1.ResumeLayout(false);
            this.xtraTabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel1)).EndInit();
            this.splitContainerControl1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1.Panel2)).EndInit();
            this.splitContainerControl1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TXTSTOKKODU.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTBARKOD.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TXTBARKOD.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn STOKBARKOD;
        private DevExpress.XtraGrid.Columns.GridColumn STOKKKODU;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn STOKADI;
        private DevExpress.XtraGrid.GridControl Liste;
        private DevExpress.XtraEditors.SimpleButton BTNSİL;
        private DevExpress.XtraEditors.SimpleButton BTNARA;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TXTSTOKADİ;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.ComboBoxEdit TXTSTOKKODU;
        private DevExpress.XtraEditors.DateEdit TXTBARKOD;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
    }
}