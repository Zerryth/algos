using System.Collections.Generic;

namespace CSharpAlgos
{
    public class TallestCandles
    {
        public int CountTallestCandles(List<int> candles)
        {
            var totalCandles = candles.Count;
            if (totalCandles <= 1) return totalCandles;

            var tallest = candles[0];
            var count = 1;
            for (var i = 1; i < totalCandles; i++)
            {
                if (candles[i] == tallest) count++;

                if (candles[i] > tallest)
                {
                    tallest = candles[i];
                    count = 1;
                }

            }

            return count;
        }
    }
}