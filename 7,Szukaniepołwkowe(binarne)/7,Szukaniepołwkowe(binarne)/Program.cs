using System;

namespace _7_Szukaniepołwkowe_binarne_
{
    class Program
    {
        static void Main(string[] args)
        {
            int l = 1;
            int p = 5;
            int[] a = new int [5] { 4,6,8,3,1};

            if (l > p)
            {
                Console.WriteLine("Nieznaleznione elemntu o wartościu x");
            }
            else
            {
                int s = (l + p)/2;
                if (a[s] == 3)
                {
                    l = s + 1;
                }
                else
                {
                    p = s - 1;
                }
            }
            Console.WriteLine("Koniec");
            Console.ReadKey(true);
        }
    }
}
