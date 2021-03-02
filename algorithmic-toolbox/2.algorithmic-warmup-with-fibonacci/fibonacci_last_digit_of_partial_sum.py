'''
Given two positive integers m and n, compute the last digit of the sum of fibonacci numbers
of F(m) + F(m+1) + ... + F(n), where m <= n

Example:
    Input:
    m = 3
    n = 7

    F(3) + F(4) + F(5) + F(6) + F(7) = 2 + 3 + 5 + 8 + 13 = 31
    Last digit of the sum, 31, is 1

    Output: 1
'''
def fibonacci_partial_sum_naive(from_, to):
    sum = 0

    current = 0
    next  = 1

    for i in range(to + 1):
        if i >= from_:
            sum += current

        current, next = next, current + next

    return sum % 10

def fibonacci_mod(n, m):
    if (n <= 1):
        return n
    
    fib_mods = [0, 1]
    for i in range(2, n + 1):
        fib_mod = (fib_mods[i - 1] + fib_mods[i - 2]) % m

        # pisano periods always begin with 0 and 1
        if (fib_mod == 0):
            next_mod = fib_mod + fib_mods[-1] % m
            if (next_mod == 1):
                break
        
        fib_mods.append(fib_mod)

    index = n % len(fib_mods)
    mod = fib_mods[index]
    
    return mod

def compute_sums_of_pisano_period(n):
    sums = [0, 1]
    period = 2
    n_minus_2_sum = 0
    n_minus_1_sum = 1
    total_sum = 1

    # sum of up to n = 60,
    # which is the pisano period length for fib sums last digits
    for i in range(2, n + 1):
        if (period >= 60):
            break
        
        # compute current fib sum number + add previous sum
        current_sum = n_minus_2_sum + n_minus_1_sum
        total_sum += current_sum
        sums.append(total_sum)

        # increment pointers
        n_minus_2_sum = n_minus_1_sum
        n_minus_1_sum = current_sum
        period += 1
    
    return sums

def fibonacci_last_digit_of_partial_sum(m, n):
    if (n <= 1):
        return n
    
    if (m == n):
        return fibonacci_mod(n, 10)
    
    if (m == 0):
        index = m % 60
        if (n >= 239):
            sums = compute_sums_of_pisano_period(n)
            return sums[index] % 10

        return fibonacci_mod(n, 10)
    
    sums = compute_sums_of_pisano_period(n)

    m_index = (m - 1) % 60
    m_sum = sums[m_index] % 10

    n_index = n % 60
    n_sum = sums[n_index]

    partial_sum = n_sum - m_sum
    return partial_sum % 10

m_and_n = input()
m, n = map(int, m_and_n.split())
# print(fibonacci_partial_sum_naive(m, n))
print(fibonacci_last_digit_of_partial_sum(m, n))
# print(fibonacci_last_digit_of_partial_sum(1234, 12345))
