using System;
using System.Collections.Generic;

namespace CSharpAlgos
{
    public static class HackerRankWarmup
    {
        private static readonly int _numberOfComparisons = 3;
        public static List<int> CompareTriplets(List<int> a, List<int> b)
        {
            if (a.Count != _numberOfComparisons && b.Count != _numberOfComparisons)
            {
                throw new ArgumentException("Must include 3 ints for both a and b.");
            }

            var aPoints = 0;
            var bPoints = 0;
            for (var i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i]) aPoints++;
                if (b[i] > a[i]) bPoints++;
            }

            return new List<int>() { aPoints, bPoints };
        }

        public static int DiagonalDifference(List<List<int>> arr)
        {
            // [1, 2, 3],
            // [4, 5, 6,],
            // [7, 8, 9]

            // (0,0)
            // (1, 1)
            // (2, 2)

            // (0, 2)
            // (1, 1)
            // (2, 0)
            var topLeftToBottomRightDiagonalSum = GetNegativeDiagonalSum(arr);
            var topRightToBottomLeftDiagonalSum = GetPositiveDiagonalSum(arr);
            return Math.Abs(topLeftToBottomRightDiagonalSum - topRightToBottomLeftDiagonalSum);
        }

        public static long AVeryBigSum(List<long> ar)
        {
            long sum = 0;

            foreach (var num in ar)
            {
                sum += num;
            }

            return sum;
        }

        private static int GetNegativeDiagonalSum(List<List<int>> matrix)
        {
            var sum = 0;
            for (var i = 0; i < matrix.Count; i++)
            {
                sum += matrix[i][i];
            }

            return sum;
        }

        private static int GetPositiveDiagonalSum(List<List<int>> matrix)
        {
            var sum = 0;
            var end = matrix.Count - 1;

            for (var i = 0; i < matrix.Count; i++)
            {
                sum += matrix[i][end - i];
            }

            return sum;
        }
    }
}