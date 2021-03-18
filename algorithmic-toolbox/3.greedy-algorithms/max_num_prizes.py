# Uses python3
import sys
from math import trunc
from collections import namedtuple

'''
You want to reward winners of a contest with candy.
You have n pieces of candy (positive integer), and want to divvy the candy up amongst winners.

What is the maximum number of winners (k) that you can have,
given the condition that each rank have different number of candy pieces,
where the higher the place/rank of the winner, the greater the amount of candy pieces he/she recieves.

Samples:
    Input:
    6
    Output:
    1 2 3

    Input:
    2
    Output:
    1
    2

    Input:
    8
    1 2 5
'''
def optimal_summands(n):
    if n == 0:
        return []

    if n <= 2:
        return [n]

    summands = [1, n -1]

    i = 1
    while (True):
        subtrahend = i + 1 
        summand = summands[i] - subtrahend 

        if (summand <= subtrahend):
            break
        
        summands.pop()
        summands.extend([subtrahend, summand])

        i += 1

    return summands

if __name__ == '__main__':
    # input = sys.stdin.read()
    input = 10
    n = int(input)
    summands = optimal_summands(n)
    print(len(summands))
    for x in summands:
        print(x, end=' ')



# Pattern
# 1 => 1 (1)

# 2 => 1 (2)

# 3 => 2 (1, 3)

# 4 => 2 (1, 3)

# 5 => 2 (1, 4)

# 6 => (1, 5) => (1, 2, 3)

# 7 => (1, 6) => (1, 2, 4) => (1, 2, 4)

# 8 => (1, 7) => (1, 2, 5) => (1, 2, 5)