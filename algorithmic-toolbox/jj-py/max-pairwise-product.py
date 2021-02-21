def max_pairwise_product(numbers):
    n = len(numbers)
    max_index1 = 0
    max_index2 = 1
    if n == 2:
        return  numbers[0] *  numbers[1]
    else:
        for number in  range(n):
            if numbers[number] > numbers[max_index1]:
                max_index2 = max_index1
                max_index1 = number
                DELETEME1 = 1
        for number in range(n):
            if number is not max_index1 and (numbers[number] > numbers[max_index2]):
                max_index2 = number
                DELETEME2 = 2
        
        print("Max1 is " + str(numbers[max_index1])  + " at " + str(max_index1))
        print("Max2 is " + str(numbers[max_index2])  + " at " + str(max_index2))
        return numbers[max_index1] * numbers[max_index2]