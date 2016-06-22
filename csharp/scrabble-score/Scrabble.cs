using System;

public class Scrabble
{
    private static int[] LETTER_SCORE = { 1, 3, 3, 2, 1, 4, 2, 4, 1, 8, 5, 1, 3, 1, 1, 3, 10, 1, 1, 1, 1, 4, 4, 8, 4, 10 };
    public static object Score( string v )
    {
        if ( v == null ) return 0;

        int score = 0;

        foreach ( var ch in v ) {
            if ( !Char.IsLetter( ch ) ) continue;
            score += LETTER_SCORE[ ( (int)Char.ToLower( ch ) ) - 97 ];
        }

        return score;
    }
}