using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.kursAdi = "C#";
            kurs1.egitmen = "Engin";
            kurs1.izlenmeOrani = 68;
            kurs1.suresi = 30;

            Kurs kurs2 = new Kurs();
            kurs2.kursAdi = "Python";
            kurs2.egitmen = "Engin";
            kurs2.izlenmeOrani = 52;
            kurs2.suresi = 45;

            Kurs kurs3 = new Kurs();
            kurs3.kursAdi = "Java";
            kurs3.egitmen = "Berkay";
            kurs3.izlenmeOrani = 48;
            kurs3.suresi = 25;

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine("Kurs Adı: " + kurs.kursAdi);
                Console.WriteLine("Eğitmen Adı: " + kurs.egitmen);
                Console.WriteLine("İzleme Oranı: " + "%" + kurs.izlenmeOrani);
                Console.WriteLine("Kurs Süresi: " + kurs.suresi + " saat");
                Console.WriteLine("********");
            }
            Console.Write("[1-10] arasında sayı giriniz :");
            int sayi = int.Parse(Console.ReadLine());
            string cevap = ""; 
            string cevap2 = "";
            cevap = sayi == 7 ? "Tebrikler doğru bildiniz" : "Yanlış cevap";
            cevap2 = sayi > 3 ? "Girilen sayı 3 ten büyüktür." : "Girilen sayı 3 ten küçüktür.";
            Console.WriteLine(cevap);
            Console.WriteLine(cevap2);
            switch (sayi)
            {
                case 1:
                case 3:
                case 5:
                    Console.WriteLine("Tek sayı");
                    break;
                case 2:
                case 4:
                case 6:
                    Console.WriteLine("Çift sayı");
                    break;
                default:
                    Console.WriteLine("Sayının karşılığı yok");
                    break;
            }
            int i = 1;
            Random rdn = new Random();
            string[] yazıTura = new string[] {"yazı", "tura"};
            while (true)
            {
                int rastgele = rdn.Next(0, 2);
                Console.Write("Tahmininizi yazınız(tura/yazı):");
                string tur = Console.ReadLine();
                if (tur == yazıTura[rastgele])
                {
                    break;
                }
                i++;
            }
            Console.WriteLine(i + ". tahmininizde buldunuz.");
            int a = 0;
            for (int x = 0; x <=50; x++)
            {
                if (x % 2 == 0)
                {
                    a++;
                }    
            }
            Console.WriteLine(a + "adet çift sayı var");
        }
    }
    class Kurs
    {
        public string kursAdi { get; set; }
        public string egitmen { get; set; }
        public int izlenmeOrani { get; set; }
        public int suresi { get; set; }
    }
}
