using System;

namespace _10.Potęgowanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj X");
            int x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Podaj Y");
            int y = Int32.Parse(Console.ReadLine());
            int wynik = 1;

            while (y > 0)
            {
                wynik = wynik * x;
                y--;
             
            }
           
            Console.WriteLine(wynik);
            Console.ReadKey(true);
        }


    }
}
