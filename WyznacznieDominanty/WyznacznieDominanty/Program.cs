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
            int n = T.Count;

            for (int i = 0; i < n; i++)
            {
                if (L.Contains(T[i]))
                {
                    int index = L.IndexOf(T[i]);
                    W[index]++;
                }
                {
                    L.Add(T[i]);
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

            for(int i = 1; i< w.Count; i++)
            {
                if(maxValue < w[i])
                {
                    maxValue = w[i];
                }
            }

            return w.IndexOf(maxValue);
        }
    }
}
