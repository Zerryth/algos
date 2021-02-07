/**
 * Write a function that accepts 2 arrays.
 * Function should return true, if every value in the array has its corresponding value squared in the 2nd array
 * The frequency values must be the same
 * Example: [1, 2, 3] [4, 1, 9] => true
 * 
 * Note in this scenario, all the squared values are doubled in one array,
 * not mix-n-match between both arrays
 * Example: [1, 4, 3] [4, 2, 9] => false
 */
// O(n log n + n) or O(n log n)
function hasSameValuesSquared(arr1, arr2) {
    if (arr1.length !== arr2.length) {
        return false;
    }

    if (arr1.length === 0) {
        return true;
    }

    arr1.sort((a, b) => a - b);
    arr2.sort((a, b) => a - b);
    
    if (arr1[0] == arr2[0] && arr1[0] !== 1) {
        return false;
    }

    let smallerCounts;
    let squaredCounts;
    // An array could have multiple elements of value 1
    // Find index of the first smallest-in-value element in the sorted array
    let indexToCompare;
    for (let i = 0; i < arr1.length; i++) {
        if (arr1[i] != arr2[i]) {
            indexToCompare = i;
            break;
        }
    }

    if (arr1[indexToCompare] < arr2[indexToCompare])
    {
        smallerCounts = getFrequencyCounts(arr1);
        squaredCounts = getFrequencyCounts(arr2);
    } else {
        smallerCounts = getFrequencyCounts(arr2);
        squaredCounts = getFrequencyCounts(arr1);
    }

    for (key in smallerCounts) {
        if (smallerCounts.hasOwnProperty(key) && !squaredCounts[key*key]) {
            return false;
        }
    }

    return true;
}

function getFrequencyCounts(sourceArr) {
    const counts = {};
    for (let num of sourceArr) {
        counts[num] = ++counts[num] || 1;
    }
    
    return counts;
}

// console.log(hasSameValuesSquared([1, 2, 3], [4, 1, 9]));
// console.log(hasSameValuesSquared([4, 1, 9], [1, 2, 3]));
// console.log(hasSameValuesSquared([5, 10, 7], [100, 49, 25]));
// console.log(hasSameValuesSquared([5, 10, 7], [10000, 0, 1]));
// console.log(hasSameValuesSquared([5, 10, 7], [3]));
// console.log(hasSameValuesSquared([], []));

// Destructive method, and this time we assume 2nd array is the squared array, right off the bat
// O(n^2)
function hasSquaredValues_naive1(arr1, arr2) {
    if (arr1.length !== arr2.length) {
        return false;
    }

    for (let i = 0; i < arr1.length; i++) {
        let indexInArr2 = arr2.indexOf(arr1[i] ** 2); // indexOf loops over array, add n time
        if (indexInArr2 === -1) {
            return false;
        }
        
        // delete element at index in arr2
        arr2.splice(indexInArr2, 1);
    }

    return true;
}

// console.log(hasSquaredValues_naive1([1, 2, 3], [4, 1, 9]));
// console.log(hasSquaredValues_naive1([4, 1, 9], [1, 2, 3])); // This solution can't handle this scenario, where arr2 doesn't have the squared values
// console.log(hasSquaredValues_naive1([5, 10, 7], [100, 49, 25]));
// console.log(hasSquaredValues_naive1([5, 10, 7], [10000, 0, 1]));
// console.log(hasSquaredValues_naive1([5, 10, 7], [3]));
// console.log(hasSquaredValues_naive1([], []));

// Solution where we naiively assume arr2 always has the squared values, but better runtime than hasSquaredValues_naive1
// O(n)
function hasSquaredValues_naive2(arr1, arr2) {
    if (arr1.length !== arr2.length) {
        return false;
    }

    let frequencyCounts1 = {};
    let frequencyCounts2 = {};
    for (let val of arr1) {
        frequencyCounts1[val] = ++frequencyCounts1[val] || 1;
    }
    
    for (let val of arr2) {
        frequencyCounts2[val] = ++frequencyCounts2[val] || 1;
    }

    for (let key in frequencyCounts1) {
        if (!(key ** 2 in frequencyCounts2)) {
            return false;
        }
        if (frequencyCounts2[key ** 2] !== frequencyCounts1[key]) {
            return false;
        }
    }

    return true;
}

console.log(hasSquaredValues_naive2([1, 2, 3], [4, 1, 9]));
console.log(hasSquaredValues_naive2([4, 1, 9], [1, 2, 3])); // This solution can't handle this scenario, where arr2 doesn't have the squared values
console.log(hasSquaredValues_naive2([5, 10, 7], [100, 49, 25]));
console.log(hasSquaredValues_naive2([5, 10, 7], [10000, 0, 1]));
console.log(hasSquaredValues_naive2([5, 10, 7], [3]));
console.log(hasSquaredValues_naive2([], []));
