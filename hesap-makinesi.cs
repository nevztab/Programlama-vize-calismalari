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

// Programın ana ad alanı (namespace) tanımlanıyor
namespace Peogramlama_vize_calismalari
{
    // Hesap makinesi sınıfı tanımlanıyor (public = tüm sınıflardan erişilebilir)
    public class hesap_makinesi
    {
        // Hesap makinesi uygulamasının ana metodu
        public void hesapmakinesi()
        {
            // İlk sayı değişkeni (float = ondalıklı sayı)
            float sayi1, sayi2;
            // İşlem sonucunu tutacak değişken (başlangıçta 0)
            float sonuc = 0;
            // Yapılacak matematiksel işlemi tutacak değişken (string = metin)
            string islem;
            // İşlemin geçerli olup olmadığını kontrol eden boolean değişken
            bool islemgecerli = false;
            // Bölme işleminde hata oluşup oluşmadığını kontrol eden boolean değişken
            bool bolumhata = false;

            // Hoşgeldiniz mesajı ekrana yazdırılıyor
            Console.WriteLine("hesap makinesine hoşgeldiniz");
            // Yapılabilecek işlemleri gösteren menü yazdırılıyor
            Console.WriteLine("\n\n+ -> Toplama\n- -> Çıkarma\n* -> Çarpma \n/ -> Bölme");

            // Kullanıcıdan ilk sayıyı girmesi isteniyor
            Console.Write("\nİlk Sayıyı Girin: ");
            
            // Konsola girilen değer int tipine dönüştürülerek sayi1 değişkenine atanıyor
            sayi1 = Convert.ToInt32(Console.ReadLine());
            // Kullanıcıdan ikinci sayıyı girmesi isteniyor
            Console.Write("\nİkinci Sayıyı Girin: ");
            // Konsola girilen değer int tipine dönüştürülerek sayi2 değişkenine atanıyor
            sayi2 = Convert.ToInt32(Console.ReadLine());
            // Kullanıcıdan yapmak istediği işlemi seçmesi isteniyor
            Console.Write("\nyapmak istediğiniz işlemi seçiniz: ");
            // Kullanıcının girdiği işlem değişkene atanıyor
            islem = Console.ReadLine();

            // İşlem geçerli değilse döngü devam ediyor
            while (!islemgecerli)
            {
                // İşlem geçerli olarak kabul ediliyor (default)
                islemgecerli = true;
                // Girilen işlem başlık yapısında kontrol ediliyor
                switch (islem)
                {
                    // İşlem '+' ise (Toplama)
                    case "+":
                        // İki sayı toplanıyor ve sonuca atanıyor
                        sonuc = sayi1 + sayi2;
                        break;

                    // İşlem '-' ise (Çıkarma)
                    case "-":
                        // İkinci sayı birinci sayıdan çıkartılıyor
                        sonuc = sayi1 - sayi2;
                        break;

                    // İşlem '*' ise (Çarpma)
                    case "*":
                        // İki sayı çarpılıyor
                        sonuc = sayi1 * sayi2;
                        break;

                    // İşlem '/' ise (Bölme)
                    case "/":
                        // Bölende sıfır olup olmadığı kontrol ediliyor
                        if (sayi2 == 0)
                        {
                            // Bölen 0 olamaz hata mesajı gösteriliyor
                            Console.Write("\nBölen sıfır olamaz");
                            // Bölme hata bayrak true yapılıyor
                            bolumhata = true;
                        }
                        // Bölen sıfırdan farklı ise
                        else
                        {
                            // Normal bölme işlemi yapılıyor
                            sonuc = sayi1 / sayi2;
                            
                        }
                        break;

                    // Tanımlanmamış işlem seçilirse
                    default:
                        // Hata mesajı gösteriliyor
                        Console.Write("\nyanlış yazıon tekrar dene:");
                        // İşlem geçersiz olarak işaretleniyor (döngü devam edecek)
                        islemgecerli = false;
                        // Kullanıcıdan yeniden işlem girmesi isteniyor
                        islem = Console.ReadLine();
                        break;

                }
            }

            // Bölme hatası oluşmadıysa (hata bayrak false ise)
            if (!bolumhata)
            {
                // Hesaplanan sonuç ekrana yazdırılıyor
                Console.WriteLine("sonuç: " + sonuc);
            }
        }
    }
}
