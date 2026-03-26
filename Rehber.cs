using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Peogramlama_vize_calismalari
{
    internal class Rehber
    {
        string dosya = "rehber.txt";

        public void rehber()
        {
            bool sistemcalisiyor = true;
            Console.WriteLine("Rehber uygulamasına hoşgeldiniz");
            senkronEt();
            

            while (sistemcalisiyor)
            {
                bool menu = true;

                Console.WriteLine("\n\n1 -> Kişi Ekle\n2 -> Kişi Listesi\n3 -> Çıkış");
                Console.Write("\nYapmak istediğiniz işlemi seçiniz:");

                while (menu)
                {
                    menu = false;
                    switch (Console.ReadLine())
                    {
                        case "1":
                            Console.Write("\nAd:");
                            string ad = Console.ReadLine();
                            Console.Write("\nSoyad:");
                            string soyad = Console.ReadLine();
                            Console.Write("\nTelefon Numarası:");
                            string no = Console.ReadLine();
                            kisiEkle(ad, soyad, no);
                            break;
                        case "2":
                            kisilistesi();
                            break;
                        case "3":
                            sistemcalisiyor = false;
                            break;
                        default:
                            Console.Write("\nYanlış yazdınız tekrar deneyin:");
                            menu = true;
                            break;
                    }
                }
            }
        }

        public void kisiEkle(string ad,string soyad,string no)
        {
            string kisi = ad+":"+soyad+":"+no;
            File.AppendAllText(dosya, "\n"+kisi);
            new kisi
            {
                ad = ad,
                soyad = soyad,
                no = no
            };

        }

        public void kisilistesi()
        {
            string[] kisiler = File.ReadAllLines(dosya);
            foreach (string kisi in kisiler)
            {
                Console.WriteLine(kisi);
            }
        }

        public void senkronEt()
        {
            kisi[] kisiler = File.ReadAllLines(dosya).Select(line =>
            {
                string[] parts = line.Split(':');
                return new kisi
                {
                    ad = parts[0],
                    soyad = parts[1],
                    no = parts[2]
                };
            }).ToArray();

        }



        public class kisi
        {
            public string ad { get; set; }
            public string soyad { get; set; }
            public string no { get; set; }
        }
    }
}
