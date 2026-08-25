def steps(number):
    num_of_steps = 0
    if number < 1:
        raise ValueError("Only positive integers are allowed")
    while number != 1:
        if number % 2 == 0:
            number = number /2
            num_of_steps += 1
        else:
            number = number * 3 + 1
            num_of_steps += 1
    return num_of_steps
