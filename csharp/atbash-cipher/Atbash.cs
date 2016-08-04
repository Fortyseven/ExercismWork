using System;
using System.Text;

class Atbash
{
    public static string Encode( string words )
    {
        StringBuilder result = new StringBuilder();
        int c = 0;
        foreach ( var ch in words.ToLower() ) {
            bool appended = false;
            if ( Char.IsLetter( ch ) ) {
                result.Append( (char)( 122 - ( ( (int)ch ) - 97 ) ) );
                appended = true;
            }
            else if ( Char.IsNumber( ch ) ) {
                result.Append( ch );
                appended = true;
            }
            if ( appended ) {
                c++;
                if ( ( c % 5 ) == 0 ) result.Append( ' ' );
            }
        }
        return result.ToString().Trim();
    }
}