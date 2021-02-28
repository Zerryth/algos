'''
Compute the nth Fibonacci number modulo m.

Example:
    Input: n = 8, m = 2
        Fib(8) => 21
        21 % 2 => 1

    Output: 1
'''
def fibonacci_mod(n, m):
    if (n <= 1):
        return n
    
    fib_mods = [0, 1]
    for i in range(2, n + 1):
        fib_mod = (fib_mods[i - 1] + fib_mods[i - 2]) % m

        # fib mod pisano periods always begin with 0 and 1
        if (fib_mod == 0):
            next_mod = fib_mod + fib_mods[-1] % m
            if (next_mod == 1):
                break
        
        fib_mods.append(fib_mod)
    
    # remainder of n divided by the length of pisano period
    # will let us know where in the list of fib_mods to find the remainder value
    # for n % m
    index = n % len(fib_mods)
    mod = fib_mods[index]
    
    return mod

def fibonacci_mod_naive(n, m):
    if (n <= 1):
        return n
    
    fib_mods = [0, 1]
    for i in range(2, n + 1):
        fib_mods.append((fib_mods[i - 1] + fib_mods[i - 2]) % m)
    
    return (fib_mods[n], fib_mods)
    # return fibSequence[n]

a = 13
b = 3
print(fibonacci_mod(a, b))
