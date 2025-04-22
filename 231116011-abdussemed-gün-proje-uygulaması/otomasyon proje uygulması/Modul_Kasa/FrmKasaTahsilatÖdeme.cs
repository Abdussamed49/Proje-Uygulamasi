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

namespace otomasyon_proje_uygulması.Modul_Kasa
{
    
    public partial class FrmKasaTahsilatÖdeme : DevExpress.XtraEditors.XtraForm
    {
        fonksiyonlar.DATABASEDataContext DB = new fonksiyonlar.DATABASEDataContext();   
        fonksiyonlar.Mesajlar Mesajlar = new fonksiyonlar.Mesajlar();
        fonksiyonlar.FORMLAR Formlar =new fonksiyonlar.FORMLAR();   

        bool Edit = false;
        int IslemID = -1;
        int CariHareketID = -1;
        int kasaID = -1;
        int CariID = -1;


        public FrmKasaTahsilatÖdeme()
        {
            InitializeComponent();
        }

        private void FrmKasaTahsilatÖdeme_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }

        private void txtIslemTuru_SelectedIndexChanged(object sender, EventArgs e)
        {
           

            
        }


        void Temizle()
        {
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtCariAdi.Text = "";
            txtCariKodu.Text = "";
            txtIslemTuru.SelectedIndex = 0;
            txtKasaAdi.Text = "";
            txtKasaKodu.Text = "";
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtTutar.Text = "0";
           Edit = false;    
            IslemID = -1;
            kasaID = -1;    
            CariID = -1;    
            CariHareketID = -1;
            ANAFORM.Aktarma = -1;
        }

        public void Ac(int HareketID)
        {
            try
            {
                Edit = true;    
                IslemID=HareketID;
                fonksiyonlar.TBL_KASAHAREKETLERİ  kasaHareketi = DB.TBL_KASAHAREKETLERİs.First(s=>s.ID==IslemID);   
                CariHareketID=DB.TBL_CARIHAREKETLERIs.First(s=>s.EVRAKTURU ==kasaHareketi.EVRAKTURU && s.EVRAKID ==IslemID).ID;
                MessageBox.Show("CARİ HAREKET ID:" + CariHareketID.ToString());
                txtAciklama.Text = kasaHareketi.ACIKLAMA;
                txtBelgeNo.Text = kasaHareketi.BELGENO;
                if (kasaHareketi.EVRAKTURU == "KASA TAHSİLAT ") txtIslemTuru.SelectedIndex = 0;
                if (kasaHareketi.EVRAKTURU == "KASA ÖDEME") txtIslemTuru.SelectedIndex = 1;
                txtTarih.Text = kasaHareketi.TARIH.Value.ToShortDateString();
                txtTutar.Text = kasaHareketi.TUTAR.Value.ToString();
                KasaAc(kasaHareketi.KASAID.Value);
                CariAc(kasaHareketi.CARIID.Value);

            }
            catch (Exception e)
            {

                Temizle();
                Mesajlar.Hata(e);
            }
        }

        void KasaAc(int ID)
        {
            try
            {
                kasaID = ID;
                txtKasaAdi.Text = DB.TBL_KASALARs.First(s => s.ID == kasaID).KASAADI;
                txtKasaKodu.Text = DB.TBL_KASALARs.First(s => s.ID == kasaID).KASAKODU;
            }
            catch (Exception)
            {

                kasaID = -1;

            }
        }
        void CariAc(int ID)
        {
            try
            {
                CariID = ID;
                txtCariAdi.Text = DB.TBL_CARILERs.First(s => s.ID == kasaID).CARIADI;
                txtCariKodu.Text = DB.TBL_CARILERs.First(s => s.ID == kasaID).CARIKODU;
            }
            catch (Exception)
            {

                CariID= -1; 
            }
        }

