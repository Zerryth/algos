function isPalindromePermutation(str) {
    const normalizedStr = removeWhiteSpace(str).toLowerCase();
    if (normalizedStr.length <= 1) {
        return true;
    }

    const charCounts = getCharCounts(normalizedStr);

    if (hasEvenNumOfChars(normalizedStr)) {
        return isValidEvenCharacteredPalindrome(charCounts);
    }

    return isValidOddCharacteredPalindrome(charCounts);
}

function getCharCounts(str) {
    const charCounts = {};
    for (let char of str) {
        if (!charCounts[char]) {
            charCounts[char] = 1;
        } else {
            charCounts[char]++;
        }
    }

    return charCounts;
}

function hasEvenNumOfChars(str) {
    return str.length % 2 == 0;
}

function isValidEvenCharacteredPalindrome(charCounts) {
    for (let char in charCounts) {
        if (charCounts[char] % 2 !== 0) {
            return false;
        }
    }

    return true;
}

function isValidOddCharacteredPalindrome(charCounts) {
    let numOfOdds = 0;
    for (let char in charCounts) {
        if (charCounts[char] % 2 === 1) {
            numOfOdds++;
        }
    }

    return numOfOdds === 1;
}

function removeWhiteSpace(str) {
    return str.replace(/\s+/g, '');
}

console.log(isPalindromePermutation('poop'));
console.log(isPalindromePermutation('bob'));
console.log(isPalindromePermutation('taco cat'));
console.log(isPalindromePermutation(''));
console.log(isPalindromePermutation(' '));
console.log(isPalindromePermutation('a'));
console.log(isPalindromePermutation('bubble'));
console.log(isPalindromePermutation('no go'));
console.log(isPalindromePermutation('meet'));
