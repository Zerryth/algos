namespace CSharpAlgos
{
    public static class MinSubarrayLength
    {
        /// Write a function that accepts 2 parameters:
        /// 1. an array of positive integers
        /// 2. a positive integer
        /// The function should return the minimal length of a CONTIGUOUS subarray,
        /// which when summed is >= the positive int passed in
        /// If there isn't one, return 0
        //
        // Examples:
        // [2, 3, 1, 2, 4, 3], 7 => 2 (because [4, 3] is the smallest subarray)
        // [2, 1, 6, 5, 4], 9 => 2 (because [5, 4] is the smallest subarray)
        // [3, 1, 7, 11, 2, 9, 8, 21, 62, 33, 19], 52 => 1 (because [62] is greater than 52)
        // [1, 4, 16, 22, 5, 7, 8, 9, 10], 39 => 3
        // [1, 4, 16, 22, 5, 7, 8, 9, 10], 55 => 5
        // [4, 3, 3, 8, 1, 2, 3], 11 => 2
        // [1, 4, 16, 22, 5, 7, 8, 9, 10], 95 => 0
        public static double MinSubArrLen(int[] nums, int sum)
        {
            var total = 0;
            var start = 0;
            var end = 0;
            var minLen = double.PositiveInfinity;

            var numsLength = nums.Length;
            while (HasNotReachedTheEnd(start, numsLength))
            {
                if (!IsAtLeastTargetSum(total, sum) && HasNotReachedTheEnd(end, numsLength))
                {
                    // Expand window right
                    total += nums[end];
                    end++;
                }
                else if (IsAtLeastTargetSum(total, sum))
                {
                    // shrink the window
                    // then slide window to the right (start moves up)
                    minLen = Program.GetMin(minLen, end - start);
                    total -= nums[start];
                    start++;
                }
                else
                {
                    // Total is less than sum, but we reached the end
                    break;
                }
            }

            return minLen == double.PositiveInfinity ? 0 : minLen;
        }

        private static bool IsAtLeastTargetSum(int total, int targetMinimalSum) => total >= targetMinimalSum;

        private static bool HasNotReachedTheEnd(int pointer, int endIndex) => pointer < endIndex;
    }
}