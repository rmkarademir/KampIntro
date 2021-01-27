using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> isimler = new List<string> {"Rüstem","Muhammed" };

            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            isimler.Add("Karademir");
            Console.WriteLine(isimler[2]);
        }
    }
}
