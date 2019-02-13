using System;

namespace _12.ŚrdeniaArytmertyczna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj n");
            float n = Int32.Parse(Console.ReadLine());
            float wynik = 0;
            int i =1;

            while(i <= n)
            {
                Console.WriteLine("podaj liczbę a");
                int a = Int32.Parse(Console.ReadLine());
                wynik = wynik + a;
                i++;
            }
           
            wynik = wynik / n;
            Console.WriteLine(wynik);
            Console.ReadKey(true);
        }
    }
}
