public static class LineUp
{
    public static string Format(string name, int number)
    {
        string ordinalNumber = $"{number}";
        if (number % 100 >= 11 && number % 100 <= 13)
        {
            ordinalNumber += "th";
        }

        else if (number % 10 == 1)
        {
            ordinalNumber += "st";
        }
        else if (number % 10 == 2)
        {
            ordinalNumber += "nd";
        }
        else if (number % 10 == 3)
        {
            ordinalNumber += "rd";
        }
        else{
            ordinalNumber += "th";
        }
        return $"{name}, you are the {ordinalNumber} customer we serve today. Thank you!";
    }
}
