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
    public partial class FrmParaTranser : Form
    {
        fonksiyonlar.DATABASEDataContext DB = new fonksiyonlar.DATABASEDataContext();
        fonksiyonlar.Mesajlar Mesajlar = new fonksiyonlar.Mesajlar();
        fonksiyonlar.FORMLAR Formlar = new fonksiyonlar.FORMLAR();


        bool Edit = false;
        int BankaID = -1;
        int CariID = -1;
        int IslemID = -1;

        public FrmParaTranser()
        {
            InitializeComponent();
        }



        private void FrmBankaListesi_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }
        
        

        private void FrmParaTranser_Load(object sender, EventArgs e)
        {

        }

        private void txtTransferTürü_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (txtTransferTürü.SelectedIndex==0)
            {
                rbtnGelen.Text = "GELEN HAVALE";
                rbtnGiden.Text = " GİDEN HAVALE";
               
            }
            else if (txtTransferTürü.SelectedIndex==1)
            {
                rbtnGelen.Text = "GELEN EFT";
                rbtnGiden.Text = " GİDEN EFT";
               
            }
        }

        void Temizle()
        {
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtHesapAdı.Text = "";
            txtHesapNo.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "0";
            Edit =false;
            BankaID = -1;
            CariID = -1;    
            IslemID = -1;
            ANAFORM.Aktarma = -1;



        }

        public void Ac(int ID)
        {
            try
            {
                Edit = true;
                IslemID = ID;
                fonksiyonlar.TBL_BANKAHAREKETLERI Banka =DB.TBL_BANKAHAREKETLERIs.First(s=>s.ID ==IslemID);
                BankaAc(Banka.BANKAID.Value);
                CariAc(Banka.CARIID.Value);
                txtAciklama.Text = Banka.ACIKLAMA;
                txtBelgeNo.Text = Banka.BELGENO;
                txtTarih.Text = Banka.TARIH.Value.ToShortDateString();
                txtTransferTürü.Text = Banka.EVRAKTURU;
                txtTutar.Text = Banka.TUTAR.ToString();
                if(Banka.GCKODU =="G") rbtnGelen.Checked = true;    
                if(Banka.GCKODU =="C") rbtnGelen.Checked=true;
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

        void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                txtCariKodu.Text = DB.TBL_CARILERs.First(s => s.ID == CariID).CARIKODU;
                txtCariAdi.Text = DB.TBL_CARILERs.First(s => s.ID == CariID).CARIADI;
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void YeniKaydet()
        {
            try
            {
                fonksiyonlar.TBL_BANKAHAREKETLERI Banka = new fonksiyonlar.TBL_BANKAHAREKETLERI();
                Banka.ACIKLAMA =txtAciklama.Text;
                Banka.BANKAID = BankaID;
                Banka.BELGENO = txtBelgeNo.Text;
                Banka.CARIID = CariID;
                Banka.EVRAKTURU =txtTransferTürü.SelectedItem.ToString();
                if (rbtnGelen.Checked) Banka.GCKODU = "G";
                if (rbtnGiden.Checked) Banka.GCKODU = "C";
                Banka.TARIH = DateTime.Parse(txtTarih.Text);
                Banka.TUTAR = decimal.Parse(txtTutar.Text);
                Banka.SAVEDATE = DateTime.Now;
                Banka.SAVEUSER = ANAFORM.UserId;
                DB.TBL_BANKAHAREKETLERIs.InsertOnSubmit(Banka);
                DB.SubmitChanges(); 
                fonksiyonlar.TBL_CARIHAREKETLERI Cari = new fonksiyonlar.TBL_CARIHAREKETLERI();
                Cari.ACIKLAMA = txtAciklama.Text;
                if (rbtnGelen.Checked) Cari.ALACAK = decimal.Parse(txtTutar.Text);
                if(rbtnGiden.Checked) Cari.BORC = decimal.Parse(txtTutar.Text);
                Cari.CARIID = CariID;
                Cari.EVRAKID = Banka.ID;
                Cari.EVRAKTURU =txtTransferTürü.SelectedItem.ToString();
                Cari.TARIH = DateTime.Parse(txtTarih.Text);
                if (txtTransferTürü.SelectedIndex == 0) Cari.TIPI = "BH";
                if (txtTransferTürü.SelectedIndex == 1) Cari.TIPI = "EFT";
                Cari.SAVEDATE = DateTime.Now;
                Cari.SAVEUSER = ANAFORM.UserId;
                DB.TBL_CARIHAREKETLERIs.InsertOnSubmit(Cari);   
                DB.SubmitChanges();
                Mesajlar.YeniKayit("PARA TRANSFER KAYDI İŞLENDİ");
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
                fonksiyonlar.TBL_BANKAHAREKETLERI Banka = DB.TBL_BANKAHAREKETLERIs.First(s=> s.ID ==IslemID);
                Banka.ACIKLAMA = txtAciklama.Text;
                Banka.BANKAID = BankaID;
                Banka.BELGENO = txtBelgeNo.Text;
                Banka.CARIID = CariID;
                Banka.EVRAKTURU = txtTransferTürü.SelectedItem.ToString();
                if (rbtnGelen.Checked) Banka.GCKODU = "G";
                if (rbtnGiden.Checked) Banka.GCKODU = "C";
                Banka.TARIH = DateTime.Parse(txtTarih.Text);
                Banka.TUTAR = decimal.Parse(txtTutar.Text);
                Banka.EDITDATE = DateTime.Now;
                Banka.EDITUSER = ANAFORM.UserId;
                DB.SubmitChanges();
                fonksiyonlar.TBL_CARIHAREKETLERI Cari = DB.TBL_CARIHAREKETLERIs.First(s => s.EVRAKTURU == txtTransferTürü.SelectedItem.ToString() && s.EVRAKID == IslemID);
                Cari.ACIKLAMA = txtAciklama.Text;
                if (rbtnGelen.Checked) Cari.ALACAK = decimal.Parse(txtTutar.Text);
                if (rbtnGiden.Checked) Cari.BORC = decimal.Parse(txtTutar.Text);
                Cari.CARIID = CariID;
                Cari.EVRAKID = Banka.ID;
                Cari.EVRAKTURU = txtTransferTürü.SelectedItem.ToString();
                Cari.TARIH = DateTime.Parse(txtTarih.Text);
                if (txtTransferTürü.SelectedIndex == 0) Cari.TIPI = "BH";
                if (txtTransferTürü.SelectedIndex == 1) Cari.TIPI = "EFT";
                Cari.EDITDATE = DateTime.Now;
                Cari.EDITUSER = ANAFORM.UserId;
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
                DB.TBL_CARIHAREKETLERIs.DeleteOnSubmit(DB.TBL_CARIHAREKETLERIs.First(s=> s.EVRAKTURU ==txtTransferTürü.SelectedItem.ToString()));
                DB.SubmitChanges();
                DB.TBL_BANKAHAREKETLERIs.DeleteOnSubmit(DB.TBL_BANKAHAREKETLERIs.First(s => s.ID == IslemID));
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
            int Id= Formlar.BankaListesii(true);    
            if(Id>0) BankaAc(Id);
            ANAFORM.Aktarma = -1;
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.CariListesi(true);
            if (Id > 0) CariAc(Id);
            ANAFORM.Aktarma = -1;
        }

        private void BTNKAYDET_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && BankaID > 0 && IslemID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();  
        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && BankaID > 0 && IslemID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void BTNKAPAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
