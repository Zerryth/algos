using System;

namespace CSharpAlgos
{
    class Program
    {
        static void Main(string[] args)
        {

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
