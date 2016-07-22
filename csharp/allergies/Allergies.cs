using System.Collections.Generic;

class Allergies
{
    private int _score;

    private Dictionary<string, int> _allergens = new Dictionary<string,int>() {
                    {"eggs", 1},
                    {"peanuts", 2},
                    {"shellfish", 4},
                    {"strawberries",8},
                    {"tomatoes", 16},
                    {"chocolate",32},
                    {"pollen",64},
                    {"cats",128}
        };

    public Allergies( int score )
    {
        _score = score;
    }

    public bool AllergicTo( string v )
    {
        int av = _allergens[v];

        if ( ( _score & av ) != 0 ) return true;
        return false;
    }

    public List<string> List()
    {
        var results = new List<string>();

        foreach ( var al in _allergens ) {
            if ( AllergicTo( al.Key ) ) {
                results.Add( al.Key );
            }
        }
        return results;
    }
}