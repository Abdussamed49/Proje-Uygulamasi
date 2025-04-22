using DevExpress.Utils.Menu;
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
using System.Xml.Serialization;

namespace otomasyon_proje_uygulması.Modul_Cari
{
    public partial class FrmAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
            fonksiyonlar.DATABASEDataContext DB = new fonksiyonlar.DATABASEDataContext();
        fonksiyonlar.Mesajlar mesajlar = new fonksiyonlar.Mesajlar();
        fonksiyonlar.FORMLAR FORMLAR = new fonksiyonlar.FORMLAR();
        fonksiyonlar.Numara Numaralar = new fonksiyonlar.Numara();

        bool Edit = false;
        int CariID = -1;
        int GrupID = -1;

        public FrmAcilisKarti()
        {
            InitializeComponent();
        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FrmAcilisKarti_Load(object sender, EventArgs e)
        {
            txtCariKodu.Text = Numaralar.CariKodNumarasi();

        }

        void Temizle()
        {
            foreach (Control CT in groupControl1.Controls)
                if (CT is DevExpress.XtraEditors.TextEdit ||CT is DevExpress.XtraEditors.ButtonEdit) CT.Text = "";


            foreach (Control CE in groupControl2.Controls)
                if (CE is DevExpress.XtraEditors.TextEdit || CE is DevExpress.XtraEditors.ButtonEdit || CE is DevExpress.XtraEditors.MemoEdit) CE.Text = "";

            txtCariKodu.Text =Numaralar.CariKodNumarasi();
            Edit = false;
            CariID = -1;
            GrupID = -1;
            ANAFORM.Aktarma = -1;
        }

        void YeniKaydet()
        {
            try
            {
                fonksiyonlar.TBL_CARILER Cari = new fonksiyonlar.TBL_CARILER();
                Cari.ADRES = txtAdres.Text;
                Cari.CARIADI = txtCariAdi.Text;
                Cari.CARIKODU = txtCariKodu.Text;
                Cari.FAX1 = txtFax1.Text;
                Cari.FAX2 = txtFax2.Text;
                Cari.GRUPID = GrupID;
                Cari.ILCE = txtİlce.Text;
                Cari.MAILINFO = txtMailInfo.Text;
                Cari.SEHIR = txtSehir.Text;
                Cari.TELEFON1 = txtTelefon1.Text;
                Cari.TELEFON2 = txtTelefon2.Text;
                Cari.ILCE = txtİlce.Text;
                Cari.VERGİDAIRESI = txtVergiDairesi.Text;
                Cari.VERGINO = txtVergiNo.Text;
                Cari.WEBADRES = txtWebAdres.Text;
                Cari.YETKILI1 = txtYetkili1.Text;
                Cari.YETKILI2 = txtYetkili2.Text;
                Cari.YETKILIEMAIL1 = txtYetkiliEmail1.Text;
                Cari.YETKILIEMAIL2 = txtYetkiliEmail2.Text;
                Cari.SAVEDATE = DateTime.Now;
                Cari.SAVEUSER = ANAFORM.UserId;
                DB.TBL_CARILERs.InsertOnSubmit(Cari);
                DB.SubmitChanges();
                mesajlar.YeniKayit("yeni cari kaydı oluşturulmuştur");
                Temizle();
            }
            catch (Exception e)
            {

                mesajlar.Hata(e);
            }
        }

        void Guncelle()
        {
            try
            {
                fonksiyonlar.TBL_CARILER Cari = DB.TBL_CARILERs.First(s=> s.ID ==CariID);
                Cari.ADRES = txtAdres.Text;
                Cari.CARIADI = txtCariAdi.Text;
                Cari.CARIKODU = txtCariKodu.Text;
                Cari.FAX1 = txtFax1.Text;
                Cari.FAX2 = txtFax2.Text;
                Cari.GRUPID = GrupID;
                Cari.ILCE = txtİlce.Text;
                Cari.MAILINFO = txtMailInfo.Text;
                Cari.SEHIR = txtSehir.Text;
                Cari.TELEFON1 = txtTelefon1.Text;
                Cari.TELEFON2 = txtTelefon2.Text;
                Cari.ILCE = txtİlce.Text;
                Cari.VERGİDAIRESI = txtVergiDairesi.Text;
                Cari.VERGINO = txtVergiNo.Text;
                Cari.WEBADRES = txtWebAdres.Text;
                Cari.YETKILI1 = txtYetkili1.Text;
                Cari.YETKILI2 = txtYetkili2.Text;
                Cari.YETKILIEMAIL1 = txtYetkiliEmail1.Text;
                Cari.YETKILIEMAIL2 = txtYetkiliEmail2.Text;
                Cari.EDITDATE = DateTime.Now;
                Cari.EDITUSER = ANAFORM.UserId;
                DB.SubmitChanges();
                mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {

                mesajlar.Hata(e);
            }
        }
        void Sil()
        {
            try
            {
                DB.TBL_CARILERs.DeleteOnSubmit(DB.TBL_CARILERs.First(s => s.ID == CariID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e)
            {

                mesajlar.Hata(e);
            }
        }

        public void Ac(int ID)
        {
            try
            {
                Edit = true;
                CariID= ID;
                fonksiyonlar.TBL_CARILER Cari =DB.TBL_CARILERs.First(s=> s.ID == CariID);
                txtAdres.Text = Cari.ADRES;
                txtCariAdi.Text = Cari.CARIADI;
                txtCariKodu.Text = Cari.CARIKODU;
                txtFax1.Text = Cari.FAX1;
                txtFax2.Text = Cari.FAX2;
                txtİlce.Text = Cari.ILCE;
                txtMailInfo.Text = Cari.MAILINFO;
                txtSehir.Text = Cari.SEHIR;
                txtTelefon1.Text = Cari.TELEFON1;
                txtTelefon2.Text = Cari.TELEFON2;
                txtÜlke.Text = Cari.ULKE;
                txtVergiDairesi.Text = Cari.VERGİDAIRESI;
                txtVergiNo.Text = Cari.VERGINO;
                txtWebAdres.Text = Cari.WEBADRES;
                txtYetkili1.Text = Cari.YETKILI1;
                txtYetkili2.Text = Cari.YETKILI2;
                txtYetkiliEmail1.Text = Cari.YETKILIEMAIL1;
                txtYetkiliEmail2.Text = Cari.YETKILIEMAIL2;
                GrupAc(Cari.GRUPID.Value);
            }
            catch (Exception e)
            {

                mesajlar.Hata(e);
            }
        }

        void GrupAc(int ID)
        {
            try
            {
                GrupID = ID;
                fonksiyonlar.TBL_CAGRIGRUPLARI Grup = DB.TBL_CAGRIGRUPLARIs.First(s => s.ID == GrupID);
                txtGrupAdi.Text = Grup.GRUPADI;
                txtGrupKodu.Text = Grup.GRUPKODU;
            }
            catch (Exception e)
            {

                mesajlar.Hata(e);
            }
        }

        private void BTNKAPAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void BTNKAYDET_Click(object sender, EventArgs e)
        {
            if (Edit && CariID > 0 && mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();

        }

        private void txtGrupKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = FORMLAR.CariGruplari(true);
            if (ID > 0)
            {
                GrupAc(ID);
            }
            ANAFORM.Aktarma = -1;
        }

        private void txtCariKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = FORMLAR.CariListesi(true);
            if(ID > 0)
            {
                Ac(ID);
            }
            ANAFORM.Aktarma = -1;
        }


    }
}