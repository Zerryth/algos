function fibonacci(n) {
    if (n <= 1) {
        return n;
    }

    const fibSequence = [0, 1];
    for (let i = 2; i < n + 1; i++) {
        fibSequence.push(fibSequence[i-1] + fibSequence[i-2])
    }

    console.log(`n ${n} => ${fibSequence[n]}`);
    return n;
}

// if less than 2: O(n)
//otherwise f(n-1) + f(n-2)) + 3
function fibonacciSlow(n) {
    if (n <= 1) {
        return n;
    }

    return fibonacciSlow(n-1) + fibonacciSlow(n-2);
}

const fibSequence = [0, 1, 1, 2, 3, 5, 8, 13, 21, 34];
//                   0  1  2  3  4  5  6   7   8   9

// console.log(fibonacciSlow(8));
console.log(fibonacci(9));
