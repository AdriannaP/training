using System;
using System.Collections.Generic;

namespace WyznacznieDominanty
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> T = new List<int>() { 1, 4, 6, 5, 1, 1, 5, 4 };
            List<int> L = new List<int>();
            List<int> W = new List<int>();

            foreach(int number in T)
            {
                if (L.Contains(number))
                {
                    int index = L.IndexOf(number);
                    W[index]++;
                }
                {
                    L.Add(number);
                    W.Add(1);
                }
            }

            int indexOfMaxValue = IndexOfMaxValue(W);
            Console.WriteLine(T[indexOfMaxValue]);
            Console.ReadLine();
        }

        private static int IndexOfMaxValue(List<int> w)
        {
            int maxValue = w[0];

            foreach(int number in w)
            {
                if (maxValue < number)
                {
                    maxValue = number;
                }
            }

            return w.IndexOf(maxValue);
        }
    }
}
