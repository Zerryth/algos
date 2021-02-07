/**
 * Given 2 strings, write a function to determine if
 * the 2nd string is an anagram of the 1st.
 * 
 * An anagram is a word, phrase, or name formed by rearranging the letters of another,
 * such as cinema, formed from iceman
 * 
 * Note: in this variation, we count space as a character to consider
 * "mew two" !== "mewtwo"
 */
// O(n)
function areAnagrams2(str1, str2) {
    if (str1.length !== str2.length) {
        return false;
    }

    if (str1.length === 0) {
        return true;
    }

    let counts1 = getFrequencyCounts(str1);
    let counts2 = getFrequencyCounts(str2);

    for (let key in counts1) {
        if (counts1[key] !== counts2[key]) {
            return false;
        }
    }

    return true;
}

function getFrequencyCounts(str) {
    let counts = {};
    for (let char of str) {
        counts[char] = ++counts[char] || 1;
    }

    return counts;
}

// console.log(areAnagrams('cinema', 'iceman'));
// console.log(areAnagrams('cinema', 'icemano'));
// console.log(areAnagrams('bthha40 5', '5h0h4 bat'));
// console.log(areAnagrams('cccaaatt!', 't!tacacac'));
// console.log(areAnagrams('', ''));
// console.log(areAnagrams('aaz', 'zza'));

// Solution 2 -- only count the frequency of 1 array
function areAnagrams2(str1, str2) {
    if (str1.length !== str2.length) {
        return false;
    }

    if (str1.length === 0) {
        return true;
    }

    let counts1 = getFrequencyCounts(str1);

    // for (let i = 0; i < str2.length; i++) {
    for (let letter of str2) {
        if (!counts1[letter]) {
            return false;
        } else {
            counts1[letter] -= 1;
        }
    }

    return true;
}

console.log(areAnagrams2('cinema', 'iceman'));
console.log(areAnagrams2('cinema', 'icemano'));
console.log(areAnagrams2('bthha40 5', '5h0h4 bat'));
console.log(areAnagrams2('cccaaatt!', 't!tacacac'));
console.log(areAnagrams2('', ''));
console.log(areAnagrams2('aaz', 'zza'));

// Solution 3
// sort each array
// check if arr1[i] == arr2[i]
