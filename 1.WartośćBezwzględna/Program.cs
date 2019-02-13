using System;

namespace WartośćBezwzględna
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj liczbę x ");
            int x = Int32.Parse(Console.ReadLine());
            if (x >= 0)
                Console.WriteLine("Wynik:" + x);
            else
                Console.WriteLine("Wynik:" + -x);
         Console.WriteLine("koniec");
            Console.ReadKey(true);
        }
    }
}
