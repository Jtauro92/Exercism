public static class Pangram
{
    public static bool IsPangram(string input)
    {
        string sentence = input.ToLower();
        
        for (char letter = 'a'; letter <= 'z'; letter++)
        {
            if (!sentence.Contains(letter))
            {
                return false;
            }
        }
        return true;
    }
}
