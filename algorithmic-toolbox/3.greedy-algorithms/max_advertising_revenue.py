#Uses python3
import sys

'''
Maximum Product of Two Sequences

Find the maximum dot product of two sequences of positive integers.

Input:
    - n number of advertising slots
    - list of prices [price1, price2, ..., pricen]
    - list of clicks [click1, click2, ..., clickn]

Output:
    - Max value of (price1 * c1 + ... + pricen * cn),
        where c1, ..., cn is a permutation of clicks1, ..., clicksn

Constraints: 1 <= n <= 10 ** 3, 0 <= pricei, clicks <= 10 ** 5 for all 1 <= i <= n

Samples:
    Input:
        1
        23
        39
    Output: 897 (897 = 23 * 39)

    Input:
        3
        2 3 9
        7 4 2
    Output: 79 (79 = 7*9 + 2*2 + 3*4)
'''
def get_max_advertising_revenue(a, b):
    if (len(a) == 0):
        return 0
    
    if (len(a) == 1):
        return a[0] * b[0]
        
    a.sort(reverse=True)
    b.sort(reverse=True)
    print(a) # [9, 3, 2]
    print(b) # [2, 4, 7]

    total = 0
    for i in range(len(a)):
        total += a[i] * b[i] 
    
    return total

if __name__ == '__main__':
    # input = sys.stdin.read()
    # data = list(map(int, input.split()))
    data = [3, 2, 3, 9, 7, 4, 2]
    print(data)
    n = data[0]
    a = data[1:(n + 1)]
    b = data[(n + 1):]
    print(get_max_advertising_revenue(a, b))



# def max_dot_product(a, b):
#     #write your code here
#     res = 0
#     for i in range(len(a)):
#         res += a[i] * b[i]
#     return res