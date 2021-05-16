using System.Collections.Generic;

namespace CSharpAlgos
{
    public static class FindLongestSubstring
    {
        /// Given a string, find the length of the longest substring with all distinct characters.
        public static int Run(string str)
        {
            var longest = 0;
            var seen = new Dictionary<char, int>();
            var start = 0;

            for (var i = 0; i < str.Length; i++)
            {
                var letter = str[i];
                if (seen.ContainsKey(letter))
                {
                    // move start to the index right after the duplicate letter we've just seen
                    // so we can search for a new window of unique letters,
                    // that does not include the 1st occurance of the duplicated letter
                    start = Program.GetMax(start, seen[letter]);
                }

                // index - beginning of substring + 1 ( to include current in count)
                // What's longer? longest or our current window length?
                longest = Program.GetMax(longest, i - start + 1);

                // store the index of the next letter so as to not double count
                seen[letter] = i + 1;
            }

            return longest;
        }
    }
}