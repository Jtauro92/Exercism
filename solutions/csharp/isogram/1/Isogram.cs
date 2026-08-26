public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        var seen = new HashSet<char>();
        foreach (char letter in word.ToLower())
        {
            if (letter == ' ' || letter == '-')
            {
                continue;
            }
            if (seen.Contains(letter))
            {
                return false;
            }
            seen.Add(letter);
            
        }
        return true;
    }
}
