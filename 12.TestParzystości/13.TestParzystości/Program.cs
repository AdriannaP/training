using System;

namespace _13.TestParzystości
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("podaj liczbę");
            int a = Int32.Parse(Console.ReadLine());
            if (a%2==0)
            {
                Console.WriteLine("Liczba jest parzysta");
            }
            else
                Console.WriteLine("Liczba jest nie parzysta");

            Console.ReadKey(true);
        }
    }
}
