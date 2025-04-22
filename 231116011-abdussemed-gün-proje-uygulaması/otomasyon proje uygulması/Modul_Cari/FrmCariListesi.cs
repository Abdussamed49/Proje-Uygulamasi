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

namespace otomasyon_proje_uygulması.Modul_Cari
{
    public partial class FrmCariListesi : DevExpress.XtraEditors.XtraForm
    {
        fonksiyonlar.DATABASEDataContext DB =new fonksiyonlar.DATABASEDataContext();
        public bool secim =false;
        int secimID = -1;
        public FrmCariListesi()
        {
            InitializeComponent();
        }

        private void FrmCariListesi_Load(object sender, EventArgs e)
        {
            listele();
        }

        void listele()
        {
            var LST = from s in DB.TBL_CARILERs
            where s.CARIADI.Contains(TxtCariAdi.Text)&& s.CARIKODU.Contains(TxtCariKodu.Text)   
            select s;
           Liste.DataSource = LST;
        }

        void Sec()
        {
            try
            {
                secimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception e)
            {

                secimID = -1;
            }
        }

        private void FrmCariListesi_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(secim && secimID > 0)
            {
                ANAFORM.Aktarma = secimID;
                this.Close();
            } 
        }
    }
}