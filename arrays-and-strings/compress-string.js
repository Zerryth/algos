/**
 * Given a string, return a "compressed string".
 * The compressed string should have counts of each characters.
 * 
 * However, if the original string is shorter than the compressed string,
 * then return the original string.
 * 
 * oocrrrrrooo -> o2c1r5o3
 */
function compressString(str) {
    const originalStringLength = str.length;
    if (originalStringLength <= 1) {
        return str;
    }

    let compressedStr = '';
    let countingChar = str[0];
    let count = 1;
    let lastIdx = originalStringLength - 1;

    for (let i = 1; i <= lastIdx; i++) {
        let currentChar = str[i];
        if (i === lastIdx) {
            if (currentChar === countingChar) {
                count++;
                compressedStr += countingChar + count;

            } else {
                compressedStr += countingChar + count + currentChar + '1';
            }
            
            return compressedStr.length < originalStringLength ? compressedStr : str;
        }

        if (currentChar === countingChar) {
            count++;
        } else {
            compressedStr += countingChar + count;
            countingChar = currentChar;
            count = 1;
        }
    }
}

console.log('oocrrrrrooo', compressString('oocrrrrrooo'));
console.log('a', compressString('a'));
console.log('', compressString(''));
console.log('abcd', compressString('abcd'));
console.log('abcdd', compressString('abcdd'));
console.log('aaaaa', compressString('aaaaa'));
console.log('aaaaab', compressString('aaaaab'));