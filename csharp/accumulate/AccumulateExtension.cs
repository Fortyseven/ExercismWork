using System;
using System.Collections.Generic;

public static class Extensions
{
    public static IEnumerable<T> Accumulate<T>( this IEnumerable<T> source, Func<T, T> callback )
    {
        foreach(var i in source) { yield return callback(i); }
    }
}
