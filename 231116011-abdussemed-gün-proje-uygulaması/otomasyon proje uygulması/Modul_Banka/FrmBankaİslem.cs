using DevExpress.XtraEditors.Registrator;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon_proje_uygulması.Modul_Banka
{
    public partial class FrmBankaİslem : Form
    {

        fonksiyonlar.DATABASEDataContext DB = new fonksiyonlar.DATABASEDataContext();
        fonksiyonlar.Mesajlar Mesajlar = new fonksiyonlar.Mesajlar();
        fonksiyonlar.FORMLAR Formlar = new fonksiyonlar.FORMLAR();
        bool Edit = false;
        int IslemID = -1;
        int BankaID = -1;

        public FrmBankaİslem()
        {
            InitializeComponent();
        }

        private void FrmBankaİslem_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToString();
        }

        public void Ac(int ID)
        {
            try
            {
                Edit = true;
                IslemID = ID;
                fonksiyonlar.TBL_BANKAHAREKETLERI Hareket = DB.TBL_BANKAHAREKETLERIs.First(s=>s.ID == IslemID);
                BankaAc(Hareket.BANKAID.Value);
                txtAciklama.Text = Hareket.ACIKLAMA;
                txtBelgeNo.Text = Hareket.BELGENO;
                txtTarih.Text =Hareket.TARIH.Value.ToShortDateString();
                txtTutar.Text = Hareket.TUTAR.ToString();
                if (Hareket.GCKODU == "G") rbtnGiris.Checked = true;
                if (Hareket.GCKODU == "C") rbtnCikis.Checked = true;

            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void BankaAc(int ID)
        {
            try
            {
                BankaID = ID;
                txtHesapAdı.Text = DB.TBL_BANKALARs.First(s => s.ID == BankaID).HESAPADI;
                txtHesapNo.Text = DB.TBL_BANKALARs.First(s => s.ID == BankaID).HESAPNO;
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
                
            }
        }

        void Temizle()
        {
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtHesapAdı.Text = "";
            txtHesapNo.Text = "";
            txtTarih.Text=DateTime.Now.ToString();
            txtTutar.Text = "0";
            Edit = false;
            IslemID = -1;
            BankaID = -1;
            ANAFORM.Aktarma = -1;


        }

        void YeniKayıt()
        {
            try
            {
                fonksiyonlar.TBL_BANKAHAREKETLERI Hareket = new fonksiyonlar.TBL_BANKAHAREKETLERI();
                Hareket.ACIKLAMA = txtAciklama.Text;
                Hareket.BANKAID = BankaID;
                Hareket.BELGENO = txtBelgeNo.Text;
                Hareket.EVRAKTURU = "banka işlem ";
                if (rbtnGiris.Checked) Hareket.GCKODU = "G";
                if (rbtnCikis.Checked) Hareket.GCKODU = "C";
                Hareket.TARIH = DateTime.Parse(txtTarih.Text);  
                Hareket.TUTAR =decimal.Parse(txtTutar.Text);
                Hareket.SAVEDATE = DateTime.Now;
                Hareket.SAVEUSER = ANAFORM.UserId;
                DB.TBL_BANKAHAREKETLERIs.InsertOnSubmit(Hareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("BANKA İŞLEMİ KAYDI YAPILMIŞITR");
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void Guncelle()
        {
            try
            {
                fonksiyonlar.TBL_BANKAHAREKETLERI Hareket = DB.TBL_BANKAHAREKETLERIs.First(s=>s.ID==IslemID);
                Hareket.BANKAID = BankaID;
                Hareket.BELGENO = txtBelgeNo.Text;
                Hareket.EVRAKTURU = "banka işlme ";
                if (rbtnGiris.Checked) Hareket.GCKODU = "G";
                if (rbtnCikis.Checked) Hareket.GCKODU = "C";
                Hareket.TARIH = DateTime.Parse(txtTarih.Text);
                Hareket.TUTAR = decimal.Parse(txtTutar.Text);
                Hareket.EDITDATE = DateTime.Now;
                Hareket.EDITUSER = ANAFORM.UserId;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void Sil()
        {
            try
            {
                DB.TBL_BANKAHAREKETLERIs.DeleteOnSubmit(DB.TBL_BANKAHAREKETLERIs.First(s=>s.ID==IslemID));
                DB.SubmitChanges();
                Temizle();

            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        private void txtHesapAdı_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id =Formlar.BankaListesii(true);    
            if(Id>0) BankaAc(Id);
            ANAFORM.Aktarma = -1;

        }

        private void BTNKAYDET_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKayıt();
        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void BTNKAPAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
