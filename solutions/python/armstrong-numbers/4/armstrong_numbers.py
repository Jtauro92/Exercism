'''Script to find Armstrong numbers'''

def is_armstrong_number(number):
    '''Function to determine if a given value is an Armstrong number'''
    str_number = str(number)
    power = len(str_number)
    total_sum = 0
    
    for digit in str_number:
        value = int(digit) ** power
        total_sum += value

    return number == total_sum
