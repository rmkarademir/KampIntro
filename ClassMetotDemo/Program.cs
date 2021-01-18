using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            Random rastgele = new Random();
            int sayi1 = rastgele.Next(1, 1000);
            int sayi2 = rastgele.Next(1, 1000);
            
            Musteri musteri1 = new Musteri();
            musteri1.musteriId = sayi1;
            musteri1.musteriAdi = "Ahmet";
            musteri1.musteriSoyadi = "Yılmaz";
            musteri1.musteriDogumYeri = "Samsun";
            musteri1.musteriEgitimi = "Üniversite";
            
            Musteri musteri2 = new Musteri();
            musteri2.musteriId = sayi2;
            musteri2.musteriAdi = "Mehmet";
            musteri2.musteriSoyadi = "Yılmaz";
            musteri2.musteriDogumYeri = "Ankara";
            musteri2.musteriEgitimi = "Lise";
            
            Musteri musteri = new Musteri();

            Musteri[] musteriler = new Musteri[] { musteri, musteri1, musteri2 };

            MusteriManager manager = new MusteriManager();

            while (a == 0)
            {
                Console.WriteLine("Müşteri eklemek için : 1 e bas");
                Console.WriteLine("Müşteri silmek için : 2 ye bas");
                Console.WriteLine("Müşterileri listelemek için : 3 e bas");
                int tus = Convert.ToInt16(Console.ReadLine());
                if (tus == 1)
                {
                    Console.WriteLine("--------Müşteri Ekleme-------------");
                    manager.Ekle(musteri);
                }
                if (tus == 2)
                {
                    Console.WriteLine("--------Müşteri Silme-------------");
                    Console.WriteLine("Silmek istediğiniz müşteri Id giriniz: ");
                    int Id = Convert.ToInt16(Console.ReadLine());
                    manager.Sil(musteriler, Id);
                }
                if (tus == 3)
                {
                    Console.WriteLine("--------Müşterileri Listeleme-------------");
                    manager.Listele(musteriler);
                }
            }
            Console.ReadLine();
        }
    }
}
