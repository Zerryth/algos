import sys

'''
Maximum Salary - Largest Concatenate Problem

Compile the largest number by concatenating the given numbers.

As the last interview question, your future boss gives you a few pieces of paper with a single number written on each.
He asks you to compose the largest number from these numbers, with the resulting number being your salary,
which you are highly motivated to have as big of a number as possible.

Input:
    - line 1: integer n
    - line 2: integers a1, a2, ..., an

Output: The largest number that can be composed out of a1, ..., an.

Constraints: 1 <= n <= 100; 1 <= ai <= 10**3 for all 1 <= i <= n

Samples:
    Input:
        - 2
        - 21 2
    Output:
        221 (note: *not* 212)
    
    Input:
        - 5
        - 9 4 6 1 9
    Output:
        99641
    
    Input:
        - 3
        - 23 39 92
    Output:
        923923
'''
def get_largest_number(numbers):
    print(f'start numbers: {numbers}')
    if (len(numbers) <= 1):
        return numbers

    first_num = numbers[0]
    largest = [first_num]
    numbers.remove(first_num)
    
    while (len(numbers) != 0):
        num = numbers[0]
        end = len(largest) - 1

        for i in range(len(largest)):
            if (num + largest[i] >= largest[i] + num):
                largest.insert(i, num)
                numbers.remove(num)
                break
            
            if (i == end):
                largest.append(num)
                numbers.remove(num)
                break

    
    print(f'end numbers: {numbers}')
    return largest


if __name__ == '__main__':
    # input = sys.stdin.read()
    # data = input.split()
    # numbers = data[1:]
    # numbers = ['2100', '50', '2']
    # numbers = [9, 4, 6, 1, 9]
    # numbers = [23, 39, 92]
    # numbers = ['21', '2']
    # numbers = [7, 22, 934, 9000, 9, 99, 92] # want it to be [999934929000722]
    # numbers = [7, 22, 934, 938, 9, 99, 92] # want it to be [999934929000722]
    # numbers = [9, 4, 6, 1, 9]
    # numbers = [7, 22, 934, 9000, 9, 99, 92]
    # numbers = [21, 2]
    numbers = [15, 9, 93, 9000, 352, 354, 926]
    num_strings = [str(num) for num in numbers]
    print(get_largest_number(num_strings))
