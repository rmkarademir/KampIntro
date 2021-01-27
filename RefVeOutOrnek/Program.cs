using System;

namespace RefVeOutOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            int yas = 0;
            double boy = 180;
            double kilo;
            Console.WriteLine("Yaş");
            yas = Convert.ToInt16(Console.ReadLine());
            var Index = VucutKitleIndex(ref boy, out kilo);
            Console.WriteLine("Yaşınız " + yas + " boyunuz " + boy + "cm kilonuz " + kilo + "kg vücut kitle endeksiniz " + Index);
            if (yas >= 19 && yas <= 24)
            {
                if (Index >= 19 & Index <= 24)
                {
                    Console.WriteLine("Vücut kitle endeksiniz ideal.");
                }
                else
                {
                    Console.WriteLine("Vücut kitle endeksiniz ideal değil!!");
                }
            }
            if (yas >= 25 && yas <= 34)
            {
                if (Index >= 20 & Index <= 25)
                {
                    Console.WriteLine("Vücut kitle endeksiniz ideal.");
                }
                else
                {
                    Console.WriteLine("Vücut kitle endeksiniz ideal değil!!");
                }
            }
            if (yas >= 35 && yas <= 44)
            {
                if (Index >= 21 & Index <= 26)
                {
                    Console.WriteLine("Vücut kitle endeksiniz ideal.");
                }
                else
                {
                    Console.WriteLine("Vücut kitle endeksiniz ideal değil!!");
                }
            }
            if (yas >= 45 && yas <= 54)
            {
                if (Index >= 22 & Index <= 27)
                {
                    Console.WriteLine("Vücut kitle endeksiniz ideal.");
                }
                else
                {
                    Console.WriteLine("Vücut kitle endeksiniz ideal değil!!");
                }
            }
            if (yas >= 55)
            {
                if (Index >= 23 & Index <= 28)
                {
                    Console.WriteLine("Vücut kitle endeksiniz ideal.");
                }
                else
                {
                    Console.WriteLine("Vücut kitle endeksiniz ideal değil!!");
                }
            }
        }
        static double VucutKitleIndex(ref double boy, out double kilo)
        {
            Console.WriteLine("boy");
            boy = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("kilo");
            kilo = Convert.ToDouble(Console.ReadLine());
            return kilo / ((boy / 100) * (boy / 100));
        }
    }
}
