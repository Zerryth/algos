/**
 * Given 2 strings, check if they are at most only 1 edit away.
 */

function areOneOrLessAway(str1, str2) {
    if (Math.abs(str1.length - str2.length) > 1) {
        return false;
    }

    if (str1.length === 0 && str2.length === 0) {
        return true;
    }

    const charCounts1 = getCharCounts(str1);
    const charCounts2 = getCharCounts(str2);

    if (!haveFewerThanOneDifferentNumOfKeys(charCounts1, charCounts2)) {
        return false;
    }

    const { dictWithMoreKeys, otherDict } = identifyDictWithMoreKeys(charCounts1, charCounts2);

    return hasFewerThanTwoDifferences(dictWithMoreKeys, otherDict);
}

function getCharCounts(str) {
    const charCounts = {};

    if (str.length > 0) {
        for (let char of str) {
            if (!charCounts[char]) {
                charCounts[char] = 1;
            } else {
                charCounts[char]++;
            }
        }
    }

    return charCounts;
}

function haveFewerThanOneDifferentNumOfKeys(obj1, obj2) {
    return Math.abs(Object.keys(obj1).length - Object.keys(obj2).length) <= 1;
}

function identifyDictWithMoreKeys(obj1, obj2) {
    let dictWithMoreKeys;
    let otherDict;
    if (Object.keys(obj1).length >= Object.keys(obj2).length) {
        dictWithMoreKeys = obj1;
        otherDict = obj2;
    } else {
        dictWithMoreKeys = obj2;
        otherDict = obj1;
    }

    return { dictWithMoreKeys: dictWithMoreKeys, otherDict: otherDict }
}

function hasFewerThanTwoDifferences(obj1, obj2) {
    let differences = 0;
    for (let key in obj1) {
        if (obj1[key] !== obj2[key]) {
            differences++;
        }

        if (differences >= 2) {
            return false;
        }
    }

    return true;
}

console.log('pale, ple', areOneOrLessAway('pale', 'ple'));
console.log('pales, pale', areOneOrLessAway('pales', 'pale'));
console.log('pale, bale', areOneOrLessAway('pale', 'bale'));
console.log('pale, bake', areOneOrLessAway('pale', 'bake'));
console.log('"", ""', areOneOrLessAway('', ''));
console.log('polliwag, ""', areOneOrLessAway('polliwag', ''));
