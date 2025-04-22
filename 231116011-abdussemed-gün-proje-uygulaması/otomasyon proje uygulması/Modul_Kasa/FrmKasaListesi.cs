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
    public partial class FrmKasaListesi : DevExpress.XtraEditors.XtraForm
    {
        fonksiyonlar.DATABASEDataContext DB = new fonksiyonlar.DATABASEDataContext();

        public bool Secim = false;
        int secimID = -1;
        public FrmKasaListesi()
        {
            InitializeComponent();
        }

        private void FrmKasaListesi_Load(object sender, EventArgs e)
        {
            Listele();
        }

        void Listele()
        {
            var lst = from s in DB.VW_KASALISTESIs
                      where s.KASAKODU.Contains(txtKasaKodu.Text) && s.KASAADI.Contains(txtKasaAdi.Text)
                      select s;
            Liste.DataSource = lst; 
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
            if (Secim && secimID>0)
            {
                ANAFORM.Aktarma = secimID;
                    this.Close();   
            }
        }

        private void BTNARA_Click(object sender, EventArgs e)
        {
            Listele();
        }
    }
}