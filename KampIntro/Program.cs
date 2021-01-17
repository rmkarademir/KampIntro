using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 15000;
            double faizOranı = 1.54;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarBugun>dolarDun)
            {
                Console.WriteLine("dolar yükseldi");
            }
            else if (dolarBugun<dolarDun)
            {
                Console.WriteLine("dolar düştü");
            }
            else
            {
                Console.WriteLine("dolar aynı kaldı");    
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            Console.WriteLine(ogrenciSayisi);
        }
    }
}
