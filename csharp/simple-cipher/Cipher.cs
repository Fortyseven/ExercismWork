using System;
using System.Text;

internal class Cipher
{
    public string Key { get; internal set; } = null;
    private static Random _rng = null;

    public Cipher()
    {
        GenerateNewKey();
    }

    private void GenerateNewKey()
    {
        var k = new StringBuilder(100);

        if ( Cipher._rng == null ) {
            _rng = new Random( DateTime.Now.ToString().GetHashCode() );
        }

        for ( int i = 0; i < 100; i++ ) {
            k.Append( (char)( _rng.Next( 26 ) + 'a' ) );
        }

        Key = k.ToString();
    }

    public Cipher( string key )
    {
        if ( key == null || key.Length == 0 ) {
            throw new ArgumentException();
        }

        foreach ( var c in key ) {
            if ( !Char.IsLower( c ) ) throw new ArgumentException();
        }

        Key = key;
    }

    public string Decode( string encoded_text )
    {
        var result = new StringBuilder(0);

        for ( int i = 0; i < encoded_text.Length; i++ ) {
            result.Append( rotate_char_dec( encoded_text[ i ], Key[ ( i % Key.Length ) ] ) );
        }

        return result.ToString();
    }

    public string Encode( string plaintext )
    {
        var result = new StringBuilder(plaintext.Length);

        for ( int i = 0; i < plaintext.Length; i++ ) {
            result.Append( rotate_char_enc( plaintext[ i ], Key[ ( i % Key.Length ) ] ) );
        }

        return result.ToString();
    }

    private char rotate_char_dec( char c, char key_char )
    {
        int dist = c - key_char;
        return (char)( dist + ( ( dist >= 0 ) ? 'a' : 'z' + 1 ) );
    }

    private char rotate_char_enc( char c, char key_char )
    {
        return (char)( ( ( ( c - 'a' ) + ( key_char - 'a' ) ) % 26 ) + 'a' );
    }
}