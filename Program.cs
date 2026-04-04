// System kütüphanesi - Temel sistem işlevleri için
using System;
// System.Collections.Generic kütüphanesi - Genel koleksiyon türleri için (List, Dictionary vb.)
using System.Collections.Generic;
// System.Linq kütüphanesi - Veri sorgu ve işleme için
using System.Linq;
// System.Text kütüphanesi - Metin işleme için
using System.Text;
// System.Threading.Tasks kütüphanesi - Asenkron görevler için
using System.Threading.Tasks;

// Programın ana ad alanı (namespace) tanımlanıyor
namespace Peogramlama_vize_calismalari
{
    // Program sınıfı tanımlanıyor (internal = sadece bu assembly içinde erişilebilir)
    internal class Program
    {
        // Ana giriş noktası - Programın başladığında çalışacak metod
        static void Main(string[] args)
        {
            // hesap_makinesi sınıfından nesne oluşturuluyor ve değişkene atanıyor
            hesap_makinesi hesapmakinesiuygulamasi = new hesap_makinesi();
            // Rehber sınıfından nesne oluşturuluyor ve değişkene atanıyor
            Rehber rehberuygulamasi = new Rehber();

            deney_alani deneyalani = new deney_alani();

            // Sonsuz döngü oluşturuluyor (kullanıcı çıkış seçinceye kadar)
            while (true) {
                // Kullanıcıya ana menüyü gösteren mesaj yazdırılıyor
                Console.Write("Hangi uygulamayı kullanmak istiyorsunuz? \n1: Rehber \n2: Hesap Makinesi\n3: Çıkış\nSeçiminiz: ");

                // Kullanıcının girişini okuyor ve yapısı kontrol ediliyor
                switch (Console.ReadLine())
                {
                    // Seçim 1: Rehber uygulaması başlatılıyor
                    case "1":
                        rehberuygulamasi.rehber();
                        break;
                    // Seçim 2: Hesap Makinesi uygulaması başlatılıyor
                    case "2":
                        hesapmakinesiuygulamasi.hesapmakinesi();
                        break;
                    // Seçim 3: Program sona erdirilecek
                    case "4":
                        deneyalani.deneyalani();
                        break;

                    case "3":
                        // Çıkış mesajı gösteriliyor
                        Console.WriteLine("\nÇıkış yapılıyor...");
                        // Main metodu sonlandırılarak program kapatılıyor
                        return;
                    
                    // Tanımlanmamış seçim girilirse
                    default:
                        // Hata mesajı gösteriliyor
                        Console.WriteLine("\nGeçersiz seçim.");
                        break;
                }
            }
            
            
        }
    }
}