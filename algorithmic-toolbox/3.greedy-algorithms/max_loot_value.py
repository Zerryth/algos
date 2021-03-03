import sys

def sort_items(values, weights):
    sorted_items = []

    for i in range(len(values)):
        val = values[i]
        weight = weights[i]
        sorted_items.append([val, weight, val / weight])
    
    sorted_items.sort(key=lambda s_list : s_list[2], reverse=True)

    return sorted_items

'''
Find the maximum value of items that fit into the backpack.

Input: 
    -1st line: n number of compounds and the capacity of the backpack, W
    - Subsequent n lines:
        - Weights (w1, ..., wn)
        - Prices (p1, ..., pn)
        of n different compounds

Output:
    The maximum total price of items that fit into the backpack 
    of the given capacity


In spice shop:
	- 4 lbs saffron: $5000 per lb
	- 3 lbs vanilla: $200 per lb
	- 5 lbs cinnamon: $10 per lb

Thief's Backpack Capacity: 9 lbs

What is the most valuable loot in this case?

pounds:
	- u1 saffron
	- u2 vanilla
	- u3 cinnamon

Total price of loot = 5000u1 + 200u2 + 10u3

Constraints: 
	- u1 <= 4
	- u2 <= 3
	- u3 <= 5
	- u1 + u2 + u3 <= 9
'''
def find_max_loot_value(capacity, weights, values):
    print(f'capacity: {capacity}')
    print(f'weights: {weights}')
    print(f'values: {values}')

    value = 0
    # example: [[120, 30, 4.0], [60, 20, 3.0], [100, 50, 2.0]]
    sorted_items = sort_items(values, weights)

    for item in sorted_items:
        val = item[0]
        weight = item[1]
        fraction = 1

        # We'll take all of a particular item (so fraction = 1),
        # unless there's more of that item than we can carry (we take a fraction of the item)
        if (capacity < weight):
            fraction = capacity / weight
            
        fractional_value = val * fraction
        fractional_weight = weight * fraction

        value += fractional_value
        capacity -= fractional_weight

        if (capacity == 0):
            break

    return value

# data = list(map(int, sys.stdin.read().split())) # [3, 50, 1, 20, 2, 60, 3, 70]
# data = [3, 50, 60, 20, 100, 50, 120, 30]
data = [1, 10, 500, 30]
n, capacity = data[0:2] # data[0:2] --> [3, 50] --> n = 3, capacity = 50
values = data[2:(2 * n + 2):2] # --> values are from idx 2 to the end of array (excluding end, so +1), and values are every other in the sub array [1, 20, 2, 60, 3, 70] --> values = [1, 2, 3]
weights = data[3:(2 * n + 2):2] # --> weights from idx 3 to end of arr, weights are every other element --> [20, 2, 60, 3, 70]  --> weights = [20, 60, 70]
opt_value = find_max_loot_value(capacity, weights, values)
print("{:.10f}".format(opt_value))
