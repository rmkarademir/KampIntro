using GameProje.Abstract;
using GameProje.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje.Concrete
{
    class GamerManager : IManagerService
    {
        List<Gamer> gamers = new List<Gamer>() { };
        public void Add(IEntity gamer)
        {
            gamers.Add((Gamer)gamer);
            Console.WriteLine("{0}, oyuncu listesine eklendi.", gamer.Name);
        }

        public void Delete(string GamerName)
        {
            foreach (var gamer in gamers)
            {
                if (gamer.Name == GamerName)
                {
                    gamers.Remove(gamer);
                    Console.WriteLine("{0} {1}, isimli oyuncu sistemden silindi.", gamer.Name, gamer.Surname);
                    break;
                }
            }
        }
        public void Update(string gamer)
        {
            foreach (var gamers in gamers)
            {
                if (gamers.Name == gamer)
                {
                    Console.WriteLine("{0} {1}, isimli oyuncu bilgileri güncellendi.",  gamers.Name,gamers.Surname);
                    break;
                }
                else
                {
                    Console.WriteLine("İsim listede bulunamadı.");
                    break;
                }
            }
        }

        public void List()
        {
            foreach (var gamer in gamers)
            {
                Console.WriteLine("Oyuncu Adı: " + gamer.Name);
                Console.WriteLine("***********");
                Console.WriteLine("Oyuncu Soyadı: " + gamer.Surname);
                Console.WriteLine("***********");
                Console.WriteLine("Oyuncu Doğum Yılı: " + gamer.BirthYear);
                Console.WriteLine("***********");
                Console.WriteLine("Oyuncu TcNo: " + gamer.SecurityNumber);
                Console.WriteLine("___________");
            }
        }
    }
}
