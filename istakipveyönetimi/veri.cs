using System.Collections.Generic;

namespace IsTakipSistemi
{
    public static class veri
    {
        public static List<string> projeListesi = new List<string>();
        public static List<string> calisanListesi = new List<string>();
        public static List<string> gorevListesi = new List<string>();

        // RASTGELE verileri yükleyecek bir fonksiyon
        public static void IlkVerileriYukle()
        {
            // Proje kayıtları
            projeListesi.Add("Proje Adı: Yazılım Geliştirme, Proje Mekanı: Ofis A, Proje Tarihi: 01.05.2025");
            projeListesi.Add("Proje Adı: Web Sitesi Tasarımı, Proje Mekanı: Ofis B, Proje Tarihi: 03.05.2025");
            projeListesi.Add("Proje Adı: Mobil Uygulama, Proje Mekanı: Salon 3, Proje Tarihi: 05.05.2025");
            projeListesi.Add("Proje Adı: Donanım Kurulumu, Proje Mekanı: Depo, Proje Tarihi: 06.05.2025");
            projeListesi.Add("Proje Adı: Veri Tabanı Yönetimi, Proje Mekanı: Salon 2, Proje Tarihi: 07.05.2025");
            projeListesi.Add("Proje Adı: Network Kurulumu, Proje Mekanı: Bina 1, Proje Tarihi: 08.05.2025");
            projeListesi.Add("Proje Adı: Güvenlik Sistemi, Proje Mekanı: Bina 2, Proje Tarihi: 09.05.2025");
            projeListesi.Add("Proje Adı: CRM Sistemi, Proje Mekanı: Salon 5, Proje Tarihi: 10.05.2025");
            projeListesi.Add("Proje Adı: Eğitim Programı, Proje Mekanı: Eğitim Salonu, Proje Tarihi: 11.05.2025");
            projeListesi.Add("Proje Adı: Bakım Onarım, Proje Mekanı: Teknik Ofis, Proje Tarihi: 12.05.2025");

            // Çalışan kayıtları
            calisanListesi.Add("Ad: Ahmet, Soyad: Yılmaz");
            calisanListesi.Add("Ad: Ayşe, Soyad: Demir");
            calisanListesi.Add("Ad: Mehmet, Soyad: Kaya");
            calisanListesi.Add("Ad: Fatma, Soyad: Şahin");
            calisanListesi.Add("Ad: Hasan, Soyad: Çelik");
            calisanListesi.Add("Ad: Emine, Soyad: Korkmaz");
            calisanListesi.Add("Ad: Yusuf, Soyad: Özdemir");
            calisanListesi.Add("Ad: Zeynep, Soyad: Aydın");
            calisanListesi.Add("Ad: Ali, Soyad: Arslan");
            calisanListesi.Add("Ad: Elif, Soyad: Koç");
        }
    }
}
