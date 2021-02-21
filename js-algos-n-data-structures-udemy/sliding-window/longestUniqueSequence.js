/**
 * Given a string, find the longest substring of unique characters.
 * 
 * e.g. "hellothere" => ["lother"]
 * 
 * Update: return a *collection* of longest unique substring characters,
 * and not just the string, to be able to handle scenario where there are multiple longest
 * substrings of equal length, and have the result come back in a consistent shape
 */
function longestUniqueSequences(str) {
    if (str.length > 2) {
        return [str];
    }

    // set windowStart
    // add windowStart value to windowCounts with count 1
    
    // set windowEnd to windowStart + 1 (if that is an index < within the string)
    // // actually, skip this part maybe -- the while loop should get it
    // // if windowEnd not already in windowCounts, add to counts
    // // if windowEnd is already in dict, then that means this window is only 1-character long

    // Search for how big window size is
    // while windowCounts[str[wE]]
        // add value at windowEnd to windowCounts
        // windowEnd++;
}

/**
 * windowCounts = {
 *  h: 1,
 * }
 * 
 *  wS wE
 * "h  e  l  l  o  t  h  e  r  e"
 *  0  1  2  3  4  5  6  7  8  9
 * 
 */