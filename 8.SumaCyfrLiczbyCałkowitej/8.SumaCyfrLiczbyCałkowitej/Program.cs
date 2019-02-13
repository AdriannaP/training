using System;

namespace _8.SumaCyfrLiczbyCałkowitej
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj X");
            int x;
            x = Int32.Parse(Console.ReadLine());
            int wynik = 0;
            while(x != 0)
            {
               wynik += x%10;
               x/=10;
            }
            Console.WriteLine(wynik);
            Console.ReadKey(true);
        }
    }
}
