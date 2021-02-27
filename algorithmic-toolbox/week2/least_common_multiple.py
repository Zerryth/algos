# Uses python3
import sys

'''
Given two positive integers a and b, find the least common multiple, m,
where m is divisible by both a and b.
'''
def lcm(a, b):
    if (a == 0 or b == 0):
        return 0
    
    if (a == b):
        return a
    
    return (a * b) / euclidean_gcd(a, b)

def euclidean_gcd(a, b):
    if b == 0:
        return a
    
    remainder = a % b

    return euclidean_gcd(b, remainder)

def lcm_naive(a, b):
    for l in range(1, a*b + 1):
        if l % a == 0 and l % b == 0:
            return l

    return a*b

# a_and_b = input()
# a, b = map(int, a_and_b.split())
# print(lcm(a, b))
# print(lcm(714552, 374513))
