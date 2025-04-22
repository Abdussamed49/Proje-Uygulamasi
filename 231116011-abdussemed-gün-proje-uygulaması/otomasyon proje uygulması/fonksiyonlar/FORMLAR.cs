using DevExpress.XtraPrinting.Native.Lines;
using otomasyon_proje_uygulması.fonksiyonlar;
using otomasyon_proje_uygulması.modul_stok;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace otomasyon_proje_uygulması.fonksiyonlar
{
    internal class FORMLAR
    {
        #region stok formları

        public int STOKLİSTESİ(bool SECİM = false)
        {
            modul_stok.FRMSTOKLİSTESİ FRM = new modul_stok.FRMSTOKLİSTESİ();
            if (SECİM)
            {
                FRM.SECİM = SECİM;
                FRM.ShowDialog();

            }
            else
            {
                FRM.MdiParent = ANAFORM.ActiveForm;
                FRM.Show();

            }
            return ANAFORM.Aktarma;

        }

        public int STOKGRUPLARI(bool SECİM = false)
        {
            modul_stok.FRMSTOKGRUPLARII frm = new modul_stok.FRMSTOKGRUPLARII();
            if (SECİM) frm.secim = SECİM;

            frm.ShowDialog();
            return ANAFORM.Aktarma;


        }

        public void STOKHAREKETLERİ(bool Ac = false)
        {

        }
        public void STOKKARTI(bool Ac = false)
        {
            modul_stok.FRMSTOKKARTI frm = new modul_stok.FRMSTOKKARTI();
            frm.ShowDialog();
        }
        #endregion


        #region Cari Formları
        public int CariGruplari(bool secim = false)
        {
            Modul_Cari.FrmCariGruplari frm = new Modul_Cari.FrmCariGruplari();
            if (secim) frm.Secim = secim;
            frm.ShowDialog();
            return ANAFORM.Aktarma;
        }

        public int CariListesi(bool secim = false)
        {
            Modul_Cari.FrmCariListesi frm = new Modul_Cari.FrmCariListesi();
            if (secim)
            {
                frm.secim = secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = ANAFORM.ActiveForm;
                frm.Show();
            }
            return ANAFORM.Aktarma;
        }


        public void CariAcilisKarti(bool Ac = false, int CariID = -1)
        {
            Modul_Cari.FrmAcilisKarti frm = new Modul_Cari.FrmAcilisKarti();
            if (Ac) frm.Ac(CariID);
            frm.ShowDialog();
        }
        #endregion
        #region KasaFormları

        public void KasaAcilisKarti()
        {
            Modul_Kasa.FrmKasaAcilisKarti frm = new Modul_Kasa.FrmKasaAcilisKarti();
            frm.ShowDialog();

        }

        public void kasaDevirIslemKarti(bool Ac = false, int IslemID = -1)
        {
            Modul_Kasa.FrmKasaDevirİslem frm = new Modul_Kasa.FrmKasaDevirİslem();
            if (Ac) frm.Ac(IslemID);
            frm.ShowDialog();
        }


        public int KasaListesi(bool secim = false)
        {
            Modul_Kasa.FrmKasaListesi frm = new Modul_Kasa.FrmKasaListesi();
            if (secim)
            {
                frm.Secim = secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = ANAFORM.ActiveForm;
                frm.Show();
            }

            return ANAFORM.Aktarma;
        }

        public void KasaTahsilatÖdemeKarti(bool Ac = false, int ID = -1)
        {
            Modul_Kasa.FrmKasaTahsilatÖdeme frm = new Modul_Kasa.FrmKasaTahsilatÖdeme();
            if (Ac) frm.Ac(ID);
            frm.ShowDialog();
        }

        public void KasaHareketleri(bool Ac = false, int ID = -1)
        {
            Modul_Kasa.FrmKasaHareketleri frm = new Modul_Kasa.FrmKasaHareketleri();
            frm.MdiParent = ANAFORM.ActiveForm;
            if (Ac) frm.Ac(ID);
            frm.Show();
        }

        #endregion

        #region BankaFormları
        public void BankaAcilisKarti()
        {
            Modul_Banka.FrmBankaAcilisKarti frm = new Modul_Banka.FrmBankaAcilisKarti();
            frm.ShowDialog();

        }

        public void BankaIslem(bool Ac = false, int ID = -1)
        {
            Modul_Banka.FrmBankaİslem frm = new Modul_Banka.FrmBankaİslem();
            if (Ac) frm.Ac(ID);
            frm.ShowDialog();
        }

        public int BankaListesii(bool secim = false)
        {
            Modul_Banka.FrmBankaListesi frm = new Modul_Banka.FrmBankaListesi();
            if (secim)
            {
                frm.Secim = secim;
                frm.ShowDialog();
            }
            else
            {
                frm.MdiParent = ANAFORM.ActiveForm;
                frm.Show();
            }

            return ANAFORM.Aktarma;
        }

        public void BankaParaTransfer(bool Ac = false, int ID = -1)
        {
            Modul_Banka.FrmParaTranser frm = new Modul_Banka.FrmParaTranser();
            if (Ac) frm.Ac(ID);
            frm.ShowDialog();
        }

        public void BankaHareketleri(bool Ac = false, int ID = -1)
        {
            Modul_Banka.FrmBankaHareketleri frm = new Modul_Banka.FrmBankaHareketleri();
            frm.MdiParent = ANAFORM.ActiveForm;
            if (Ac) frm.BankaAc(ID);
            frm.Show();
        }

   
    #endregion

    #region Çek Formları

    public void KendiCekimiz(int ıd =0, bool Ac = false)
        {
            Modul_Cek.frmKendiCekimiz frm = new Modul_Cek.frmKendiCekimiz();
            //if (Ac) ;
            frm.ShowDialog();
        }

        public void MusteriCeki(int Id= 0, bool Ac = false)
        {
            Modul_Cek.frmMusteriCeki frm =new Modul_Cek.frmMusteriCeki();
           // if (Ac) ;
            frm.ShowDialog();
        }

        public void CariyeCekCikisi()
        {
            Modul_Cek.fmrCariyeCekCikisi frm = new Modul_Cek.fmrCariyeCekCikisi();
            frm.ShowDialog();
        }
        public void BankaCekCikisi()
        {
            Modul_Cek.frmBankayaCekCikisi frm = new Modul_Cek.frmBankayaCekCikisi();
            frm.ShowDialog();
        }
        #endregion
    }
}


