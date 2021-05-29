using System;
using System.Collections.Generic;

namespace CSharpAlgos
{
    /// Given a list of integers, count the ratio of:
    /// - Positive
    /// - Negative
    /// - and Zeroes
    /// in the list. Print the results.
    public class NumberRatios
    {
        public NumberRatios(List<int> arr)
        {
            Arr = arr;
        }

        public List<int> Arr { get; set; }

        public int Positives { get; set; }
        public int Negatives { get; set; }

        public int Zeroes { get; set; }
        public void PrintRatios()
        {
            CountArrElems();
            var ratios = GetRatios();

            foreach (var ratio in ratios)
            {
                Console.WriteLine($"{ratio:F6}");
            }
        }

        private void CountArrElems()
        {
            foreach (var num in Arr)
            {
                if (num > 0) Positives++;
                if (num < 0) Negatives++;
                if (num == 0) Zeroes++;
            }
        }

        private List<decimal> GetRatios()
        {
            var totalElems = (decimal)Arr.Count;
            return new List<decimal>()
            {
                Positives/totalElems,
                Negatives/totalElems,
                Zeroes/totalElems,
            };
        }
    }
}