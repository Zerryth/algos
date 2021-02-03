// O(n)
function addUpTo(n) {
    let total = 0;
    for (let i = 0; i <= n; i++) {
        total += i;
    }

    return total;
}

// O(1)
function addUpTo2(n) {
    return n * (n + 1) / 2;
}

console.log('addUpTo', addUpTo(6));
console.log('addUpTo2', addUpTo2(6));
