using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> isimler = new MyList<string>();
            Console.WriteLine("İsim giriniz: ");
            isimler.Add(Console.ReadLine());
            Console.WriteLine("İsim giriniz: ");
            isimler.Add(Console.ReadLine());
            Console.WriteLine(isimler.Length);
            foreach (var item in isimler.Items)
            {
                Console.WriteLine(item);
            }
            
        }
    }
}
