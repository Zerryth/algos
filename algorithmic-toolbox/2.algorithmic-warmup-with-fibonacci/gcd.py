# Uses python3
import sys

def gcd_naive(a, b):
    current_gcd = 1
    for d in range(2, min(a, b) + 1):
        if a % d == 0 and b % d == 0:
            if d > current_gcd:
                current_gcd = d

    return current_gcd

def get_smaller_input_number(a, b):
    if (b < a):
        return b
    
    # default to returning a if
    # a < b || a === b
    return a

def gcd(a, b):
    if (a == 0):
        return b
    
    if (b == 0):
        return a
    
    smaller_input = get_smaller_input_number(a, b)
    for i in range(smaller_input, 1, -1):
        if (a % i == 0 and b % i == 0):
            return i
    
    return 1
    
def euclid_gcd(a, b):
    if b == 0:
        return a
    
    remainder = a % b

    return euclid_gcd(b, remainder)

a_and_b = input()
a, b = map(int, a_and_b.split())
# print(gcd(a,b))
print(euclid_gcd(a, b))
