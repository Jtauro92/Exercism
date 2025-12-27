"""Functions used in preparing Guido's gorgeous lasagna.

Learn about Guido, the creator of the Python language:
https://en.wikipedia.org/wiki/Guido_van_Rossum

This is a module docstring, used to describe the functionality
of a module and its functions and/or classes.
"""
EXPECTED_BAKE_TIME = 40

def bake_time_remaining(elasped_bake_time:int):
    """Calculate the bake time remaining.

    :param elapsed_bake_time: int - baking time already elapsed.
    :return: int - remaining bake time (in minutes) derived from 'EXPECTED_BAKE_TIME'.

    Function that takes the actual minutes the lasagna has been in the oven as
    an argument and returns how many minutes the lasagna still needs to bake
    based on the `EXPECTED_BAKE_TIME`.
    """
    remainder = EXPECTED_BAKE_TIME - elasped_bake_time
    return remainder

def preparation_time_in_minutes(number_of_layers):
    """Calculate the preparation time in minutes.

    :param number_of_layers: int - number of layers the lasagna has
    :return: int - the time (in minutes) it takes to prepare the lasagna.

    Function that takes the number of layers the cake has and multiplies it by two
    to return the amount of time (in minutes) it will take to prepare the lasagna
    """
    prep_time = 2 * number_of_layers
    return prep_time


def elapsed_time_in_minutes(number_of_layers, elasped_bake_time):
    """Calculate the total cook time (in minutes).

    :param number_of_layers: int - the number of layers added to the lasagna
    :param elasped_bake_time: int - the number of minutes the lasagna has spent
    baking in the oven
    :return: int - the time (in minutes) the total cook time

    Function that takes the number of layers added to the lasagna and the amount
    of time the lasagna has been in the oven and returns the total cook time (in minutes)
    """
    return preparation_time_in_minutes(number_of_layers) + elasped_bake_time
