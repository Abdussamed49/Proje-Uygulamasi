using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace otomasyon_proje_uygulması.modul_stok
{
    public partial class FRMSTOKKARTI : Form
    {
        fonksiyonlar.DATABASEDataContext DB = new fonksiyonlar.DATABASEDataContext();
        fonksiyonlar.Mesajlar Mesajlar =new fonksiyonlar.Mesajlar();    
        fonksiyonlar.Numara Numaralar = new fonksiyonlar.Numara();  
        fonksiyonlar.FORMLAR Formlar = new fonksiyonlar.FORMLAR();
        fonksiyonlar.Resimleme Resimleme = new fonksiyonlar.Resimleme();


        bool Edit=false;
        bool Resim = false;
        OpenFileDialog Dosya = new OpenFileDialog();
        int GrupID = -1;
        int stokID = -1;
        public FRMSTOKKARTI()
        {
            InitializeComponent();
        }

        private void FRMSTOKKARTI_Load(object sender, EventArgs e)
        {
            TXTSTOKKODU.Text = Numaralar.StokKodNumarasi();
            Mesajlar.FormAcilis(this.Text);
        }


        void Temizle()
        {
            TXTSTOKKODU.Text = Numaralar.StokKodNumarasi();
            TXTSTOKADI.Text = "";
            TXTSATİSKDV.Text = "0";
            TXTSATİSFİYAT.Text = "0";
            TXTGRUPKODU.Text = "";
            TXTGRUPADI.Text = "";
            TXTBİRİM.SelectedIndex = 0;
            TXTBARKOD.Text = "";
            TXTALİSKDV.Text="0";
            TXTALISFİYAT.Text= "0";
            pictureBox1.Image = null;
            Edit = false;
            Resim= false;
            GrupID = -1;
            stokID= -1;
            ANAFORM.Aktarma = -1;
        }

        void ResimSec()
        {
            Dosya.Filter = "JPG(*.jpg)|*jpg|JPEG(*.jpeg)|*.jpeg";
            if (Dosya.ShowDialog()==DialogResult.OK)
            {
                pictureBox1.ImageLocation = Dosya.FileName;
                Resim = true;

            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            ResimSec();
        }

        public void Ac(int ID)
        {
            Edit = true;
            stokID= ID;
            fonksiyonlar.TBL_STOKLAR stok =DB.TBL_STOKLARs.First(s=> s.ID == stokID);
            GrupAc(stok.STOKGRUPID.Value);
             pictureBox1.Image=Resimleme.ResimGetirme(stok.STOKRESIM.ToArray());
            TXTALISFİYAT.Text=stok.STOKALISFİYAT.ToString();    
            TXTALİSKDV.Text=stok.STOKALISKDV.ToString();
            TXTBARKOD.Text = stok.STOKBARKOD;
            TXTBİRİM.Text = stok.STOKBİRİM;
            TXTSATİSFİYAT.Text = stok.STOKSATISFİYAT.ToString();
            TXTSATİSKDV.Text=stok.STOKSATISKDV.ToString();
            TXTSTOKADI.Text = stok.STOKADI;
            TXTSTOKKODU.Text=stok.STOKKODU;



        }

        void YeniKaydet()
        {
            try
            {
                fonksiyonlar.TBL_STOKLAR stok = new fonksiyonlar.TBL_STOKLAR();
                stok.STOKADI = TXTSTOKADI.Text;
                stok.STOKALISFİYAT = decimal.Parse(TXTALISFİYAT.Text);
                stok.STOKALISKDV = decimal.Parse(TXTALİSKDV.Text);
                stok.STOKBARKOD = TXTBARKOD.Text;
                stok.STOKBİRİM = TXTBİRİM.Text;
                stok.STOKGRUPID = GrupID;
                stok.STOKKODU = TXTSTOKKODU.Text;
                stok.STOKRESIM = new System.Data.Linq.Binary(Resimleme.ResimYukleme(pictureBox1.Image));
                stok.STOKSATISFİYAT = decimal.Parse(TXTSATİSFİYAT.Text);
                stok.STOKSATISKDV = decimal.Parse(TXTSATİSKDV.Text);
                stok.STOKSAVEDATE = DateTime.Now;
                stok.STOKSAVEUSER = ANAFORM.UserId;
                DB.TBL_STOKLARs.InsertOnSubmit(stok);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("yeni stok kaydı oluşturuldu");
                Temizle();
            }
            catch (Exception e )
            {

                Mesajlar.Hata(e);
            }
        }

        void Guncelle()
        {
            try
            {
                fonksiyonlar.TBL_STOKLAR stok = DB.TBL_STOKLARs.First(S => S.ID == stokID);
                stok.STOKADI = TXTSTOKADI.Text;
                stok.STOKALISFİYAT = decimal.Parse(TXTALISFİYAT.Text);
                stok.STOKALISKDV = decimal.Parse(TXTALİSKDV.Text);
                stok.STOKBARKOD = TXTBARKOD.Text;
                stok.STOKBİRİM = TXTBİRİM.Text;
                stok.STOKGRUPID = GrupID;
                stok.STOKKODU = TXTSTOKKODU.Text;
                 if(Resim) stok.STOKRESIM = new System.Data.Linq.Binary(Resimleme.ResimYukleme(pictureBox1.Image));
                stok.STOKSATISFİYAT = decimal.Parse(TXTSATİSFİYAT.Text);
                stok.STOKSATISKDV = decimal.Parse(TXTSATİSKDV.Text);
                stok.STOKEDITDATE = DateTime.Now;
                stok.STOKEDITUSER = ANAFORM.UserId;
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
                DB.TBL_STOKLARs.DeleteOnSubmit(DB.TBL_STOKLARs.First(s => s.ID == stokID));
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void GrupAc(int ID)
        {
            GrupID = ID;
            TXTGRUPADI.Text = DB.TBL_STOKGRUPLARIs.First(S => S.ID == GrupID).GRUPADI;   
            TXTGRUPKODU.Text= DB.TBL_STOKGRUPLARIs.First(S => S.ID == GrupID).GRUPKODU;
        }

        private void TXTSTOKKODU_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.STOKLİSTESİ(true);
            if (ID > 0)
            {
                Ac(ID);

            }
            ANAFORM.Aktarma = -1;
        }

        private void TXTGRUPKODU_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.STOKGRUPLARI(true);
            if (Id > 0)
            {

                GrupAc(Id);
            }
            ANAFORM.Aktarma = -1;
        }

        private void BTNKAPAT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            if (Edit && stokID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();            
        }

        private void BTNKAYDET_Click(object sender, EventArgs e)
        {
            if(Edit && stokID>0 && Mesajlar.Guncelle()==DialogResult.Yes)
            {
                Guncelle();
            }
            else
            {
                YeniKaydet();
            }
        }

        private void FRMSTOKKARTI_FormClosed(object sender, FormClosedEventArgs e)
        {
           Mesajlar.FormKapanis(this.Text); 
        }
    }
}
