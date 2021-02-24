/**
 * Compute the last digit of the n-th Fibonacci number.
 * 
 * Examples
 * Input: 3
 * Output: 2
 * 
 * Input: 239
 * Output: 1
 * 
 * Input: 91239
 * Output: 6
 */
function fibonacci(n) {
    if (n <= 1) {
        return n;
    }

    const fibSequence = [0, 1];
    for (let i = 2; i < n + 1; i++) {
        fibSequence.push(fibSequence[i-1] + fibSequence[i-2])
    }

    if (fibSequence[n].toString().includes('e')) {
        let lastNum = getLastDigitFromSciNotationNumber(fibSequence[n]);
        console.log(`n ${n} => ${fibSequence[n]} => includes e ${lastNum}`);
        return parseInt(lastNum);
    }

    return fibSequence[n] % 10;
}

// if less than 2: O(n)
//otherwise f(n-1) + f(n-2)) + 3
function fibonacciSlow(n) {
    if (n <= 1) {
        return n;
    }

    return fibonacciSlow(n-1) + fibonacciSlow(n-2);
}


function getLastDigitFromSciNotationNumber(num) {
    const resultArr = num.toString().split('');
    const lastDigitIdx = resultArr.indexOf('e') - 1;
    return resultArr[lastDigitIdx];
}

const fibSequence = [0, 1, 1, 2, 3, 5, 8, 13, 21, 34];
//                   0  1  2  3  4  5  6   7   8   9

// console.log(fibonacciSlow(8));
// console.log(fibonacci(3));
// console.log(fibonacci(239));
console.log(fibonacci(240));

