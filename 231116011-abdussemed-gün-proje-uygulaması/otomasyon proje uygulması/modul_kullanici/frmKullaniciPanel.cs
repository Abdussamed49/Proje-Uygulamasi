using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon_proje_uygulması.modul_kullanici
{
    public partial class frmKullaniciPanel : DevExpress.XtraEditors.XtraForm
    {
        fonksiyonlar.DATABASEDataContext DB = new fonksiyonlar.DATABASEDataContext();
        fonksiyonlar.Mesajlar Mesajlar = new fonksiyonlar.Mesajlar();

        bool Ac = false;
        int KullaniciID = -1;

        public frmKullaniciPanel(int ID , bool Acc)
        {
            InitializeComponent();
            Ac = Acc;
            KullaniciID=ID;
            //if (Ac) kullaniciGetir(ID);

        }

        void Temizle()
        {
            txtisim.Text = "";
            txtkullaniciadi.Text = "";
            txtsifre.Text = "";
            txtsifret.Text = "";
            txtsoyisim.Text = "";
            rbtnpasif.Checked = true;
            Ac = false;
            KullaniciID = -1;
        }

        void KullanıcıGetir(int ID )
        {
            KullaniciID=ID ;
            try
            {
                fonksiyonlar.TBL_KULLANICILAR Kullanici = DB.TBL_KULLANICILARs.First(s => s.ID == KullaniciID);
                txtisim.Text = Kullanici.ISIM;
                txtkullaniciadi.Text = Kullanici.KULLANICI;
                txtsifre.Text = Kullanici.SIFRE;
                txtsifret.Text = Kullanici.SIFRE;

                if (Kullanici.KODU == "Normal")
                    if (Kullanici.KODU == "Yönetici") ;
                {
                    if(Kullanici.AKTIF.Value) rbtnaktif.Checked = true;   
                    if(Kullanici.AKTIF.Value) rbtnpasif.Checked=true;   

                }
;
            }
            catch (Exception EX)
            {

                Mesajlar.Hata(EX);
            }
        }

        private void frmKullaniciPanel_Load(object sender, EventArgs e)
        {

        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            Temizle();
        }

        private void btnkapat_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {

        }

        void YeniKaydet()
        {
            if (txtsifre.Text.Trim() == txtsifret.Text.Trim())
            {

                if (txtisim.Text=="")
                {
                    MessageBox.Show("BİR İSİM GİRİŞİ YAPINIZ");
                    return;
                    
                }
                else if (txtsoyisim.Text == "")
                {
                    MessageBox.Show("BİR SOYİSİM GİRİŞİ YAPMAK ZORUNDASINIZ");
                    return;
                }
                DialogResult DR = MessageBox.Show(txtkullaniciadi.Text + " türünde bir kullanıcı açmak üzeresiniz emin misiniz ?", "kullanıcı kaydı tamamlama", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(DR == System.Windows.Forms.DialogResult.Yes)
                    try
                    {
                        fonksiyonlar.TBL_KULLANICILAR Kullanici;
                        if (!Ac) Kullanici = new fonksiyonlar.TBL_KULLANICILAR();
                        else Kullanici = DB.TBL_KULLANICILARs.First(s => s.ID == KullaniciID);
                        if (rbtnaktif.Checked) Kullanici.AKTIF = true;
                        if (rbtnpasif.Checked) Kullanici.AKTIF = false;
                        Kullanici.ISIM = txtisim.Text;
                        Kullanici.SOYISIM=txtsoyisim.Text;  

                    }
                    catch (Exception EX)
                    {

                        Mesajlar.Hata(EX);
                    }

                    
            else MessageBox.Show("ŞİFRELER AYNI DEĞİL");
            
            
        }
        
    }
}
}