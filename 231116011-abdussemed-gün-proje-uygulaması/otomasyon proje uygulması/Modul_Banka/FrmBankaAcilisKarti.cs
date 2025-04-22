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

namespace otomasyon_proje_uygulması.Modul_Banka
{
    public partial class FrmBankaAcilisKarti : Form
    {
        fonksiyonlar.DATABASEDataContext DB = new fonksiyonlar.DATABASEDataContext();
        fonksiyonlar.Mesajlar Mesajlar = new fonksiyonlar.Mesajlar();   

        bool Edit = false;
        int SecimID = -1;
        public FrmBankaAcilisKarti()
        {
            InitializeComponent();
        }

        private void FrmBankaAcilisKarti_Load(object sender, EventArgs e)
        {
            listele();
        }

        private void Temizle()
        {
            txtAdres.Text = "";
            txtBankaAdi.Text = "";
            txtHesapNo.Text = "";
            txtİban.Text = "";
            txtSube.Text = "";
            txtBankaSubeTelefon.Text = "";
            txtTemsilci.Text = "";
            txtTemsilciEmail.Text = "";
            Edit=false;
            SecimID = -1;
            listele();
        }
        void listele()
        {
            var lst = from s in DB.TBL_BANKALARs
                      select s;
            Liste.DataSource = lst; 

        }

        void YeniKaydet()
        {
            try
            {
                fonksiyonlar.TBL_BANKALAR Banka = new fonksiyonlar.TBL_BANKALAR();
                Banka.ADRES =txtAdres.Text; 
                Banka.BANKAADI= txtBankaAdi.Text;   
                Banka.HESAPADI=txtHesapAdi.Text;
                Banka.HESAPNO = txtHesapNo.Text;
                Banka.TEL = txtBankaSubeTelefon.Text;
                Banka.TEMSILCI = txtTemsilci.Text;
                Banka.TEMSILCIEMAIL=txtTemsilciEmail.Text;
                Banka.SAVEDATE = DateTime.Now;
                Banka.SAVEUSER = ANAFORM.UserId;
                DB.TBL_BANKALARs.InsertOnSubmit(Banka);
                DB.SubmitChanges(); 
                Mesajlar.YeniKayit("yeni banka kaydı açılmıştır");
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
                fonksiyonlar.TBL_BANKALAR Banka = DB.TBL_BANKALARs.First(s=> s.ID == SecimID); 

                Banka.ADRES = txtAdres.Text;
                Banka.BANKAADI = txtBankaAdi.Text;
                Banka.HESAPADI = txtHesapAdi.Text;
                Banka.HESAPNO = txtHesapNo.Text;
                Banka.TEL = txtBankaSubeTelefon.Text;
                Banka.TEMSILCI = txtTemsilci.Text;
                Banka.TEMSILCIEMAIL = txtTemsilciEmail.Text;
                Banka.EDITDATE = DateTime.Now;            
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
                DB.TBL_BANKALARs.DeleteOnSubmit(DB.TBL_BANKALARs.First(s => s.ID == SecimID));

            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }
        

        void Sec()
        {
            try
            {
                Edit = true;
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                if (SecimID > 0) Ac();
            }
            catch (Exception)
            {

                Edit = false;
                SecimID = -1;
            }
        }

        void Ac()
        {
            try
            {
                fonksiyonlar.TBL_BANKALAR Banka = DB.TBL_BANKALARs.First(s=>s.ID == SecimID);
                txtAdres.Text = Banka.ADRES;
                txtBankaAdi.Text = Banka.BANKAADI;
                txtHesapAdi.Text = Banka.HESAPADI;
                txtHesapNo.Text= Banka.HESAPNO;
                txtSube.Text = Banka.ŞUBE;
                txtBankaSubeTelefon.Text = Banka.TEL;
                txtTemsilci.Text = Banka.TEMSILCI;
                txtTemsilciEmail.Text = Banka.TEMSILCIEMAIL;

            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        private void BTNKAYDET_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
            else YeniKaydet();  
        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
            DB.SubmitChanges(); 
            Temizle();

        }

        private void BTNKAPAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Liste_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }
    }
}
