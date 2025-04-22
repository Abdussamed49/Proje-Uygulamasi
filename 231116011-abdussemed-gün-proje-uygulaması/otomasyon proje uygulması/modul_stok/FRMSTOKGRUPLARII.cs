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
using System.Xml.Serialization;

namespace otomasyon_proje_uygulması.modul_stok
{
    public partial class FRMSTOKGRUPLARII : DevExpress.XtraEditors.XtraForm
    {
        fonksiyonlar.DATABASEDataContext DB = new fonksiyonlar.DATABASEDataContext();
        fonksiyonlar.Mesajlar Mesajlar = new fonksiyonlar.Mesajlar();




        public bool secim = false;
        int SecimId = -1;
        bool edit = false;

        public FRMSTOKGRUPLARII()
        {
            InitializeComponent();
        }

        private void FRMSTOKGRUPLARII_Load(object sender, EventArgs e)
        {
            listele();
        }

        void listele()
        {
            var lst = from s in DB.TBL_STOKGRUPLARIs
                      select s;
            Liste.DataSource = lst;
        }

        void temizle()
        {
            txtGrupKodu.Text = "";
            txtGrupAdi.Text = "";
            edit = false;
            listele();
        }

        void YeniKaydet()
        {
            try
            {
                fonksiyonlar.TBL_STOKGRUPLARI Grup = new fonksiyonlar.TBL_STOKGRUPLARI();
                Grup.GRUPADI = txtGrupAdi.Text;
                Grup.GRUPKODU = txtGrupKodu.Text;
                Grup.GRUPSAVEDATE = DateTime.Now;
                Grup.GRUPSAVEUSER = ANAFORM.UserId;
                DB.TBL_STOKGRUPLARIs.InsertOnSubmit(Grup);
                DB.SubmitChanges();
                Mesajlar.YeniKayit("Yeni grup kaydı oluşturuldu.");
                temizle();
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
                fonksiyonlar.TBL_STOKGRUPLARI Grup = DB.TBL_STOKGRUPLARIs.First(s => s.ID == SecimId);
                Grup.GRUPKODU = txtGrupKodu.Text;
                Grup.GRUPADI = txtGrupAdi.Text;
                Grup.GRUPEDITUSER = ANAFORM.UserId;
                Grup.GRUPEDITDATE = DateTime.Now;
                DB.SubmitChanges();
                Mesajlar.Guncelle(true);
                temizle();
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
                DB.TBL_STOKGRUPLARIs.DeleteOnSubmit(DB.TBL_STOKGRUPLARIs.First(s => s.ID == SecimId));
                DB.SubmitChanges();
                temizle();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (edit && SecimId > 0 && Mesajlar.Sil() == DialogResult.Yes)
                sil();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (edit && SecimId > 0 && Mesajlar.Guncelle() == DialogResult.Yes)
                Guncelle();
            else
                YeniKaydet();
        }


        void Sec()
        {
            try
            {
                edit = true;
                SecimId = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                txtGrupAdi.Text = gridView1.GetFocusedRowCellValue("GRUPADI").ToString();
                txtGrupKodu.Text = gridView1.GetFocusedRowCellValue("GRUPKODU").ToString();
            }
            catch (Exception)
            {

                edit = false;
                SecimId = -1;
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (secim && SecimId>0)
            {
                ANAFORM.Aktarma = SecimId;
                this.Close();
            }
        }
    }
}