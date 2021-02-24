/**
 * Given integers a and b, find the greatest common divisor.
 * @param {int} a 
 * @param {int} b 
 */
function gcd(a, b) {
    if (a === 0) {
        return b;
    }
    
    if (b === 0) {
        return a;
    }

    const smallerInput = getSmallerInputNumber(a, b);
    for (let i = smallerInput; i > 0; i--) {
        if (a % i === 0 && a % i === 0) {
            return i;
        }
    }

    return 1;
}

function getSmallerInputNumber(a, b) {
    if (b < a) {
        return b;
    }
    
    // default to returning a if
    // a < b || a === b
    return a;
}
