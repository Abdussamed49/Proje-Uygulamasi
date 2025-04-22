using DevExpress.XtraBars;
using System;

namespace otomasyon_proje_uygulması
{

    public partial class ANAFORM : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        fonksiyonlar.FORMLAR fORMLAR = new fonksiyonlar.FORMLAR();

        public static int UserId = -1;
        public static int Aktarma = -1;



        public ANAFORM()
        {
            InitializeComponent();
        }

        private void ANAFORM_Load(object sender, EventArgs e)
        {

        }

        public void Mesaj(string Baslik,string Mesaj)
        {
            ALC.Show(this, Baslik, Mesaj);
        }

        private void BARBTNSTOKKARTİ_ItemClick(object sender, ItemClickEventArgs e)
        {
            fORMLAR.STOKKARTI();
        }

        private void BARBTNSTOKLİSTESİ_ItemClick(object sender, ItemClickEventArgs e)
        {
            fORMLAR.STOKLİSTESİ();
        }

        private void barBuBARBTNSTOKGRUPLARİttonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            fORMLAR.STOKGRUPLARI();
        }

        private void BARBTNSTOKHAREKETLERİ_ItemClick(object sender, ItemClickEventArgs e)
        {
            fORMLAR.STOKHAREKETLERİ();
        }

        private void BarBtnCariAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            fORMLAR.CariAcilisKarti();
        }

        private void BarBtnCariGruplari_ItemClick(object sender, ItemClickEventArgs e)
        {
            fORMLAR.CariGruplari();
        }

        private void BarBtnCariListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            fORMLAR.CariListesi();
        }

        private void BarBtnCariHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
         
        }

        private void kasaaciliskarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            fORMLAR.KasaAcilisKarti();

        }

        private void barBtnKasaListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            fORMLAR.kasaDevirIslemKarti();
        }

        private void barBtnKasaTahsilatÖdemeKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            fORMLAR.KasaTahsilatÖdemeKarti();
        }

        private void barBtnKasaHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            fORMLAR.KasaHareketleri();
        }

        private void BarBtnBankaAcilisKarti_ItemClick(object sender, ItemClickEventArgs e)
        {
            fORMLAR.BankaAcilisKarti();
        }

        private void BarBtnBankaİslemi_ItemClick(object sender, ItemClickEventArgs e)
        {
            fORMLAR.BankaIslem();  

        }

        private void BarBtnBankaListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            fORMLAR.BankaListesii();
        }

        private void BarBtnParaTransferi_ItemClick(object sender, ItemClickEventArgs e)
        {
            fORMLAR.BankaParaTransfer();   

        }

        private void BarBtnBankaHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            fORMLAR.BankaHareketleri();
        }

        private void navBtnStokKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fORMLAR.STOKKARTI();
        }

        private void navBtnStokListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fORMLAR.STOKLİSTESİ();
        }

        private void navBtnStokGruplari_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fORMLAR.STOKGRUPLARI(); 
        }

        private void navBtnStokHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fORMLAR.STOKHAREKETLERİ();  
        }

        private void navBtnCariHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            
        }

        private void navBtnCariListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fORMLAR.CariListesi();
        }

        private void navBtnCariGruplari_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fORMLAR.CariGruplari();
        }

        private void navBtnCariAcilisKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fORMLAR.CariAcilisKarti();
        }

        private void navBtnBankaHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fORMLAR.BankaHareketleri();
        }

        private void navBtnBankaİslemi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fORMLAR.BankaIslem();  
        }

        private void navBtnBankaListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fORMLAR.BankaListesii();
        }

        private void navBtnParaTransferi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fORMLAR.BankaParaTransfer();   
        }

        private void navBtnBankaAcilisKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fORMLAR.BankaAcilisKarti();
        }

        private void navBtnKasaAcilisKarti_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fORMLAR.KasaAcilisKarti();
        }

        private void navBtnKasaHareketleri_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fORMLAR.KasaHareketleri();
        }

        private void navBtnKasaTahsilat_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fORMLAR.KasaTahsilatÖdemeKarti();
        }

        private void navBtnKasaDevirİslemi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fORMLAR.kasaDevirIslemKarti();  
        }

        private void navBtnKasaListesi_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            fORMLAR.KasaListesi();
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            fORMLAR.MusteriCeki();
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            fORMLAR.KendiCekimiz();
        }

        private void barButtonItem5_ItemClick(object sender, ItemClickEventArgs e)
        {
            fORMLAR.BankaCekCikisi(); 
        }

        private void barButtonItem6_ItemClick(object sender, ItemClickEventArgs e)
        {
            fORMLAR.CariyeCekCikisi();
        }
    }
}