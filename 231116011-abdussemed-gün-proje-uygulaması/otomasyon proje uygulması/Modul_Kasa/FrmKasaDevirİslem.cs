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
    public partial class FrmKasaDevirİslem : DevExpress.XtraEditors.XtraForm
    {
        fonksiyonlar.DATABASEDataContext DB =new fonksiyonlar.DATABASEDataContext();
        fonksiyonlar.Mesajlar Mesajlar = new fonksiyonlar.Mesajlar();
        fonksiyonlar.FORMLAR Formlar = new fonksiyonlar.FORMLAR();


        bool Edit = false;
        int kasaID = -1;
        int IslemID = -1;


        public FrmKasaDevirİslem()
        {
            InitializeComponent();
        }

        private void FrmKasaDevirİslem_Load(object sender, EventArgs e)
        {
            txtTarih.Text = DateTime.Now.ToShortDateString();
        }
        
        void Temizle()
        {
            
            txtTarih.Text = DateTime.Now.ToShortDateString();
            txtAciklama.Text = "";
            txtBelgeNo.Text = "";
            txtKasaAdi.Text = "";
            txtKasaKodu.Text = "";
            txtTutar.Text = "0";
            Edit=false;
            kasaID = -1;
            IslemID = -1;
            ANAFORM.Aktarma = -1;
                

        }

        void YeniKadyet()
        {
            try
            {
                fonksiyonlar.TBL_KASAHAREKETLERİ Hareket = new fonksiyonlar.TBL_KASAHAREKETLERİ();
                Hareket.ACIKLAMA = txtAciklama.Text;
                Hareket.BELGENO =txtBelgeNo.Text;
                Hareket.EVRAKTURU = "KASA DEVİR KARTI";
                if (rbtnCikis.Checked) Hareket.GCKODU = "C";
                if (rbtnGiris.Checked) Hareket.GCKODU = "G";
                Hareket.KASAID = kasaID;
                Hareket.TARIH = DateTime.Parse(txtTarih.Text);
                Hareket.TUTAR =decimal.Parse(txtTutar.Text);    
                Hareket.SAVEDATE =DateTime.Now;
                Hareket.SAVEUSER = ANAFORM.UserId;
                DB.TBL_KASAHAREKETLERİs.InsertOnSubmit(Hareket);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("DEVİR KARTI HAREKET KAYDI İŞLENMİŞTİR");
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
                fonksiyonlar.TBL_KASAHAREKETLERİ Hareket = DB.TBL_KASAHAREKETLERİs.First(s=>s.ID ==IslemID);    
                Hareket.ACIKLAMA = txtAciklama.Text;
                Hareket.BELGENO = txtBelgeNo.Text;
                Hareket.EVRAKTURU = "KASA DEVİR KARTI";
                if (rbtnCikis.Checked) Hareket.GCKODU = "C";
                if (rbtnGiris.Checked) Hareket.GCKODU = "G";
                Hareket.KASAID = kasaID;
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
                DB.TBL_KASAHAREKETLERİs.DeleteOnSubmit(DB.TBL_KASAHAREKETLERİs.First(s => s.ID == IslemID));
                DB.SubmitChanges();
                Temizle();

            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        public void Ac(int ID)
        {
            try
            {
                IslemID = ID;
                Edit = true;
                fonksiyonlar.TBL_KASAHAREKETLERİ Hareket = DB.TBL_KASAHAREKETLERİs.First(s=> s.ID == IslemID);
                txtAciklama.Text = Hareket.ACIKLAMA;
                txtBelgeNo.Text = Hareket.BELGENO;
                KasaAc(Hareket.KASAID.Value);
                txtTarih.Text = Hareket.TARIH.Value.ToShortDateString();
                txtTutar.Text=Hareket.TUTAR.Value.ToString();
                if(Hareket.GCKODU == "G")rbtnGiris.Checked = true;  
                if(Hareket.GCKODU=="C")rbtnCikis.Checked = true;    

            }
            catch (Exception e)
            {

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

                throw;
            }
        }

        private void BTNKAYDET_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKadyet();
        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            if (Edit && IslemID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void BTNKAPAT_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void txtBelgeNo_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {

        }
    }
}