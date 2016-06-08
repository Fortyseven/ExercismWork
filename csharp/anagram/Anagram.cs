using System.Collections.Generic;

class Anagram
{
    private string _root_word;

    public Anagram(string word)
    {
        this._root_word = word.ToLower();
    }

    public string[] Match(string[] words)
    {
        var results = new List<string>(0);
        foreach (var word in words) {
            if (this.isAnagram(word)) {
                results.Add(word);
            }
        }
        return results.ToArray();
    }

    private bool isAnagram(string word)
    {
        word = word.ToLower();

        if (word.Length != this._root_word.Length) return false;
        if (word.Equals(this._root_word)) return false;

        var bag = new List<char>();

        for (int i = 0; i < this._root_word.Length; i++) bag.Add(this._root_word[i]);

        for (int i = 0; i < word.Length; i++) {
            int offs = bag.IndexOf(word[i]);
            if (offs >= 0) {
                bag.RemoveAt(offs);
            }
        }

        return (bag.Count == 0);
    }
}
