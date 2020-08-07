/**
 * Replace all spaces in a string with '%20'
 */

function urlify(str) {
    let urlifiedStr = '';

    for (let i = 0; i < str.length; i++) {
        if (str[i] == ' ') {
            urlifiedStr += '%20';
        } else {
            urlifiedStr += str[i];
        }
    }

    return urlifiedStr;
}

console.log(urlify('Frolic with the unicorns!'));
console.log(urlify('Ha ha.'));
console.log(urlify(' '));
console.log(urlify(''));
console.log(urlify('   '));