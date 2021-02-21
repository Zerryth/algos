function countChars(str) {
    const counts = {};
    for (let char of str) {
        char = char.toLowerCase();
        if(/[a-z0-9]/.test(char)) {
            counts[char] = ++counts[char] || 1;
        }
    }

    return counts;
}

// console.log(countChars("Why, 'ello there, good chum."));

function countChars2(str) {
    const counts = {};
    for (let char of str) {
        char = char.toLowerCase();
        if(isAlphanumeric(char)) {
            counts[char] = ++counts[char] || 1;
        }
    }

    return counts;
}

// 55% better performance than RegEx when testing in Chrome + Mac
function isAlphanumeric(char) {
    let code = char.charCodeAt(0);
    if ( !(code > 47 && code < 58) // numeric (0-9)
        && !(code > 64 && code < 92) // upper alpha (A-Z)
        && !(code > 96 && code < 123) // lower alpha (a-z)
    ) {
        return false;
    }
    return true;
}

console.log(isAlphanumeric(' '));
