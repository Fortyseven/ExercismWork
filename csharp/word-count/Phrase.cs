using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

/* I'm sure there's a more elegant way to do this. */

class Phrase
{
    public static Dictionary<string, int> WordCount(string v)
    {
        var results = new Dictionary<string, int>();

        // Strip out all the non-alpha characters, except comma and single quotes
        StringBuilder clean_input_sb = new StringBuilder();
        for (int i = 0; i < v.Length; i++) {
            if (Char.IsLetterOrDigit(v[i]) || Char.IsWhiteSpace(v[i]) || v[i] == ',' || v[i] == '\'') {
                clean_input_sb.Append(v[i]);
            }
        }

        string clean_input = clean_input_sb.ToString();

        var delim = new char[] { ' ', ',' };
        foreach (var w in clean_input.Split(delim, StringSplitOptions.RemoveEmptyEntries)) {

            var word = Regex.Replace(w.ToLower(), "^\'", "", RegexOptions.None);
            word = Regex.Replace(word, "\'$", "", RegexOptions.None);
            word = Regex.Replace(word, "^\'+$", "", RegexOptions.None);

            if (word.Trim().Length == 0) continue;

            if (results.ContainsKey(word)) {
                results[word]++;
            }
            else {
                results[word] = 1;
            }
        }
        return results;
    }
}
