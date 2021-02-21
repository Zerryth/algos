/**
 * Write a function that accepts a sorted array of integers.
 * The function should find the **first** pair where the sum is 0.
 * Return an array that includes both values that sum to 0 
 * or empty array if pair does not exist.
 */

 // O(n^2)
function simpleSumZero(arr) {
    if (arr.length < 2) {
        return [];
    }

    for (let i = 0; i < arr.length; i++) {
        for (let j = 1; j < arr.length; j++) {
            if (i !== j && arr[i] + arr[j] === 0) {
                return [arr[i], arr[j]];
            }
        }
    }
    
    return [];
}

// console.log(simpleSumZero([-3, -2, -1, 0, 1, 2 ,3])); // [-3, 3]
// console.log(simpleSumZero([-2, 0, 1, 3])); // []
// console.log(simpleSumZero([1, 2, 3])); // []

// O(n)
function sumZero(arr) {
    if (arr.length < 2) {
        return [];
    }

    let left = 0;
    let right = arr.length - 1;

    while (left < right) {
        let sum = arr[left] + arr[right];
        if (sum === 0) {
            return [arr[left], arr[right]];
        }

        if (sum > 0) {
            right--;
        }

        if (sum < 0) {
            left++;
        }
    }

    return [];
}

console.log(sumZero([-3, -2, -1, 0, 1, 2 ,3])); // [-3, 3]
console.log(sumZero([-3, -2, -1, 1, 2 ,3])); // [-3, 3]
console.log(sumZero([-2, 0, 1, 3])); // []
console.log(sumZero([1, 2, 3])); // []
console.log(sumZero([-4, -3, -2, -1, 0, 1, 2, 5])); // [-2, 2]
