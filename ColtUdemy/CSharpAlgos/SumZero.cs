namespace CSharpAlgos
{
    public static class SumZero
    {
        /// <summary>
        /// Given an array of sorted integers, return a pair of numbers that when summed equal 0.
        /// </summary>
        // Have 2 pointers at each end of the array
        // Add the values at each pointers together, see if they sum to 0
        // If sum is negative, increment left pointer up by 1 (try to make sum less negative)
        // If sum is positive, decrement right pointer down by 1 (make sum less positive)
        public static int[] FindSumZeroPair(int[] arr)
        {
            var left = 0;
            var right = arr.Length - 1;
            while (left < right)
            {
                var sum = arr[left] + arr[right];
                if (sum == 0)
                {
                    return new int[2] { arr[left], arr[right] };
                }
                else if (sum > 0)
                {
                    right--;
                }
                else
                {
                    left++;
                }
            }

            return new int[0];
        }
    }
}

// var sumZeroPair = SumZero.FindSumZeroPair(new int[9] { -4, -3, -2, -1, 0, 1, 2, 3, 10 });
