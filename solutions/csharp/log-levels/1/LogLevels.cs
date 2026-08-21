static class LogLine
{
    public static string Message(string logLine)
    {
        return logLine.Split(":")[1].Trim();
    }

    public static string LogLevel(string logLine)
    {
        string prefix = logLine.Split(":")[0];
        string newPrefix = prefix.Replace("]","").Replace("[","");
        return newPrefix.ToLower();
        
    }

    public static string Reformat(string logLine)
    {
        return $"{Message(logLine)} ({LogLevel(logLine)})";
    }
}
