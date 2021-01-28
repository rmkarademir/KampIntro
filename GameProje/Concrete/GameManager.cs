using GameProje.Abstract;
using GameProje.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje.Concrete
{
    public class GameManager : IManagerService
    {
        List<Game> games = new List<Game>() { };
        public void Add(IEntity game)
        {
            games.Add((Game)game);
            Console.WriteLine("{0}, oyun listesine eklendi.", game.Name);
        }

        public void Delete(string GameName)
        {
            foreach (var game in games)
            {
                if (game.Name == GameName)
                {
                    games.Remove(game);
                    Console.WriteLine("{0}, oyun listesinden silindi.", game.Name);
                    break;
                }

                else
                {
                    Console.WriteLine("Oyun listede bulunamadı.");
                    break;
                }
            }
        }
        public void Update(string game)
        {
            foreach (var games in games)
            {
                if (games.Name == game)
                {
                    Console.WriteLine("{0} oyun bilgileri güncellendi.", games.Name);
                    break;
                }
            }
        }

        public void List()
        {
            foreach (var game in games)
            {
                Console.WriteLine("Oyun Adı: " + game.Name);
                Console.WriteLine("***********");
                Console.WriteLine("Oyun Türü: " + game.Catagory);
                Console.WriteLine("***********");
                Console.WriteLine("Yapım Şirketi: " + game.CompanyName);
                Console.WriteLine("***********");
                Console.WriteLine("Oyun Fiyatı: " + game.Price);
                Console.WriteLine("___________");
            }
        }
    }
}
