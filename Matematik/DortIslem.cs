using System;
using System.Collections.Generic;
using System.Text;

namespace Matematik
{
    class DortIslem
    {
        public void Toplama(int sayi1, int sayi2)
        {
            int toplam = sayi1 + sayi2;
            Console.WriteLine("Sonuç: " + toplam);   
        }
        public void Cıkarma(int sayi1, int sayi2)
        {
            int cıkarma = sayi1 - sayi2;
            Console.WriteLine("Sonuç: " + cıkarma);
        }
        public void Carpma(int sayi1, int sayi2)
        {
            int carpma = sayi1 * sayi2;
            Console.WriteLine("Sonuç: " + carpma);
        }
        public void Bolme(int sayi1, int sayi2)
        {
            int bolme = sayi1 / sayi2;
            Console.WriteLine("Sonuç: " + bolme);
        }
    }
}
