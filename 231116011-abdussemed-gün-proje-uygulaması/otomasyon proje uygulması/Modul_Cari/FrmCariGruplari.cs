using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid.Handler;
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
    public partial class FrmCariGruplari : DevExpress.XtraEditors.XtraForm
    {
        fonksiyonlar.DATABASEDataContext DB = new fonksiyonlar.DATABASEDataContext();
        fonksiyonlar.Mesajlar Mesajlar =  new fonksiyonlar.Mesajlar();

        public bool Secim=false;
        bool Edit=false;
        int secimID = -1;
        public FrmCariGruplari()
        {
            InitializeComponent();
            
        }

        void Temizle()
        {
            txtGrupAdi.Text = "";
            txtGrupKodu.Text = "";
            Edit = false;
            secimID = -1;
            Listele();

        }
        void Listele()
        {
            var lst =from s in DB.TBL_CAGRIGRUPLARIs
                     select s;
            Liste.DataSource = lst;
        }


        void Sec()
        {
            try
            {
                Edit = true;
                secimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtGrupAdi.Text= gridView1.GetFocusedRowCellValue("GRUPADI").ToString();
                txtGrupKodu.Text = gridView1.GetFocusedRowCellValue("GRUPKODU").ToString();
            }
            catch (Exception)
            {

                Edit = false;
                secimID = -1;
            }
        }
        void YeniKaydet()
        {
            try
            {
                fonksiyonlar.TBL_CAGRIGRUPLARI Grup = new fonksiyonlar.TBL_CAGRIGRUPLARI();
                Grup.GRUPADI = txtGrupAdi.Text;
                Grup.GRUPKODU = txtGrupKodu.Text;
                Grup.SAVEDATE = DateTime.Now;
                Grup.SAVEUSER = ANAFORM.UserId;
                DB.TBL_CAGRIGRUPLARIs.InsertOnSubmit( Grup );
                DB.SubmitChanges();
                Mesajlar.YeniKayit("yeni cari grup kaydı oluşturuldu ");
                Temizle();

            }
            catch ( Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        void Guncelle()
        {
            try
            {
                fonksiyonlar.TBL_CAGRIGRUPLARI Grup = DB.TBL_CAGRIGRUPLARIs.First(s => s.ID == secimID);
                Grup.GRUPADI = txtGrupAdi.Text;
                Grup.GRUPKODU = txtGrupKodu.Text;
                Grup.EDITDATE = DateTime.Now;
                Grup.EDITUSER = ANAFORM.UserId;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                Temizle();
            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }


        void sil()
        {
            try
            {
                DB.TBL_CAGRIGRUPLARIs.DeleteOnSubmit(DB.TBL_CAGRIGRUPLARIs.First(s =>s.ID==secimID));
                DB.SubmitChanges();
                Temizle();
            }
            catch (Exception e )
            {

                Mesajlar.Hata(e);
            }
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if(Edit && secimID>0 && Mesajlar.Guncelle()==DialogResult.Yes) Guncelle();
            else YeniKaydet();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (Edit && secimID > 0 && Mesajlar.Sil() == DialogResult.Yes) sil();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmCariGruplari_Load(object sender, EventArgs e)
        {
            Listele();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Secim&& secimID > 0)
            {
                ANAFORM.Aktarma=secimID;
                this.Close();
            }
        }


    }
}