using System;
using System.Collections.Generic;
using System.Text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace ClassDeneme
{
    class MusteriManager
    {
        Musteri[] musteriler = new Musteri[] { };
        int a = 0;
        public void Ekle(Musteri musteri,string ad, string Soyad, string DogumYeri, string Egitimi, int Yasi)
        {
            //Console.WriteLine("Müşterinin Adını giriniz: ");
            musteri.musteriAdi = ad;
            Console.WriteLine("Müşterinin Soyadını giriniz: ");
            musteri.musteriSoyadi = Console.ReadLine();
            Console.WriteLine("Müşterinin Doğum Yerini giriniz: ");
            musteri.musteriDogumYeri = Console.ReadLine();
            Console.WriteLine("Müşterinin Eğitimini giriniz: ");
            musteri.musteriEgitimi = Console.ReadLine();
            Console.WriteLine("Müşterinin Yaşını giriniz: ");
            musteri.musteriYasi = Convert.ToInt16(Console.ReadLine());
            
        }
        public void Sil()
        {

        }
        public void Listele()
        {

        }
    }
}
