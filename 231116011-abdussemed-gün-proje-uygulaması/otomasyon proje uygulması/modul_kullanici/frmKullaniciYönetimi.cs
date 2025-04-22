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

namespace otomasyon_proje_uygulması.modul_kullanici
{
    public partial class frmKullaniciYönetimi : DevExpress.XtraEditors.XtraForm
    {
        fonksiyonlar.DATABASEDataContext DB = new fonksiyonlar.DATABASEDataContext();   
        fonksiyonlar.FORMLAR Formlar = new fonksiyonlar .FORMLAR(); 
        fonksiyonlar.Mesajlar Mesajlar = new fonksiyonlar.Mesajlar();


        public frmKullaniciYönetimi()
        {
            InitializeComponent();
            
        }

        private void frmKullaniciYönetimi_Load(object sender, EventArgs e)
        {
            Listele();
        }
        void Listele()
        {
           gridControl1.DataSource = DB;    
        }

        private void btnYeniKullanici_Click(object sender, EventArgs e)
        {
            Formlar.MusteriCeki();
        }

        private void btnSeciliKullanici_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            Formlar.kasaDevirIslemKarti(true, ID);
            Listele();  
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if(Mesajlar.Sil()==DialogResult.Yes)    
            DB.TBL_KULLANICILARs.DeleteOnSubmit(DB.TBL_KULLANICILARs.First());
        }

        private void frmKullaniciYönetimi_Click(object sender, EventArgs e)
        {
        }

        void Secim()
        {
            Listele();
        }
    }
}