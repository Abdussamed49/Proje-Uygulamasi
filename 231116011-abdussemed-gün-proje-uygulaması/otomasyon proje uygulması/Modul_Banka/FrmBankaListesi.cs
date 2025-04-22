using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon_proje_uygulması.Modul_Banka
{
    public partial class FrmBankaListesi : Form
    {
        fonksiyonlar.DATABASEDataContext DB = new fonksiyonlar.DATABASEDataContext();

        public bool Secim = false;
        int SecimID = -1;
        

        public FrmBankaListesi()
        {
            InitializeComponent();
        }

        private void FrmBankaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.VW_BANKALISTESIs
                      where s.HESAPADI.Contains(txtHesapAdı.Text) && s.HESAPNO.Contains(txtHesapNo.Text) && s.IBAN.Contains(txtIban.Text)
                      select s;
            Liste.DataSource = lst;
        }

        void Sec()
        {
            try
            {
                SecimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString()); 
            }
            catch (Exception)
            {

                SecimID = -1;
            }
        }

        private void xtraTabPage1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if(Secim && SecimID > 0) 
                ANAFORM.Aktarma  = SecimID;
                this.Close();
        }
    }
}
