using System;

internal class Binary
{
    internal static int ToDecimal( string binary )
    {
        var result = 0;

        for ( int i = 0; i < binary.Length; i++ ) {
            if ( !Char.IsDigit( binary[ i ] ) ) return 0;
            var digit = (int)(binary[i]- '0');
            if ( digit > 1 ) return 0;
            result += (int)Math.Pow( 2, binary.Length - i - 1 ) * digit;
        }

        return result;
    }
}