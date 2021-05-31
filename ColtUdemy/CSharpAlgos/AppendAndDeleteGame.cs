namespace CSharpAlgos
{
    public static class AppendAndDeleteGame
    {
        public static string AppendAndDelete(string original, string target, int k)
        {
            // iterate until the 2 strings don't match
            // whatever remaining chars from where we stopped matching to
            // the end, is how many moves we need to do, if we multiply
            // that number by 2 (deletions needed + appendages needed)
            // "happydance"
            // "happi"

            var shortest = IsShortest(target, original) ? target.Length : original.Length;

            // Find the point where both strings stop matching
            var matchUntil = -1; // 0
            for (var i = 0; i < shortest; i++)
            {
                if (original[i] != target[i]) break;

                matchUntil = i;
            }

            // chars remaining in original that didn't match target
            var deletionsNeeded = original.Length - 1 - matchUntil;
            var additionsNeeded = target.Length - 1 - matchUntil;

            // 7 - 3 => 4 - 3 => 1

            // var original = "happi";
            // var target = "happydance";
            // deletionsNeeded = 5 - 1 - 3 => 1
            // additionsNeeded = 10 - 1 - 3 => 6
            // k - (1 + 6) 
            // 10 - 7 = 3 => "No"
            // 11 - 7 = 4 => "Yes"
            // 7 - 7 = 0 => "Yes"

            // var original = "abcd"
            // var target = "abcdert"
            // deletionsNeeded = 0
            // additionsNeeded = 7 - 1 - 3 => 3
            // reaminingMoves = 10 - 7 => 3
            var remainingMoves = k - (deletionsNeeded + additionsNeeded);

            if (remainingMoves < 0) return "No";

            if (remainingMoves % 2 != 0)
            {
                // can we go to empty string in original string
                if (remainingMoves >= (matchUntil + 1) * 2) return "Yes";

                return "No";
            }
            else return "Yes";
        }

        private static bool IsShortest(string str1, string str2)
        {
            if (str1.Length < str2.Length) return true;

            return false;
        }

        private static bool HasOddNumMovesDifference(int k, int minMoves) => (k - minMoves) % 2 != 0;
    }
}