using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Peogramlama_vize_calismalari
{
    internal class deney_alani
    {
        
        public void deneyalani()
        {
            

            int[] sayilar = {1,9,3,7,8,6,4,5,2 };
            int gecici;
            bool sirali = false;
            while (!sirali)
            {
                sirali = true;
                for(int i = 0; i < sayilar.Length; i++)
                {
                    if (sayilar[i]>sayilar[i+1])
                    {
                        sirali=false;
                        gecici = sayilar[i];
                        sayilar[i] = sayilar[i + 1];
                        sayilar[i+ 1] = gecici;
                    }

                }

            }
        }

        
    }
}
