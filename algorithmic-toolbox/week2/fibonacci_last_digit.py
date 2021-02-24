# Uses python3
import sys

def get_fibonacci_last_digit_naive(n):
    if n <= 1:
        return n

    fib = [0, 1]
    for i in range(2, n + 1):
        fib.append(fib[i -1] + fib[i -2])
        
    return fib[n] % 10

def fib_last_digit(n):
    if (n <= 1):
        return n
    
    fibSequence = [0,1]
    for i in range(2, n + 1):
        fibSequence.append((fibSequence[i - 1] + fibSequence[i - 2]) % 10)

    return fibSequence[n]

n = int(input())
print(fib_last_digit(n))
