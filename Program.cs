using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peogramlama_vize_calismalari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            hesap_makinesi hesapmakinesiuygulamasi = new hesap_makinesi();
            Rehber rehberuygulamasi = new Rehber();
           
            while (true) {
                Console.Write("Hangi uygulamayı kullanmak istiyorsunuz? \n1: Rehber \n2: Hesap Makinesi\n3: Çıkış\nSeçiminiz: ");

                switch (Console.ReadLine())
                {
                    case "1":
                        rehberuygulamasi.rehber();
                        break;
                    case "2":
                        hesapmakinesiuygulamasi.hesapmakinesi();
                        break;
                    case "3":
                        Console.WriteLine("\nÇıkış yapılıyor...");
                        return;
                    default:
                        Console.WriteLine("\nGeçersiz seçim.");
                        break;
                }
            }
            
            
        }
    }
}