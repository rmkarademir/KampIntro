using GameProje.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje.Concrete
{
    class BlackFridaySaleManager : ISaleService
    {
        public void Sale(string game)
        {
            Console.WriteLine(game + " oyununa Kara Cuma indirimi uygulandı.");
        }
    }
}
