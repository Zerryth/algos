/**
 * Implement a function which accepts a sorted array,
 * and counts the unique values in the array.
 * 
 * There can be negative numbers in the array.
 */

 function countUniqueValues(arr) {
    if (arr.length <= 1) {
        return arr.length;
    }

    let uniqueStart = 0;
    let checker = 1;
    let count = 1;

    while (checker <= arr.length - 1) {
        while (arr[uniqueStart] === arr[checker]) {
            checker++;
        }

        count++;
        uniqueStart = checker;
        checker++;
    }

    return count;
 }

//  console.log(countUniqueValues([1, 1, 0, 3])); // 3
//  console.log(countUniqueValues([1, 1, 1, 1, 1, 2])); // 2
//  console.log(countUniqueValues([1, 2, 3, 4, 4, 4, 7, 7, 12, 12, 13])); // 7
//  console.log(countUniqueValues([])); // 0
//  console.log(countUniqueValues([-2, -1, -1, 0, 1])); // 4


// Solution 2
// Approach where we alter the array 
// -- not necessarily what we would want to do in a real-world project,
// but it works for solving just this little problem
function countUniqueValues2(arr) {
    if (arr.length <= 1) {
        return arr.length;
    }

    let i = 0;
    for (let j = 1; j < arr.length; j++) {
        if (arr[i] !== arr[j]) {
            i++;
            arr[i] = arr[j];
        }
    }

    return i + 1;
}

console.log(countUniqueValues2([1, 1, 0, 3])); // 3
console.log(countUniqueValues2([1, 1, 1, 1, 1, 2])); // 2
console.log(countUniqueValues2([1, 2, 3, 4, 4, 4, 7, 7, 12, 12, 13])); // 7
console.log(countUniqueValues2([])); // 0
console.log(countUniqueValues2([-2, -1, -1, 0, 1])); // 4
