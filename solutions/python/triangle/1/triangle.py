def equilateral(sides):
    if any(side == 0 for side in sides):
        return False
    else:
        if sides[0] == sides[1] and sides[1] == sides[2]:
            return True
        else:
            return False


def isosceles(sides):
    if any(side == 0 for side in sides):
        return False
    elif sides[0] + sides[1] < sides[2]:
        return False
    elif sides[0] + sides[2] < sides[1]:
        return False
    elif sides[1] + sides[2] < sides[0]:
        return False
    else:
        if sides[0] == sides[1] or sides[1] == sides[2] or sides[2] == sides[0]:
            return True
        else:
            return False


def scalene(sides):
    if any(side == 0 for side in sides):
        return False
    elif sides[0] + sides[1] < sides[2]:
        return False
    elif sides[0] + sides[2] < sides[1]:
        return False
    elif sides[1] + sides[2] < sides[0]:
        return False
    elif equilateral(sides):
        return False
    elif isosceles(sides):
        return False
    else:
        return True
