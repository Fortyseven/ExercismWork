using System;

public class Gigasecond
{
    public static object Date(DateTime dateTime)
    {
        return dateTime.AddSeconds(1000000000);
    }
}