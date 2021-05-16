namespace CSharpAlgos
{
    public static class MaxSubarraySum
    {
        /// Given an array of positive integers and a number (n),
        /// calculate the maximum sum of n consecutive elements in the array.
        // Examples:
        // [1, 2, 4, 2, 8, 1, 5], 2 => 10 (because 2 + 8 = 10)
        // [1, 2, 5, 2, 8, 1, 5], 4 => 17 (2 + 5 + 2 + 8 = 17)
        // [], 4 => 0 (in other languages like JS, instead return null to indicate the sum isn't 0)
        // We'll take a sliding window approach, O(n) complexity
        public static int FindMaxSubarraySum(int[] arr, int num)
        {
            var maxSum = 0;
            var tempSum = 0;
            if (arr.Length < num) return 0;

            for (var i = 0; i < num; i++)
            {
                maxSum += arr[i];
            }

            tempSum = maxSum;
            for (var i = num; i < arr.Length; i++)
            {
                tempSum = tempSum - arr[i - num] + arr[i];
                maxSum = Program.GetMax(maxSum, tempSum);
            }

            return maxSum;
        }
    }

}
// Console.WriteLine(MaxSubarraySum.FindMaxSubarraySum(new int[] { 1, 7, 2, 11 }, 2));
