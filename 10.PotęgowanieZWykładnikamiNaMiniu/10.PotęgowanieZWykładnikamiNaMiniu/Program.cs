using System;

namespace _11.PotęgowanieZWykładnikamiNaMiniu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("POdaj X");
            float x = Int32.Parse(Console.ReadLine());
            Console.WriteLine("POdaj y");
            float y = Int32.Parse(Console.ReadLine());
            float wynik = 1;

            if (y > 0)
            {
                while (y > 0)
                {
                    wynik = wynik * x;
                    y--;
                }
            }
            else if(y<0)
            {
                while (y < 0)
                {
                    wynik *= x;
                    y++;
                }
                wynik = 1 / wynik;
            }
            
            //wynik = 1/(wynik);
            Console.WriteLine(wynik);
            Console.ReadKey(true);
        }
    }
}
