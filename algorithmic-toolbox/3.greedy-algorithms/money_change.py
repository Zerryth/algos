'''
Compute the minimum number of coins needed to make change
for a given money value. Denominations: 1, 5, 10
'''
def get_change(money):
    if (money <= 4):
        return money

    denominations = [10, 5, 1]
    coin_count = 0

    for denomination in denominations:
        if (money < denomination):
            continue

        remainder = money % denomination
        
        money_divided = (money / denomination)
        denomination_decimal = (remainder)/denomination
        coins = int(round(money_divided - denomination_decimal))
        coin_count += coins
        money -= coins * denomination
        
        if (remainder == 0):
            break
    
    return coin_count

money = int(input())
print(get_change(money))