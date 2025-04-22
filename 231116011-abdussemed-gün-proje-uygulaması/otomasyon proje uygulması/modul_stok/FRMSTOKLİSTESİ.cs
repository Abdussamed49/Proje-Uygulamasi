using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace otomasyon_proje_uygulması.modul_stok
{
   
    public partial class FRMSTOKLİSTESİ : Form
    {
        fonksiyonlar.DATABASEDataContext DB=new fonksiyonlar.DATABASEDataContext();


        public bool SECİM = false;
        int secimID = -1;
        public FRMSTOKLİSTESİ()
        {
            InitializeComponent();
        }

        private void FRMSTOKLİSTESİ_Load(object sender, EventArgs e)
        {
            LİSTELE();
        }
        void LİSTELE()
        {
            var lst = from s in DB.TBL_STOKLARs
                      where s.STOKADI.Contains(TXTSTOKADİ.Text) &&s.STOKBARKOD.Contains(TXTBARKOD.Text) && s.STOKKODU.Contains(TXTSTOKKODU.Text)
                      select s;
            Liste.DataSource = lst; 
        }

        private void BTNARA_Click(object sender, EventArgs e)
        {
            LİSTELE();
        }

        private void BTNSİL_Click(object sender, EventArgs e)
        {
            TXTBARKOD.Text = "";
            TXTSTOKADİ.Text = "";
            TXTSTOKKODU.Text = "";
        }

        void Sec()
        {
            try
            {
                secimID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());

            }
            catch (Exception)
            {
                secimID = -1;

             
            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            Sec();
            if (SECİM && secimID>0)
            {
                ANAFORM.Aktarma = secimID;
                this.Close();   
            }
        }
    }
}
