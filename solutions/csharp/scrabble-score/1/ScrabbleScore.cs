public static class ScrabbleScore
{
    public static int Score(string input)
    {
        string newInput = input.ToUpper();
        int score = 0;
        string onePointers = "AEIOULNRST";
        string twoPointers = "DG";
        string threePointers = "BCMP";
        string fourPointers = "FHVWY";
        string fivePointers = "K";
        string eightPointers = "JX";
        string tenPointers = "QZ";
        foreach (char letter in newInput)
        {
            if (onePointers.Contains(letter))
            {
                score += 1;
            }
            if (twoPointers.Contains(letter))
            {
                score += 2;
            }
            if (threePointers.Contains(letter))
            {
                score += 3;
            }
            if (fourPointers.Contains(letter))
            {
                score += 4;
            }
            if (fivePointers.Contains(letter))
            {
                score += 5;
            }
            if (eightPointers.Contains(letter))
            {
                score += 8;
            }
            if (tenPointers.Contains(letter))
            {
                score += 10;
            }
        }
        return score;
            
                
        
    }
}