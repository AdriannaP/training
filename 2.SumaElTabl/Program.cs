using System;

namespace SumaElTabl
{
    class Program
    {
       
            public static void Main()
            {
             int wynik = 0;
             int i=1;
             int[] numery = new int[4] { 7, 6, 4 ,7};
            int n = 4;

            for(i = 1; i <= n;i++)
            {
                wynik = numery[i-1]+wynik;
            }
                        
            Console.WriteLine(wynik);
            Console.ReadKey(true);
            }
    }
    
}
