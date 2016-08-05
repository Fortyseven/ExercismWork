using System;

public class Trinary // Ternary?
{
    private const int BASE = 3;

    public static int ToDecimal( string value )
    {
        int result = 0;

        var digits = value.ToCharArray();
        Array.Reverse( digits );

        for ( int pos = 0; pos < digits.Length; pos++ ) {
            int digit = (int)char.GetNumericValue(digits[pos]);
            if ( digit < 0 || digit >= BASE ) return 0;
            result += ( digit * (int)Math.Pow( BASE, pos ));
        }

        return result;
    }
}