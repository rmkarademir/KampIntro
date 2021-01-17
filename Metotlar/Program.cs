using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adı = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";

            Urun urun2 = new Urun();
            urun2.Adı = "Karpuz";
            urun2.Fiyati = 25;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] {urun1, urun2};

            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürün Adı: " + urun.Adı);
                Console.WriteLine("Ürün Fiyatı: " + urun.Fiyati);
                Console.WriteLine("Ürün Açıklaması: " + urun.Aciklama);
                Console.WriteLine("-------------");
            }

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

        }
    }
}
