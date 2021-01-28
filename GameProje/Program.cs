using GameProje.Entities;
using GameProje.Abstract;
using GameProje.Concrete;
using System;
using System.Collections.Generic;

namespace GameProje
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Gamer> gamers = new List<Gamer>();
            IManagerService managerServiceGame = new GameManager();
            IManagerService managerServiceGamer = new GamerManager();
            ISaleService newyearsale = new NewYearSaleManager();
            ISaleService blackfridaysale = new BlackFridaySaleManager();
            IEntity gamer1 = new Gamer()
            {
                Name = "Rüstem",
                Surname = "Karademir",
                BirthYear = 1991,
                SecurityNumber = "12346567890"
            };
            IEntity gamer2 = new Gamer()
            {
                Name = "Muhammed",
                Surname = "Karademir",
                BirthYear = 1991,
                SecurityNumber = "12346567890"
            };
            IEntity game1 = new Game()
            {
                Name = "Witcher 3",
                Catagory = "Aksiyon",
                CompanyName = "Red Project",
                Price = 50
            };
            IEntity game2 = new Game()
            {
                Name = "Crysis",
                Catagory = "Aksiyon",
                CompanyName = "Crytek",
                Price = 30
            };
            managerServiceGamer.Add(gamer1);
            managerServiceGamer.Add(gamer2);
            managerServiceGame.Add(game1);
            managerServiceGame.Add(game2);
            Console.Clear();
            int xwhile = 1;
            while (xwhile == 1)
            {
                Console.WriteLine("**********MENU**********");
                Console.WriteLine("1) Oyuncu Ekle\n2) Oyuncu Sil\n3) Oyuncu Güncelle\n4) Oyuncuları Listele\n5) Oyun Ekle\n6) Oyun Sil\n7) Oyun Güncelle\n8) Oyunları Listele\n9) Kampanya Seçimi\n0) Çıkış");
                Console.WriteLine("************************");
                int secim = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                if (secim <= 9 && secim >= 0)
                {
                    switch (secim)
                    {
                        case 1:
                            Console.WriteLine("Oyuncu Adı: ");
                            string Name = Console.ReadLine();
                            Console.WriteLine("Oyuncu Soyadı: ");
                            string SurName = Console.ReadLine();
                            Console.WriteLine("Oyuncu Doğum Yılı: ");
                            int BirthYear = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Oyuncu TcNo: ");
                            string SecurityNumber = Console.ReadLine();
                            IEntity gamer3 = new Gamer()
                            {
                                Name = Name,
                                Surname = SurName,
                                BirthYear = BirthYear,
                                SecurityNumber = SecurityNumber
                            };
                            managerServiceGamer.Add(gamer3);
                            break;
                        case 2:
                            Console.WriteLine("Silmek istediğiniz oyuncunun Adını giriniz:");
                            managerServiceGamer.Delete(Console.ReadLine());
                            break;
                        case 3:
                            Console.WriteLine("Güncellemek istediğiniz oyuncunun Adını giriniz:");
                            string name = Console.ReadLine();
                            managerServiceGamer.Update(name);
                            break;
                        case 4:
                            managerServiceGamer.List();
                            break;
                        case 5:
                            Console.WriteLine("Oyun Adı: ");
                            string GameName = Console.ReadLine();
                            Console.WriteLine("Oyun Türü: ");
                            string Catagory = Console.ReadLine();
                            Console.WriteLine("Yapım Şirketi: ");
                            string CompanyName = Console.ReadLine();
                            Console.WriteLine("Oyun Fiyatı: ");
                            int Price = Convert.ToInt32(Console.ReadLine());
                            IEntity game3 = new Game()
                            {
                                Name = GameName,
                                Catagory = Catagory,
                                CompanyName = CompanyName,
                                Price = Price
                            };
                            managerServiceGame.Add(game3);
                            break;
                        case 6:
                            Console.WriteLine("Silmek istediğiniz oyunun Adını giriniz:");
                            managerServiceGame.Delete(Console.ReadLine());
                            break;
                        case 7:
                            Console.WriteLine("Güncellemek istediğiniz oyunun Adını giriniz:");
                            string Gamename = Console.ReadLine();
                            managerServiceGame.Update(Gamename);
                            break;
                        case 8:
                            managerServiceGame.List();
                            break;
                        case 9:
                            Console.WriteLine("Kampanya Menüsü");
                            Console.WriteLine("1) Yeni Yıl Kampanyası\n2) Efsane Cuma Kampanyası");
                            Console.WriteLine("---------------");
                            int secim2 = Convert.ToInt32(Console.ReadLine());
                            Console.Clear();

                            if (secim2 <= 2 && secim2 >= 1)
                            {
                                switch (secim2)
                                {
                                    case 1:
                                        managerServiceGame.List();
                                        Console.WriteLine("Yeni Yıl kampanyası uygulamak istediğiniz oyunun adını yazınız: ");
                                        string newyearsalegame = Console.ReadLine();
                                        Console.Clear();
                                        newyearsale.Sale(newyearsalegame);
                                        break;
                                    case 2:
                                        managerServiceGame.List();
                                        Console.WriteLine("Efsane Cuma kampanyası uygulamak istediğiniz oyunun adını yazınız: ");
                                        string blackfridaysalegame = Console.ReadLine();
                                        Console.Clear();
                                        newyearsale.Sale(blackfridaysalegame);
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else
                            {
                                Console.WriteLine("Hatalı giriş yaptınız.");
                            }
                            break;
                        case 0:
                            Console.WriteLine("Çıkış yapılıyor.");
                            xwhile = 0;
                            break;
                        default:
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Hatalı giriş yaptınız.");
                }
            }
        }
    }
}
