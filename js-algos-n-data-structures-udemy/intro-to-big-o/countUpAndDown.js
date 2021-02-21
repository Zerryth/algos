// O(n)
function countUpAndDown(n) {
    console.log('At the bottom. Going up!');
    for (let i = 0; i <= n; i++) {
        console.log(i);
    }

    console.log('At the top. Going down...');
    for (let i = n; i >= 0; i--) {
        console.log(i);
    }
}

countUpAndDown(7);
