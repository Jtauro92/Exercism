def convert(number):
    divisible_by_3 = number % 3 == 0
    divisible_by_5 = number % 5 == 0
    divisible_by_7 = number % 7 == 0

    raindrop_sounds = ''
    if divisible_by_3:
        raindrop_sounds += "Pling"

    if divisible_by_5:
        raindrop_sounds += "Plang"

    if divisible_by_7:
        raindrop_sounds += "Plong"

    if raindrop_sounds:
        return raindrop_sounds
        
    return str(number)
