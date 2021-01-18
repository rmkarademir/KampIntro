using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Random rastgele = new Random();
            int sayi = rastgele.Next(1, 1000);
            musteri.musteriId = sayi;
            Console.WriteLine("Müşterinin Adını giriniz: ");
            musteri.musteriAdi = Console.ReadLine();
            Console.WriteLine("Müşterinin Soyadını giriniz: ");
            musteri.musteriSoyadi = Console.ReadLine();
            Console.WriteLine("Müşterinin Doğum Yerini giriniz: ");
            musteri.musteriDogumYeri = Console.ReadLine();
            Console.WriteLine("Müşterinin Eğitimini giriniz: ");
            musteri.musteriEgitimi = Console.ReadLine();
            Console.WriteLine("Yeni müşteri eklendi."); 
        }
        public void Sil(Musteri[] musteriler,int Id)
        {
            foreach (var musteri in musteriler)
            {
                if (musteri.musteriId == Id)
                {
                    Console.WriteLine(musteri.musteriAdi + " " + musteri.musteriSoyadi + " isimli müşteri silindi!");
                    break;
                }
            }
            Console.WriteLine("Girilen Id bulunamadı!");
        }
        public void Listele(Musteri[] musteriler)
        {
            foreach (var musteri in musteriler)
            {
                if (musteri.musteriId != 0)
                {
                    Console.WriteLine("Müşteri Id: " + musteri.musteriId);
                    Console.WriteLine("Müşteri Adı: " + musteri.musteriAdi);
                    Console.WriteLine("Müşteri Soyadı: " + musteri.musteriSoyadi);
                    Console.WriteLine("Müşteri Doğum Yeri: " + musteri.musteriDogumYeri);
                    Console.WriteLine("Müşteri Eğitimi: " + musteri.musteriEgitimi);
                    Console.WriteLine("-----------------");
                }
                
            }
        }
    }
}
