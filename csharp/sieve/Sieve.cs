using System;
using System.Collections.Generic;

public class Sieve
{
    public static int[] Primes( int limit )
    {
        var marked = new bool[limit + 1];
        int mult_of = 1;

        while ( mult_of < (int)( Math.Floor( Math.Sqrt( limit ) ) ) ) {
            for ( int i = mult_of + 1; i <= limit; i++ ) {
                if ( !marked[ i ] ) {
                    mult_of = i;
                    break;
                }
            }
            for ( int val = mult_of + 1; val <= limit; val++ ) {
                if ( ( val % mult_of ) == 0 ) marked[ val ] = true;
            }
        }

        // Build results based on what we've marked
        var result = new List<int>();
        for ( int i = 2; i <= limit; i++ ) {
            if ( !marked[ i ] ) result.Add( i );
        }

        return result.ToArray();
    }
}