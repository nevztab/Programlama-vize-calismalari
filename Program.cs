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
            hesapmakinesiuygulamasi.hesapmakinesi();
            Console.ReadLine();
        }
    }
}