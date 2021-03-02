# Uses python3
from sys import stdin

'''
Given number n, compute the last digit of the sum of squared n Fibonacci numbers.

Constraints: 0 <= n <= 10**14

Example:
    Input: n = 7
        F0**2 + F1**2 + F3**2 + ... + F7**2 = 0 + 1 + 1 + 4 + 9 + 25 + 64 + 169 = 273
        => last digit of 273 is 3
    Output: 3
'''

def fibonacci_sum_squares_naive(n):
    if n <= 1:
        return n

    previous = 0
    current  = 1
    sum      = 1

    for _ in range(n - 1):
        previous, current = current, previous + current
        sum += current * current

    return sum % 10

def compute_fib_last_digits_of_pisano_period(n):
    last_fib_digits = [0, 1]
    period = 2

    # Up to n = 60,
    # which is the pisano period length for fib numbers' last digits
    for i in range(2, n + 1):
        if (period >= 60):
            break
        
        last_digit = (last_fib_digits[i - 2] + last_fib_digits[i - 1]) % 10

        last_fib_digits.append(last_digit)

        # increment pointers
        period += 1
    
    return last_fib_digits

def fibonacci_sum_squares(n):
    if (n <= 1):
        return n
    
    last_digits = compute_fib_last_digits_of_pisano_period(n)

    # Sum of fib squares = Fn * (F(n-1) + F(n))
    fib_n = last_digits[n % 60]
    fib_n_minus_1 = last_digits[(n - 1) % 60]
    length = fib_n
    width = fib_n + fib_n_minus_1

    return (length * width) % 10

n = int(input())
# print(fibonacci_sum_squares_naive(n))
print(fibonacci_sum_squares(n))

# F6 = Fib6 * (Fib5 + Fib6) = 8 * (5 + 8)

