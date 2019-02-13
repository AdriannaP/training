using System;

namespace _5.SzukanieZadanegoElem
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[5] { 4, 7, 8, 1, 4 };
            int n = a.Length;

            for (int i = 1; i <= n; i++)
            {
                if (a[i] == 8)
                {
                    Console.WriteLine("Znalezniono element 8 pod indeksem"+i);
                }
            }
        }
    }
}
