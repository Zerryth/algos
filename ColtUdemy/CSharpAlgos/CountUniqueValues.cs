namespace CSharpAlgos
{
    public static class CountUniqueValues
    {
        /// <summary>
        /// Count the number of unique values in a given sorted integer array.
        /// This means the number of different values that exist in the array, not that the values themselves only need to occurr once.
        /// </summary>
        // Examples:
        // [1, 1, 1, 1, 2] -> 2
        // [1, 2, 3, 4, 4, 4, 7, 7, 12, 12, 13] -> 7
        // [] -> 0
        // [-2, -1, -1, 0, 1] -> 4
        // 
        // Note: instead of storing the unique values in a separate data structure,
        // We are going to alter a the given array
        // If one does not want to alter the array, simply store the unique values in a new list
        public static int CountUniqueVals(int[] arr)
        {
            if (arr.Length <= 1)
            {
                return arr.Length;
            }

            var uniqueEnd = 0;
            var checker = 1;
            var count = 1;

            while (checker <= arr.Length - 1)
            {
                while (arr[uniqueEnd] == arr[checker])
                {
                    checker++;
                }

                count++;
                uniqueEnd = checker;
                checker++;
            }

            return count;
        }
    }
}

// Console.WriteLine(CountUniqueValues.CountUniqueVals(new int[] { 1, 2, 3, 4, 4, 4, 7, 7, 12, 12, 13 }));
