# Uses python3
import sys
from math import trunc
from collections import namedtuple

'''
You want to reward winners of a contest with candy.
You have n pieces of candy (positive integer), and want to divvy the candy up amongst winners.

What is the maximum number of winners (k) that you can have,
given the condition that each rank have different number of candy pieces,
where the higher the rank, the higher the amount of candy pieces.

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
PairwiseSummands = namedtuple('PairwiseSummands','bigger smaller')

class MaxPrizeGiver:
    def __init__(self, n):
        self.n = n
    
    def optimal_summands(self):
        print(f'n: {self.n}')
        # single_digit_prime_nums = [2, 3, 5, 7]
        summands = []

        # TODO - verify this is returning the correct pairwise sum
        pair = find_pairwise_summands(self.n)
        
        return summands
    
    def find_pairwise_summands(self, n):
        bigger_summand = break_down_to_summand(n)
        smaller_summand = n - bigger_summand

        return PairwiseSummands(bigger_summand, smaller_summand)

    def break_down_to_summand(self, n):
        quotient = divide_by_single_digit_prime_num_or_2(n)

        return quotient + 1

    def divide_by_single_digit_prime_num_or_2(self, n):
        # single_digit_prime_nums = [2, 3, 5, 7]

        # for prime_number in single_digit_prime_nums:
        #     if (n % prime_number == 0):
        #         return n / prime_number
        
        # TODO -- might only want to just divide by 2 always
        return trunc(n/2)


if __name__ == '__main__':
    # input = sys.stdin.read()
    input = 6
    n = int(input)
    prize_giver = MaxPrizeGiver(n)
    summands = prize_giver.optimal_summands()
    print(len(summands))
    for x in summands:
        print(x, end=' ')