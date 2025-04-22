using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DevExpress.Utils.Diagnostics.GUIResources;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace otomasyon_proje_uygulması.Modul_Banka
{
    public partial class FrmBankaHareketleri : Form
    {
        fonksiyonlar.DATABASEDataContext DB = new fonksiyonlar.DATABASEDataContext();   
        fonksiyonlar.Mesajlar Mesajlar = new fonksiyonlar.Mesajlar();
        fonksiyonlar.FORMLAR Formlar = new fonksiyonlar.FORMLAR();

        int BankaID = -1;
        int IslemID = -1;
        string EvrakTuru;

        public FrmBankaHareketleri()
        {
            InitializeComponent();
        }

        private void FrmBankaHareketleri_Load(object sender, EventArgs e)
        {

        }

        void Listele()
        {
            var lst = from  s in DB.VW_BANKAHAREKETLERIs
                      where s.BANKAID == BankaID    
                      select s; 
            Liste.DataSource = lst; 

        }

           public  void BankaAc(int ID)
        {
            try
            {
                BankaID = ID;
                fonksiyonlar.VW_BANKALISTESI Banka = DB.VW_BANKALISTESIs.First(s => s.ID == BankaID);
                txtHesapAdı.Text = Banka.HESAPADI;
                txtHesapNo.Text = Banka.HESAPNO;
              
                Listele();


            }
            catch (Exception e)
            {

                Mesajlar.Hata(e);
            }
        }

        private void txtHesapAdı_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int Id = Formlar.BankaListesii(true);          
            ANAFORM.Aktarma = -1;
        }

        void Sec()
        {
            try
            {
                IslemID =int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
            }
            catch (Exception)
            {

                IslemID = -1;
                EvrakTuru = gridView1.GetFocusedRowCellValue("EVRAKTURU").ToString();   
            }
        }
        private void SagTik_Opening(object sender, CancelEventArgs e)
        {
            if (IslemID > 0)
            {
                Sec();
                if (EvrakTuru == "banka işlem")
                {
                    BankaIslmeıDuzenle.Enabled = true;
                    ParaTransferDuzenle.Enabled = false;
                }
                else if (EvrakTuru == "BANKA EFT" || EvrakTuru == "BANKA HAVALE")
                {
                    BankaIslmeıDuzenle.Enabled = false;
                    ParaTransferDuzenle.Enabled = true;
                } 
            }
        }

        private void BankaIslmeıDuzenle_Click(object sender, EventArgs e)
        {
            Formlar.BankaIslem(true, IslemID);
            Listele();

        }

        private void ParaTransferDuzenle_Click(object sender, EventArgs e)
        {
            Formlar.BankaParaTransfer(true, IslemID);
            Listele();
        }
    }
}
