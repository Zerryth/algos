# Uses python3
import sys

def get_majority_element(nums, left, right):
    total_length = len(nums)
    if (total_length <= 1):
        return nums[0]
    
    if (total_length == 2):
        if (nums[0] != nums[1]):
            return -1
        return nums[0]

    nums.sort()

    if (nums[left] == nums[right]):
        if (total_length - right > total_length//2):
            return 1
        return -1
    
    # [2, 2, 2, 3, 9]
    print(f'a: {nums}, lefty {left}, righty {right}') # a: [2, 3, 9, 2, 2], left 0, right 5
    mid =  (len(nums)//2) + 1
    left = nums[:mid] # [2, 2, 2] 
    list_right = nums[mid:] # [3, 9]
    return get_majority_element(nums, LEFT_LEFT, RIGHT_LEFT) + get_majority_element(nums, LEFT_RIGHT, RIGHT_RIGHT) >= 0

# def naive_majority(nums):


if __name__ == '__main__':
    # input = sys.stdin.read()
    input = '5 2 3 9 2 2'
    # input = '5 2 3 9 1 0'
    #input = '5 2 2 9 9 9'
    n, *a = list(map(int, input.split()))
    if get_majority_element(a, 0, n) != -1:
        print(1)
    else:
        print(0)