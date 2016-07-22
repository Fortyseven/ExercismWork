using System;
using System.Collections.Generic;
using System.Linq;

public static class Extensions
{
    public static IEnumerable<T> Keep<T>( this IEnumerable<T> col, Func<T, bool> lam )
    {
        var result = from o in col
                     where lam(o)
                     select o;

        return result;
    }

    public static IEnumerable<T> Discard<T>( this IEnumerable<T> col, Func<T, bool> lam )
    {
        var result = from o in col
                     where !lam(o)
                     select o;

        return result;
    }
}
