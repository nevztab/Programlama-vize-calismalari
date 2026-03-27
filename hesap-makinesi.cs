using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peogramlama_vize_calismalari
{
    public class hesap_makinesi
    {
        public void hesapmakinesi()
        {
            float sayi1, sayi2;
            float sonuc = 0;
            string islem;
            bool islemgecerli = false;
            bool bolumhata = false;

            Console.WriteLine("hesap makinesine hoşgeldiniz");
            Console.WriteLine("\n\n+ -> Toplama\n- -> Çıkarma\n* -> Çarpma \n/ -> Bölme");

            Console.Write("\nİlk Sayıyı Girin: ");
            
            
            sayi1 =Convert.ToInt32(Console.ReadLine());
            Console.Write("\nİkinci Sayıyı Girin: ");
            sayi2 =Convert.ToInt32(Console.ReadLine());
            Console.Write("\nyapmak istediğiniz işlemi seçiniz: ");
            islem = Console.ReadLine();

            while (!islemgecerli)
            {
                islemgecerli = true;
                switch (islem)
                {
                    case "+":
                        sonuc = sayi1 + sayi2;
                        break;

                    case "-":
                        sonuc = sayi1 - sayi2;
                        break;

                    case "*":
                        sonuc = sayi1 * sayi2;
                        break;

                    case "/":
                        if (sayi2 == 0)
                        {
                            Console.Write("\nBölen sıfır olamaz");
                            bolumhata = true;
                        }
                        else
                        {
                            sonuc = sayi1 / sayi2;
                            
                        }
                        break;

                    default:
                        Console.Write("\nyanlış yazıon tekrar dene:");
                        islemgecerli = false;
                        islem = Console.ReadLine();
                        break;

                }
            }

            if (!bolumhata)
            {
                Console.WriteLine("sonuç: " + sonuc);
            }
        }
    }
}
