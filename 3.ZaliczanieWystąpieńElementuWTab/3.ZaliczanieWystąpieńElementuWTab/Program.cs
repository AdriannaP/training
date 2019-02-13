using System;

namespace _3.ZaliczanieWystąpieńElementuWTab
{
    class Program
    {
        static void Main(string[] args)
        {
            int wynik = 0;
            int[] numery = new int[5] { 7, 6, 7, 7, 7 };
            int n = 5;

            for (int i = 0; i < n; i++)
            {
                if ( numery[i]== 7)
                {
                    wynik++;
                }
            }
            
            Console.WriteLine(wynik);
            Console.ReadKey(true);
        }
    }
}
       



