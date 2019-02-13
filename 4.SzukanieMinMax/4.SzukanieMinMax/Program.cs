using System;

namespace _4.SzukanieMinMax
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5] { 4, 7, 2, 1, 12 };
            int wynik = a[0];
            int n = a.Length-1;

            for (int i = 1; i <= n; i++)
            {
                if (a[i] < wynik)
                {
                    wynik = a[i];
                }
            }

            Console.WriteLine(wynik);
            Console.ReadKey(true);
        }
    }
}
       
    

