using System.Text;

public static class Identifier
{
    
    public static string Clean(string identifier)
    {
        StringBuilder sb = new StringBuilder();
        bool isAfterDash = false;
        
        foreach (char c in identifier)
        {
            if (c == ' ')
            {
                sb.Append("_");

            }
            else if (char.IsControl(c))
            {
                sb.Append("CTRL");

            }
            else if (c == '-')
            {
                isAfterDash = true;
            }
            else if (c >= 'α' && c <= 'ω')
            {
                
            }

            else if (char.IsLetter(c))
            {
                if (isAfterDash)
                {
                    sb.Append(char.ToUpper(c));
                    isAfterDash = false;
                }   
                else
                {
                    sb.Append(c);
                }
            }
            
        }
        return sb.ToString();
        
    }
}
