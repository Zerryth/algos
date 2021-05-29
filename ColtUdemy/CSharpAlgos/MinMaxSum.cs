using System;
using System.Collections.Generic;

namespace CSharpAlgos
{
    public class MinMaxSum
    {
        public void GetMinMaxSum(List<double> numbers)
        {
            numbers.Sort();
            if (numbers.Count <= 4)
            {
                double total = 0;
                foreach (var num in numbers) total += num;
                Console.WriteLine($"{total} {total}");

                return;
            }

            var min = Double.PositiveInfinity;
            var max = Double.NegativeInfinity;
            // First get the sum of 1st 4 nums
            double sum = 0;
            for (var i = 0; i < 4; i++) sum += numbers[i];

            min = sum;
            max = sum;

            // Now slide "window" of 4 elems. to the right
            var start = 0;
            var end = 3;
            while (end < numbers.Count)
            {
                if (end + 1 >= numbers.Count) break;

                end++;
                sum += numbers[end];
                sum -= numbers[start];
                start++;

                if (sum < min) min = sum;
                if (sum > max) max = sum;
            }

            Console.WriteLine($"{min} {max}");
        }
    }
}

// var minMaxSum = new MinMaxSum();
// var numbers = new List<double>() { 396285104, 573261094, 759641832, 819230764, 364801279 };
// minMaxSum.GetMinMaxSum(numbers);