        void YeniKaydet()
        {
            try
            {
                fonksiyonlar.TBL_KASAHAREKETLERİ KasaHareketi = new fonksiyonlar.TBL_KASAHAREKETLERİ();
                KasaHareketi.ACIKLAMA = txtAciklama.Text;
                KasaHareketi.BELGENO =txtBelgeNo.Text;
                KasaHareketi.CARIID = CariID;
                KasaHareketi.EVRAKTURU = txtIslemTuru.SelectedItem.ToString();
                if (txtIslemTuru.SelectedIndex ==0) KasaHareketi.GCKODU = "G";
                if (txtIslemTuru.SelectedIndex == 1) KasaHareketi.GCKODU = "C";
                KasaHareketi.KASAID = kasaID;
                KasaHareketi.SAVEDATE =DateTime.Now;
                KasaHareketi.SAVEUSER = ANAFORM.UserId;
                KasaHareketi.TARIH = DateTime.Parse(txtTarih.Text); 
                KasaHareketi.TUTAR =decimal.Parse(txtTutar.Text);       
                DB.TBL_KASAHAREKETLERİs.InsertOnSubmit(KasaHareketi);
                DB.SubmitChanges();
                Mesajlar.YeniKayit(txtIslemTuru.SelectedItem + "YENİ KASA HAREKETİ İŞLENMİŞTİR.");
                fonksiyonlar.TBL_CARIHAREKETLERI CariHareket = new fonksiyonlar.TBL_CARIHAREKETLERI();
                CariHareket.ACIKLAMA = txtBelgeNo.Text + " belge numaralı" + txtIslemTuru.SelectedItem.ToString() + "işlemi";
                if (txtIslemTuru.SelectedIndex == 0) CariHareket.ALACAK = decimal.Parse(txtTutar.Text);
                if (txtIslemTuru.SelectedIndex == 1) CariHareket.BORC = decimal.Parse(txtTutar.Text);
                CariHareket.CARIID = CariID;
                CariHareket.EVRAKID = KasaHareketi.ID;
                CariHareket.EVRAKTURU = txtIslemTuru.SelectedItem.ToString();
                CariHareket.TARIH = DateTime.Parse(txtTarih.Text);
                if (txtIslemTuru.SelectedIndex == 0) CariHareket.TIPI = "KT";
                if (txtIslemTuru.SelectedIndex == 1) CariHareket.TIPI = "KÖ";
                CariHareket.SAVEDATE = DateTime.Now;
                CariHareket.SAVEUSER = ANAFORM.UserId;
                DB.TBL_CARIHAREKETLERIs.InsertOnSubmit(CariHareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayit(txtIslemTuru.SelectedItem + "YENİ CARİ HAREKETİ OLARAK İŞLENMİŞTİR.");
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
                fonksiyonlar.TBL_KASAHAREKETLERİ KasaHareketi = DB.TBL_KASAHAREKETLERİs.First(s => s.ID == IslemID);               
                KasaHareketi.ACIKLAMA = txtAciklama.Text;
                KasaHareketi.BELGENO = txtBelgeNo.Text;
                KasaHareketi.CARIID = CariID;
                KasaHareketi.EVRAKTURU = txtIslemTuru.SelectedItem.ToString();
                if (txtIslemTuru.SelectedIndex == 0) KasaHareketi.GCKODU = "G";
                if (txtIslemTuru.SelectedIndex == 1) KasaHareketi.GCKODU = "C";
                KasaHareketi.KASAID = kasaID;
                KasaHareketi.EDITDATE = DateTime.Now;
                KasaHareketi.EDITUSER = ANAFORM.UserId;
                KasaHareketi.TARIH = DateTime.Parse(txtTarih.Text);
                KasaHareketi.TUTAR = decimal.Parse(txtTutar.Text);
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                fonksiyonlar.TBL_CARIHAREKETLERI CariHareket = DB.TBL_CARIHAREKETLERIs.First(s =>s.ID==CariHareketID );
                CariHareket.ACIKLAMA = txtBelgeNo.Text + " belge numaralı" + txtIslemTuru.SelectedItem.ToString() + "işlemi";
                if (txtIslemTuru.SelectedIndex == 0) CariHareket.ALACAK = decimal.Parse(txtTutar.Text);
                if (txtIslemTuru.SelectedIndex == 1) CariHareket.BORC = decimal.Parse(txtTutar.Text);
                CariHareket.CARIID = CariID;
                CariHareket.EVRAKID = KasaHareketi.ID;
                CariHareket.EVRAKTURU = txtIslemTuru.SelectedItem.ToString();
                CariHareket.TARIH = DateTime.Parse(txtTarih.Text);
                if (txtIslemTuru.SelectedIndex == 0) CariHareket.TIPI = "KT";
                if (txtIslemTuru.SelectedIndex == 1) CariHareket.TIPI = "KÖ";
                CariHareket.EDITDATE = DateTime.Now;
                CariHareket.EDITUSER = ANAFORM.UserId;
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
                DB.TBL_KASAHAREKETLERİs.DeleteOnSubmit(DB.TBL_KASAHAREKETLERİs.First(s => s.ID == IslemID));
                DB.TBL_CARIHAREKETLERIs.DeleteOnSubmit(DB.TBL_CARIHAREKETLERIs.First(s => s.ID == CariHareketID));
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        private void txtKasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.KasaListesi(true);
            if (Id > 0)
            {
                KasaAc(Id);
                ANAFORM.Aktarma = -1;

            }
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id =Formlar.CariListesi(true);  
            if(Id > 0)
            {
                CariAc(Id);
                ANAFORM.Aktarma = -1;
            }
        }

        private void BTNKAYDET_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && CariHareketID > 00 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && CariHareketID>00 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void BTNKAPAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}