using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon_proje_uygulması.Modul_Cek
{
    public partial class frmMusteriCeki : DevExpress.XtraEditors.XtraForm
    {
        fonksiyonlar.DATABASEDataContext DB = new fonksiyonlar.DATABASEDataContext();
        fonksiyonlar.Mesajlar Mesajlar = new fonksiyonlar.Mesajlar();

        int CariID = -1;

        public frmMusteriCeki()
        {
            InitializeComponent();
        }

        void Temizle()
        {
            txtAciklama.Text = "";
            txtAsilBorclu.Text = "";
            txtBanka.Text = "";
            txtBelgeNo.Text = "";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtCekNo.Text = "";
            txtCekTürü.SelectedIndex = 0;
            txtHesapNo.Text = "";
            txtSube.Text = "";
            txtTutar.Text = "";
            txtVadeTarihi.Text = DateTime.Now.ToString();
            CariID = -1;
            ANAFORM.Aktarma = -1;


        }

        private void frmMusteriCeki_Load(object sender, EventArgs e)
        {
            txtVadeTarihi.Text=DateTime.Now.ToShortDateString();     

        }

        void YeniCekKaydet()
        {
            fonksiyonlar.TBL_CARILER Cek = new fonksiyonlar.TBL_CARILER();
            Cek.ADRES = txtCariAdi.Text;
              
        }
    }
}