
function stressTest() {
    while(true) {
        let n = Math.floor(Math.random() * 1000 + 2);
        console.log(`n: ${n}`);
        const arr = [];

        for (let i = 0; i < n; i++) {
            arr.push(Math.floor(Math.random() * 10 + Math.random() * 10));
        }
        
        let printString = '';
        for (let i = 0; i < n; i++) {
            printString += (arr[i] + ' ')
        }
        console.log(printString);

        const maxFastRes = maxFast(arr);
        const maxSlowRes = maxSlow(arr);
        if (maxFastRes !== maxSlowRes) {
            console.log(`Wrong answer. maxFastRes: ${maxFastRes}, maxSlowRes: ${maxSlowRes}`);
            break;
        } else {
            console.log('OK\n');
        }
    }
}

function maxFast(arr) {
    const numOfElements = arr.length;

    if (numOfElements === 0) {
        return;
    }

    if (numOfElements === 1) {
        return arr[0];
    }

    if (numOfElements === 2) {
        return arr[0] * arr[1];
    }

    let greatestIdx = 0;
    for (let i = 1; i < numOfElements; i++) {
        if (arr[i] > arr[greatestIdx]) {
            greatestIdx = i;
        }
    }
    
    let secondGreatestIdx = 0;
    for (let j = 0; j < numOfElements; j++) {
        if (j === 0 && j === greatestIdx) {
            secondGreatestIdx = 1;
            j = 1;
        }

        if (j !== greatestIdx && arr[j] >= arr[secondGreatestIdx]) {
            secondGreatestIdx = j;
        }
    }

    return arr[greatestIdx] * arr[secondGreatestIdx];
}

function maxSlow(arr) {
    const numOfElements = arr.length;
    let maxProduct = 0;
    for (let i = 0; i < numOfElements; i++) {
        for (let j = i + 1; j < numOfElements; j++) {
            let product = arr[i] * arr[j];
            if (product > maxProduct) {
                maxProduct = product;
            }
        }
    }
    console.log(`maxSlow ${maxProduct}`);
    return maxProduct;
}

// console.log(maxFast([12, 6, 4, 12, 16]));
stressTest();
// maxFast([10,6,4,6,8,7])
// maxSlow([12, 6, 4, 12, 16]);

