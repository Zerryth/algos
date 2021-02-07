/**
 * Given 2 strings, determine if they are permutations of one another.
 */

 // Solution 1 - Character Counting
function arePermutationsOfEachOther(str1, str2) {
    const normalizedStr1 = removeWhitespace(str1).toLowerCase();
    const normalizedStr2 = removeWhitespace(str2).toLowerCase();
    const normalizedStringLength1 = normalizedStr1.length;

    if (normalizedStringLength1 !== normalizedStr2.length) {
        return false;
    }

    if (normalizedStringLength1 == 0) {
        return true;
    }

    const characterCounts1 = getCharacterCounts(normalizedStr1);
    const characterCounts2 = getCharacterCounts(normalizedStr2);

    for (let char in characterCounts1) {
        if (characterCounts1[char] !== characterCounts2[char]) {
            return false;
        }
    }

    return true;
}

function removeWhitespace(str) {
    // \s matches any whitespace symbol
    // + match one or more of preceding token
    // g global search (find all matches instead of stopping at 1st one)
    return str.replace(/\s+/g, '');
}


function getCharacterCounts(str) {
    const characterCounts = {};
    for (let char of str) {
        if (!characterCounts[char]) {
            characterCounts[char] = 1;
        } else {
            characterCounts[char]++;
        }
    }

    return characterCounts;
}

// console.log(arePermutationsOfEachOther('cat', 'tac'));
// console.log(arePermutationsOfEachOther('bot', 'bob'));
// console.log(arePermutationsOfEachOther('', 'bunny'));
// console.log(arePermutationsOfEachOther('esper', '139a'));
// console.log(arePermutationsOfEachOther('yoodle5', '5dooley'));
// console.log(arePermutationsOfEachOther('', ''));


// Solution 2 - Sorting

function arePermutationsOfEachOther2(str1, str2) {
    const normalizedCharArr1 = removeWhitespace(str1).toLowerCase().split('').sort();
    const normalizedCharArr2 = removeWhitespace(str2).toLowerCase().split('').sort();

    if (normalizedCharArr1.length !== normalizedCharArr2.length) {
        return false;
    }

    for (let i = 0; i < normalizedCharArr1.length; i++) {
        if (normalizedCharArr1[i] !== normalizedCharArr2[i]) {
            return false;
        }
    }

    return true;
}

console.log(arePermutationsOfEachOther2('cat', 'tac'));
console.log(arePermutationsOfEachOther2('bot', 'bob'));
console.log(arePermutationsOfEachOther2('', 'bunny'));
console.log(arePermutationsOfEachOther2('esper', '139a'));
console.log(arePermutationsOfEachOther2('yoodle5', '5dooley'));
console.log(arePermutationsOfEachOther2('', ''));