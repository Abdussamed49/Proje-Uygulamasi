using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices.WindowsRuntime;

namespace otomasyon_proje_uygulması.fonksiyonlar
{
    internal class Mesajlar
    {
        ANAFORM MesajForm=new ANAFORM();
        public void YeniKayit(string Mesaj)
        {
            MesajForm.Mesaj("YENİ KAYIT GİRİŞİ",Mesaj);
            
        }
        public DialogResult Guncelle() // BURASI NORMALDE BÖYLE DEĞİL STRİNG MESAJ YOK () BÖYLEYDİ AMA BEN GUNCELLEDİM HATA İÇİN 
        {
            return MessageBox.Show("seçili kayıt kalıcı olarak güncellenecektir\n güncelleme işlemini onaylıyor musunuz ?", "güncelleme işlemi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        }
        public DialogResult Sil()
        {
            return MessageBox.Show("seçili olan kayıt kalıcı olarak silinecektir\n  silme işlemini onaylıyor musunuz ?","silme işlemi",MessageBoxButtons.YesNo,MessageBoxIcon.Question); 
        }


        public void Guncelle(bool Guncelleme)
        {
            MesajForm.Mesaj("Kayıt Güncelleme", "Kayıt Güncellenmiştir.");
           
        }

        public void Hata(Exception Hata)
        {
            MesajForm.Mesaj("Hata Oluştu",Hata.Message);
       
        }
        public void FormAcilis(string formAdi)
        {
            MesajForm.Mesaj("", formAdi + "Formun Açıldı");
        }

        public void FormKapanis(string formAdi)
        {
            MesajForm.Mesaj("", formAdi + "Formu Kapatıldı");
        }
    }
}
