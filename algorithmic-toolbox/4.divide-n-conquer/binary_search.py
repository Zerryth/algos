# Uses python3
import sys
'''
Sorted Array Multiple Search

Input: 
    - Line 1: sorted array K = [k0, ..., kn-1] of 1 <= n <= 10**4 distinct integers
    - Line 2: sorted array Q = [q0, ..., qm-1] of 1 <= m <= 10**4 integers
Output: For each qi, check whether it occurs in K
'''
def binary_search(a, x):
    low, high = 0, len(a) - 1
    mid = len(a) // 2
    while high >= low:
        mid = (low + high) // 2

        if (a[mid] == x):
            return mid
        elif (x > a[mid]):
            low = mid + 1
        else:
            high = mid - 1

    return -1




def linear_search(a, x):
    # print(f'in linear search. a: {a}, x: {x}')
    for i in range(len(a)):
        if a[i] == x:
            return i
    return -1

if __name__ == '__main__':
    # input = sys.stdin.read()
    # data = list(map(int, input.split()))
    # n = data[0]
    # m = data[n + 1]
    # a = data[1 : n + 1]
    #for x in data[n + 2:]:
    n = 5
    m = 5
    a = [1, 5, 8, 12, 13]
    nums_to_check = [8, 1, 23, 1, 11]
    for x in nums_to_check:
        # print(linear_search(a, x), end = ' ')
        print(binary_search(a, x), end = ' ')
