class Year
{
    // I used a multi-level if block for other languages, but this time I figured I'd
    // try that whole "unreadable but on one line" job-security thing that's so popular.

    public static bool IsLeap(int year)
    {
        return (((year % 400) == 0) || (((year % 4) == 0) && ((year % 100) != 0)));
    }
}
