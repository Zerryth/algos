/**
 * Determine if a string has all unique characters.
 * What if you can't use another data structure?
 * 
 * I'm going to assume we don't count spaces, and that it is case-sensitive.
 * If it is not case-sensitive, just go ahead and .toLowerCase() the string parameter.
 */
function isUnique(str) {
    const charCounts = { };

    if (str.length <= 1) {
        return true;
    }

    // can add another short-circuit check to see if string's length is
    // greater than the alphabet (ask if it's ASCII or unicode char 1st though)

    for (let char of str) {
        if (!charCounts[char]) {
            charCounts[char] = 1;
        } else {
            return false;
        }
    }

    return true;
}

console.log('hippo', isUnique('hippo'));
console.log('No one', isUnique('No one'));
console.log('No', isUnique('No'));
console.log('', isUnique(''));
console.log('bib', isUnique('bib'));
console.log('Bob', isUnique('Bob'));
console.log('a', isUnique('a'));
console.log('abcdefghijkl', isUnique_noAdditionDataStructure('abcdefghijkl'));


function isUnique_noAdditionDataStructure(str) {
    if (str.length <= 1) {
        return true;
    }

    for (let i = 0; i <= str.length-2; i++) {
        for (let j = i + 1; j <= str.length-1; j++) {
            if (areNotSpaces(str[i], str[j]) && str[i] === str[j]) {
                return false;
            }
        }
    }
    return true;
}

function areNotSpaces(char1, char2) {
    return char1 !== ' ' && char2 !== ' ';
}

// console.log("hippo", isUnique_noAdditionDataStructure("hippo"));
// console.log("No one", isUnique_noAdditionDataStructure("No one"));
// console.log("No", isUnique_noAdditionDataStructure("No"));
// console.log("", isUnique_noAdditionDataStructure(""));
// console.log("bib", isUnique_noAdditionDataStructure("bib"));
// console.log("Bob", isUnique_noAdditionDataStructure("Bob"));
// console.log('a', isUnique_noAdditionDataStructure('a'));
// console.log('abcdefghijkl', isUnique_noAdditionDataStructure('abcdefghijkl'));