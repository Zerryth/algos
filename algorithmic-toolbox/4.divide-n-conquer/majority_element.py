# Uses python3
import sys

'''
Majority Element Problem

Check whether a given sequence of numbers contains an element that appears more than 1/2 of the times.

Input: A sequence of n integers
Output: 
    Either:
    * 1, if there is an element that is repeated more than n/2 times
    * 0, if otherwise
'''
def binary_search(list_, x):
    low, high = 0, len(list_) - 1
    mid = len(list_) // 2
    while high >= low:
        mid = (low + high) // 2

        if (list_[mid] == x):
            return mid
        elif (x > list_[mid]):
            low = mid + 1
        else:
            high = mid - 1

    return -1

def get_majority_in_half(numbers):
    check_num = numbers[0]
    count = 1
    for i in range(1, len(numbers)):
        if numbers[i] == check_num:
            count += 1
        else:
            check_num = numbers[i]
            count = 1

        if count > (len(numbers)/2):
            return (a[i], count)
    
    return (-1, -1)

def get_majority_element(a, left, right):
    total_length = len(a)
    if (total_length <= 1):
        return a[0]
    
    if (total_length == 2):
        if (a[0] != a[1]):
            return -1
        return a[0]

    a.sort()
    print(f'a: {a}, lefty {left}, righty {right}') # a: [2, 3, 9, 2, 2], left 0, right 5
    mid =  (len(a)//2) + 1
    list_left = a[:mid] # [2, 2, 2] 
    list_right = a[mid:] # [3, 9]
    len_left = len(list_left)
    
    left_majority, left_count = get_majority_in_half(list_left)

    if (left_count > total_length/2): 
        return left_majority

    if (left_majority != -1): 
        # binary search isn't actually counting all instances of element
        # need to ACTUALLY change "something" to count all instances of element
        
        right_majority, right_count = binary_search(list_right, left_majority)
        if ((right_count + left_count) > total_length/2):
            return left_majority

    if (left_majority == -1): 
        right_majority = get_majority_in_half(list_right) 
        if (right_majority == -1): 
            return -1
        else:
            left_majority, left_count = binary_search(list_left, right_majority)
            if((right_count + left_count) > total_length/2):
                return right_majority

    return -1

if __name__ == '__main__':
    # input = sys.stdin.read()
    input = '5 2 3 9 2 2'
    # input = '5 2 3 9 1 0'
    #input = '5 2 2 9 9 9'
    n, *a = list(map(int, input.split()))
    if get_majority_element(a, 0, n) != -1:
        print(1)
    else:
        print(0)


'''
2 2 2 3 9 
1. Divide the array into 2 sub arrays
    2 2 2  3 9 
2. binary search on each subarray, starting with idx 0 as target element to count

    2 2 2  3 9 
    count 3 

    if subarray count is majority for entire a, then return the number so that we have majority
    if subarray count is not majority, then look for more counts of the element in other array
    => check if count of all arrays is majority

    total count = 2

3. if count is majority in 1 subarray, use binary search to see if element exists in other array and get count
'''



'''
    count = 1
    for i in range(len_left - 1):
        idx = binary_search(list_left, list_left[i])
        exists = idx != -1
        if (exists):
            count += 1
            list_left.remove(list_left[idx])
        test_length = len(list_left)
'''

