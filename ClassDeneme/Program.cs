using System;
using System.Collections.Generic;

namespace ClassDeneme
{
    class Program
    {
        static void Main(string[] args)
        {
            int tus = 0;
            string ad = "";
            string Soyad = "";
            string DogumYeri = "";
            string Egitimi = "";
            int Yasi = 0;
            Console.WriteLine("seçiniz: ");
            tus = Convert.ToInt16(Console.ReadLine());
            Musteri musteri1 = new Musteri();
            musteri1.musteriId = 1;
            musteri1.musteriAdi = "Ahmet";
            musteri1.musteriSoyadi = "Yılmaz";
            musteri1.musteriDogumYeri = "Samsun";
            musteri1.musteriEgitimi = "Üniversite";
            musteri1.musteriYasi = 30;

            Musteri musteri2 = new Musteri();
            musteri2.musteriId = 2;
            musteri2.musteriAdi = "Mehmet";
            musteri2.musteriSoyadi = "Yılmaz";
            musteri2.musteriDogumYeri = "Ankara";
            musteri2.musteriEgitimi = "Lise";
            musteri2.musteriYasi = 22;

            Musteri musteri = new Musteri();
            
            Musteri[] musteriler = new Musteri[] {musteri, musteri1, musteri2 };
            //List <Musteri> musteriler2 = new List <Musteri>();
            //musteriler2.Add(musteri);
            //musteriler2.Add(musteri2);
            //musteriler2.Add(musteri1);
            //Musteri [] musterile = musteriler2.ToArray();
            MusteriManager manager = new MusteriManager();
            if (tus == 1)
            {
                Console.WriteLine("Müşterinin Adını giriniz222: ");
                ad = Console.ReadLine();
                Console.WriteLine("Müşterinin Soyadını giriniz: ");
                Soyad = Console.ReadLine();
                Console.WriteLine("Müşterinin Doğum Yerini giriniz: ");
                DogumYeri = Console.ReadLine();
                Console.WriteLine("Müşterinin Eğitimini giriniz: ");
                Egitimi = Console.ReadLine();
                Console.WriteLine("Müşterinin Yaşını giriniz: ");
                Yasi = Convert.ToInt16(Console.ReadLine());
                manager.Ekle(musteri,ad, Soyad, DogumYeri, Egitimi, Yasi);
                
            }
            foreach (var mus in musteriler)
            {
                Console.WriteLine(mus.musteriAdi);
            }
            //Console.WriteLine(musteri3.musteriAdi);


        }
        //class MusteriManager
        //{
        //    public void Ekle(Musteri musteri)
        //    {
        //        Console.WriteLine("Müşterinin Adını giriniz: ");
        //        musteri.musteriAdi = Console.ReadLine();
        //        Console.WriteLine("Müşterinin Soyadını giriniz: ");
        //        musteri.musteriSoyadi = Console.ReadLine();
        //        Console.WriteLine("Müşterinin Doğum Yerini giriniz: ");
        //        musteri.musteriDogumYeri = Console.ReadLine();
        //        Console.WriteLine("Müşterinin Eğitimini giriniz: ");
        //        musteri.musteriEgitimi = Console.ReadLine();
        //        Console.WriteLine("Müşterinin Yaşını giriniz: ");
        //        musteri.musteriYasi = Convert.ToInt16(Console.ReadLine());
        //    }
        //}
    }
}
