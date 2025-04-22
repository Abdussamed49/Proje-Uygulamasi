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
    public partial class FrmKasaAcilisKarti : DevExpress.XtraEditors.XtraForm
    {
        fonksiyonlar.DATABASEDataContext DB = new fonksiyonlar.DATABASEDataContext();
        fonksiyonlar.Mesajlar Mesajlar = new fonksiyonlar.Mesajlar();
        fonksiyonlar.Numara Numaralar = new fonksiyonlar.Numara();

        bool Edit = false;
        int SecimID = -1;

        public FrmKasaAcilisKarti()
        {
            InitializeComponent();
        }

        private void FrmKasaAcilisKarti_Load(object sender, EventArgs e)
        {
            txtKasaKodu.Text = Numaralar.KasaKodNumarasi();
            Listele();
        }

        void Temizle()
        {
            txtKasaKodu.Text = Numaralar.KasaKodNumarasi();
            txtKasaAdi.Text = "";
            txtAciklama.Text = "";
            Edit = false;
            SecimID = -1;
            Listele();


     }

        void YeniKaydet()
        {
            try
            {
                fonksiyonlar.TBL_KASALAR kasa = new fonksiyonlar.TBL_KASALAR();
                kasa.ACIKLAMA = txtAciklama.Text;
                kasa.KASAADI = txtKasaAdi.Text;
                kasa.KASAKODU = txtKasaKodu.Text;
                kasa.SAVEDATE = DateTime.Now;
                kasa.SAVEUSER = ANAFORM.UserId;
                DB.TBL_KASALARs.InsertOnSubmit(kasa);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("YENİ KASA KAYDI OLUŞTURULMUŞTUR");
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
                fonksiyonlar.TBL_KASALAR kasa =DB.TBL_KASALARs.First(S=>S.ID ==SecimID);
                kasa.ACIKLAMA = txtAciklama.Text;
                kasa.KASAADI = txtKasaAdi.Text;
                kasa.KASAKODU = txtKasaKodu.Text;
                kasa.EDITDATE = DateTime.Now;
                kasa.EDITUSER = ANAFORM.UserId;
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
                DB.TBL_KASALARs.DeleteOnSubmit(DB.TBL_KASALARs.First(s => s.ID == SecimID));
                DB.SubmitChanges();
                Temizle();
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
                Edit=true;
                SecimID =int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtAciklama.Text=gridView1.GetFocusedRowCellValue("ACIKLAMA").ToString();
                txtKasaKodu.Text = gridView1.GetFocusedRowCellValue("KASAKODU").ToString();
                txtKasaAdi.Text = gridView1.GetFocusedRowCellValue("KASAADI").ToString();


            }
            catch (Exception )
            {

                Edit = false;
                SecimID = -1;

            }
        }

        void Listele()
        {
            var lst = from s in DB.TBL_KASALARs
                      select s;
            Liste.DataSource = lst;
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
        }

        private void BTNKAYDET_Click(object sender, EventArgs e)
        {
            if (txtKasaAdi.Text != "" && txtAciklama.Text != "")

            {
                if(Edit && SecimID > 0 && Mesajlar.Guncelle() == DialogResult.Yes) Guncelle();
                 else YeniKaydet();
            }

            else MessageBox.Show("KASA ADI VE AÇIKLAMA GİRİLMESİ GEREKLİDİR.","İŞLEM HATASI",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }
        private void BTNSİL_Click(object sender, EventArgs e)
        {
            if (Edit && SecimID > 0 && Mesajlar.Sil() == DialogResult.Yes) Sil();
        }

        private void BTNKAPAT_Click(object sender, EventArgs e)
        {
         this.Close();
        }
    }
}
