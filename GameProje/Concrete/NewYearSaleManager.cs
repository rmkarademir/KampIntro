using GameProje.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProje.Entities
{
    class NewYearSaleManager : ISaleService
    {
        public void Sale(string game)
        {
            Console.WriteLine(game + " oyununa Yeni Yıl indirimi uygulandı.");
        }
    }
}
