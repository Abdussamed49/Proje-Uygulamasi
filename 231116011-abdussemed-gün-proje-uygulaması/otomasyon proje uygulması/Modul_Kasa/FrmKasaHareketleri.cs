using DevExpress.XtraEditors;
using otomasyon_proje_uygulması.fonksiyonlar;
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
    public partial class FrmKasaHareketleri : DevExpress.XtraEditors.XtraForm
    {
        fonksiyonlar.DATABASEDataContext DB = new fonksiyonlar.DATABASEDataContext();   
        fonksiyonlar.Mesajlar Mesajlar = new fonksiyonlar .Mesajlar();
        fonksiyonlar.FORMLAR Formlar = new FORMLAR();
        int HareketID = -1;
        int EvrakID = -1;
        int KasaID = -1;
        String EvrakTURU;

        public FrmKasaHareketleri()
        {
            InitializeComponent();
        }

        private void FrmKasaHareketleri_Load(object sender, EventArgs e)
        {

        }

        public void Ac(int ID)
        {
            try
            {
                KasaID = ID;
                txtKasaKodu.Text = DB.TBL_KASALARs.First(s => s.ID == KasaID).KASAKODU;
                txtKasaAdi.Text = DB.TBL_KASALARs.First(s => s.ID == KasaID).KASAADI;
                DurumGetir();
                Listele();
            }
            catch (Exception e)
            {
                Mesajlar.Hata(e);
                
            }                                                        
        }

        void DurumGetir()
        {
            fonksiyonlar.VW_KASADURUM kasa = DB.VW_KASADURUMs.First(s=> s.KASAID == KasaID);    
            txtGiris.Text=kasa.GIRIS.Value.ToString();
            txtCikis.Text=kasa.CIKIS.Value.ToString();
            txtBakiye.Text = kasa.BAKIYE.Value.ToString();  


        }


        void Listele()
        {
            var lst = from s in DB.VW_KASAHAREKETLERIs
                      where s.KASAID == KasaID
                      select s;
            Liste.DataSource = lst;
        }

        private void txtKasaKodu_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            int ID = Formlar.KasaListesi(true);
            if ((ID >0))
            {
                    Ac(ID);
                ANAFORM.Aktarma = -1;
            }

        }

        void Sec()
        {
            try
            {
                HareketID = int.Parse(gridView1.GetFocusedRowCellValue("ID").ToString());
                try
                {
                    EvrakID = int.Parse(gridView1.GetFocusedRowCellValue("EVRAKID").ToString());  
                }
                catch (Exception)
                {

                    EvrakID = -1;

                }

                EvrakTURU =gridView1.GetFocusedRowCellValue("EVRAKTURU").ToString();    

            }
            catch (Exception)
            {
                HareketID= -1;
                EvrakID = -1;
                EvrakTURU = "";

                
            }
        }

        private void sagTik_Opening(object sender, CancelEventArgs e)
        {
            Sec();  
            if(EvrakTURU == "KASA DEVİR KARTI")
            {
                DevirKartiDuzenle.Enabled = true;
                TahsilatOdemeDuzenle.Enabled=false;
                
            }
            else if(EvrakTURU == "KASA TAHSİLAT"|| EvrakTURU =="Kasa Ödeme")
            {
                DevirKartiDuzenle.Enabled=false ;
                TahsilatOdemeDuzenle.Enabled = true;

            }
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void DevirKartiDuzenle_Click(object sender, EventArgs e)
        {
            Formlar.kasaDevirIslemKarti(true,HareketID);
            Listele();
            
        }

        private void TahsilatOdemeDuzenle_Click(object sender, EventArgs e)
        {
            Formlar.KasaTahsilatÖdemeKarti(true,HareketID);
            Listele();
        }
    }
}