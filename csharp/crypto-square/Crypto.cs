using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

public class Crypto
{
    private string _plaintext;

    public string NormalizePlaintext { get; private set; }
    public int Size { get; private set; }

    private string _ciphertext_with_spaces;
    private string[] _plaintext_segments;

    /**************************************/
    public Crypto( string plaintext )
    {
        _plaintext = plaintext;
        NormalizePlaintext = Regex.Replace( plaintext.ToLower(), @"[^a-z0-9]", "" );
        Size = (int)Math.Ceiling( Math.Sqrt( NormalizePlaintext.Length ) );

        _plaintext_segments = SplitStringByN( NormalizePlaintext, Size );
        _ciphertext_with_spaces = CiphertextWithSpaces();
    }

    /**************************************/
    public string[] PlaintextSegments()
    {
        return _plaintext_segments;
    }

    /**************************************/
    public string Ciphertext()
    {
        return _ciphertext_with_spaces.Replace( " ", "" );
    }

    /**************************************/
    private string CiphertextWithSpaces()
    {
        var result = new StringBuilder();

        for ( int i = 0; i < Size; i++ ) {
            foreach ( string plain_row in _plaintext_segments ) {
                if ( i < plain_row.Length ) {
                    result.Append( plain_row[ i ] );
                }
                else {
                    result.Append( ' ' );
                }
            }
        }
        return result.ToString();
    }

    /**************************************/
    private string[] CiphertextSegments()
    {
        return SplitStringByN( _ciphertext_with_spaces, PlaintextSegments().Length );
    }

    /**************************************/
    public object NormalizeCiphertext()
    {
        var result = new StringBuilder();
        foreach ( var row in CiphertextSegments() ) {
            result.Append( row );
            result.Append( ' ' );
        }
        return result.ToString().TrimEnd();
    }

    /**************************************/
    private string[] SplitStringByN( string source_text, int size )
    {
        var result = new List<string>();
        var row = new StringBuilder();
        int c = 0;

        foreach ( char ch in source_text ) {
            row.Append( ch );
            c++;
            if ( ( c % size ) == 0 ) {
                result.Add( row.ToString().Trim() );
                row.Clear();
            }
        }

        // the remainder
        if ( row.Length > 0 ) {
            result.Add( row.ToString().Trim() );
        }

        return result.ToArray();
    }
}