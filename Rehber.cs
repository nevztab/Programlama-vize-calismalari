// System kütüphanesi - Temel sistem işlevleri için
using System;
// System.Collections.Generic kütüphanesi - Koleksiyon türleri (List, Dictionary vb.) için
using System.Collections.Generic;
// System.Linq kütüphanesi - Veri sorgu ve işleme (Select, Where vb.) için
using System.Linq;
// System.Text kütüphanesi - Metin işleme için
using System.Text;
// System.Threading.Tasks kütüphanesi - Asenkron görevler için
using System.Threading.Tasks;
// System.IO kütüphanesi - Dosya işlemleri (okuma, yazma) için
using System.IO;

// Programın ana ad alanı (namespace) tanımlanıyor
namespace Peogramlama_vize_calismalari
{
    // Rehber (telefon rehberi) sınıfı tanımlanıyor
    internal class Rehber
    {
        // Kişilerin bilgilerinin saklanacağı dosyanın adı tanımlanıyor
        string dosya = "rehber.txt";

        // Rehber uygulamasının ana metodu - Tüm işlemleri yönetiyor
        public void rehber()
        {
            // Sistem çalışıp çalışmayacağını kontrol eden boolean değişken (başta açık)
            bool sistemcalisiyor = true;
            // Hoşgeldiniz mesajı ekrana yazdırılıyor
            Console.WriteLine("Rehber uygulamasına hoşgeldiniz");
            // Dosyadan mevcut kişileri bellekte senkronize et
            senkronEt();
            

            // Kullanıcı çıkış seçinceye kadar döngü devam ediyor
            while (sistemcalisiyor)
            {
                // Menü seçiminin geçerli olup olmadığını kontrol eden değişken
                bool menu = true;

                // Menü seçenekleri gösteriliyor
                Console.WriteLine("\n\n1 -> Kişi Ekle\n2 -> Kişi Listesi\n3 -> Çıkış");
                Console.Write("\nYapmak istediğiniz işlemi seçiniz:");

                // Geçerli bir seçim yapılana kadar döngü devam ediyor
                while (menu)
                {
                    // Menu değişkeni false yapılıyor (default olarak geçerli seçim varsayılıyor)
                    menu = false;
                    // Kullanıcı seçimi yapısına göre kontrol ediliyor
                    switch (Console.ReadLine())
                    {
                        // Seçim 1: Yeni kişi ekleme
                        case "1":
                            // Ad girilmesi isteniyor
                            Console.Write("\nAd:");
                            string ad = Console.ReadLine();
                            // Soyadı girilmesi isteniyor
                            Console.Write("\nSoyad:");
                            string soyad = Console.ReadLine();
                            // Telefon numarası girilmesi isteniyor
                            Console.Write("\nTelefon Numarası:");
                            string no = Console.ReadLine();
                            // Kişi ekleme fonksiyonu çağrılıyor
                            kisiEkle(ad, soyad, no);
                            break;
                        // Seçim 2: Kişi listesini göster
                        case "2":
                            // Kişi listesi fonksiyonu çağrılıyor
                            kisilistesi();
                            break;
                        // Seçim 3: Rehberden çıkış yap
                        case "3":
                            // Sistem çalışması durduruluyor ve ana menüye dönülüyor
                            sistemcalisiyor = false;
                            break;
                        // Tanımlanmamış seçim
                        default:
                            // Hata mesajı gösteriliyor ve menü yeniden gösterilecek
                            Console.Write("\nYanlış yazdınız tekrar deneyin:");
                            menu = true;
                            break;
                    }
                }
            }
        }

        // Yeni kişi ekleme fonksiyonu (ad, soyadı, telefon numası parametreleri alıyor)
        public void kisiEkle(string ad, string soyad, string no)
        {
            // Ad, soyadı ve telefon numarası ':' karakteri ile birleştirilerek bir string oluşturuluyor
            string kisi = ad + ":" + soyad + ":" + no;
            // Oluşturulan kişi bilgisi dosyaya yeni satır olarak ekleniyor
            File.AppendAllText(dosya, "\n" + kisi);
            // Yeni bir kişi nesnesi oluşturuluyor ve özellikleri ayarlanıyor
            new kisi
            {
                ad = ad,
                soyad = soyad,
                no = no
            };

        }

        // Dosyada kayıtlı tüm kişileri listeleyen fonksiyon
        public void kisilistesi()
        {
            // Dosyadan tüm satırlar okunuyor ve string dizisine atanıyor
            string[] kisiler = File.ReadAllLines(dosya);
            // Her kişi için döngü oluşturuluyor
            foreach (string kisi in kisiler)
            {
                // Her kişinin bilgisi ekrana yazdırılıyor
                Console.WriteLine(kisi);
            }
        }

        // Dosyadan okunan verileri kişi nesnelerine dönüştüren senkronizasyon fonksiyonu
        public void senkronEt()
        {
            // Dosadan okunan her satır işleniyor
            kisi[] kisiler = File.ReadAllLines(dosya).Select(line =>
            {
                // Her satır ':' karakterine göre parçalara ayrılıyor
                string[] parts = line.Split(':');
                // Parçalandan oluşturulan yeni kişi nesnesi döndürülüyor
                return new kisi
                {
                    ad = parts[0],       // İlk parça adı temsil ediyor
                    soyad = parts[1],    // İkinci parça soyadı temsil ediyor
                    no = parts[2]        // Üçüncü parça telefon numarasını temsil ediyor
                };
            }).ToArray();  // Sorgu sonucu dizi olarak dönüştürülüyor

        }



        // Kişi bilgilerini depolamak için kullanılan sınıf
        public class kisi
        {
            // Kişinin adı - Otomatik property (get set)
            public string ad { get; set; }
            // Kişinin soyadı - Otomatik property (get set)
            public string soyad { get; set; }
            // Kişinin telefon numarası - Otomatik property (get set)
            public string no { get; set; }
        }
    }
}
