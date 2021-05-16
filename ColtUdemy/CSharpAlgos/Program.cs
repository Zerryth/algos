using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpAlgos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(RecursionIntro.RecursiveReverse("hel"));
            // Console.WriteLine("ube".Take(0).ToString());
        }

        internal static double GetMin(double a, double b)
        {
            if (b < a)
            {
                return b;
            }

            return a;
        }

        internal static int GetMax(int a, int b)
        {
            if (b > a)
            {
                return b;
            }

            return a;
        }
    }
}
