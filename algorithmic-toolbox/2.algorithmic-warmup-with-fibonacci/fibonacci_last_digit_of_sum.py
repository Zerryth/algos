'''
Compute the last digit of the sum of Fibonacci numbers of
F0 + F1 + ... + Fn

Example:
    Input: 7
        sum_of_fib_nums = 0 + 1 + 1 + 2 + 3 + 5 + 8 => 20
        last digit of the sum is 0

    Output: 0
'''
# formula for Sum of fib numbers:
# S(n) = F(0) + F(1) + ... + F(n) => F(n+2) - 1

def compute_last_digits_of_pisano_period(n):
    last_digits = [0, 1]
    period = 2
    n_minus_2_sum = 0
    n_minus_1_sum = 1
    total_sum = 1

    # sum of up to n = 60,
    # which is the pisano period length for fib sums
    for i in range(2, n + 1):
        if (period >= 60):
            break
        
        # compute current fib sum number + add previous sum
        current_sum = n_minus_2_sum + n_minus_1_sum
        total_sum += current_sum
        # only store the last digit of the sum
        last_digits.append(total_sum % 10)

        # increment pointers
        n_minus_2_sum = n_minus_1_sum
        n_minus_1_sum = current_sum
        period += 1
    
    return last_digits

def fibonacci_last_digit_of_sum(n):
    if (n <= 1):
        return n
    
    last_digits = compute_last_digits_of_pisano_period(n)

    index = n % 60
    return last_digits[index]

print(fibonacci_last_digit_of_sum(8))

def fibonacci_last_digit_of_sum_naive(n):
    if (n <= 1):
        return n
    
    previous = 0 # 1 1
    current = 1 # 1 2
    sum = 1

    for _ in range (n - 1):
        previous, current = current, previous + current
        sum += current
    
    return sum
