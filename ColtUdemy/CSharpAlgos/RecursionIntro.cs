using System;
using System.Linq;
using System.Numerics;
using System.Text;

namespace CSharpAlgos
{
    public static class RecursionIntro
    {
        public static int SumRange(int num)
        {
            if (num <= 1) return num;
            return num + SumRange(num - 1);
        }

        public static int Factorial(int num)
        {
            if (num <= 1)
            {
                return 1;
            }

            return num * Factorial(num - 1);
        }

        public static BigInteger BigFactorial(int num)
        {
            if (num <= 1) return 1;

            return num * BigFactorial(num - 1);
        }

        // 2**3 => 2 * 2**2 => 2 * (2 * 2*1)
        public static int PositivePower(int baseNum, int exponent)
        {
            if (exponent == 0)
            {
                return 1;
            }

            if (exponent == 1)
            {
                return baseNum;
            }

            return baseNum * PositivePower(baseNum, exponent - 1);
        }

        public static int ProductOfArray(int[] arr)
        {
            if (arr.Length == 0)
            {
                return 0;
            }

            if (arr.Length == 1)
            {
                return arr[0];
            }

            return arr[0] * ProductOfArray(arr.Skip(1).ToArray());
        }

        public static int Fib(int num)
        {
            if (num <= 1)
            {
                return num;
            }

            return Fib(num - 1) + Fib(num - 2);
        }

        public static string RecursiveReverse(string str)
        {
            var charsReversed = new StringBuilder();

            void AddLastCharAndSliceStr(string subString)
            {
                if (subString.Length == 0) return;

                charsReversed.Append(subString.Last());

                var slicedChars = subString.Take(subString.Length - 1).ToArray();
                AddLastCharAndSliceStr(new string(slicedChars));

                return;
            }
            AddLastCharAndSliceStr(str);

            return charsReversed.ToString();
        }
    }
}