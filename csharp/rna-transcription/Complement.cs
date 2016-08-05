using System.Text;

public class Complement
{
    private static char[] _dna = { 'G','C','T','A' };
    private static char[] _rna = { 'C','G','A','U' };

    public static string OfDna( string dna )
    {
        var result = new StringBuilder();
        foreach(char n in dna ) {
            for(int i = 0; i < _dna.Length; i++ ) {
                if ( n == _dna[ i ] ) result.Append( _rna[ i ] );
            }
        }
        return result.ToString();
    }
}