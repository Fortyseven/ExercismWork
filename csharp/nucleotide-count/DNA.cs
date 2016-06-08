using System;
using System.Collections.Generic;
using System.Linq;

public class InvalidNucleotideException : Exception { }

class DNA
{
    private static char[] VALID_NUCLEOTIDES = { 'A', 'C', 'G', 'T' };

    private string _sequence;

    public Dictionary<char, int> NucleotideCounts {
        get {
            var result = new Dictionary<char, int>();
            foreach (var valid_nuc in VALID_NUCLEOTIDES) {
                result.Add(valid_nuc, this.Count(valid_nuc));
            }
            return result;
        }
    }

    public DNA(string sequence)
    {
        this._sequence = sequence;
    }

    public int Count(char v)
    {
        if (!VALID_NUCLEOTIDES.Contains(v)) {
            throw new InvalidNucleotideException();
        }
        return _sequence.Count(x => x == v);
    }

}
