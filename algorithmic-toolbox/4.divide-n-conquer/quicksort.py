# Uses python3
import sys
import random

def partition3(a, l, r):
    #write your code here
    pass

def partition2(a, left, right):
    current_val = a[left]
    pivot = left
    for i in range(left + 1, right + 1):
        if a[i] <= current_val:
            pivot += 1
            a[i], a[pivot] = a[pivot], a[i]
    a[left], a[pivot] = a[pivot], a[left] # what is this doing here?
    return pivot


def randomized_quick_sort(a, left, right):
    if left >= right:
        return
    rand = random.randint(left, right)
    a[left], a[rand] = a[rand], a[left] # if rand is the same idx val as left, it'll swap with itself
    #use partition3
    pivot = partition2(a, left, right) # a: [2, 2, 2, 3, 9], parition: 2 --> 1
    randomized_quick_sort(a, left, pivot - 1) # [2, 2] -> [2]
    randomized_quick_sort(a, pivot + 1, right) # [3, 9]


if __name__ == '__main__':
    # input = sys.stdin.read()
    # n, *a = list(map(int, input.split())) # n: 5, a: [2, 3, 9, 2, 2]
    n = 5
    a = [2, 3, 9, 2, 2]
    randomized_quick_sort(a, 0, n - 1)
    for num in a:
        print(num, end=' ')
