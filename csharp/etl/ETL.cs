using System.Collections.Generic;

class ETL
{
    internal static Dictionary<string, int> Transform(Dictionary<int, IList<string>> old)
    {
        var new_list = new Dictionary<string, int>();

        foreach (var item in old) {
            foreach(var letter in item.Value) {
                new_list.Add(letter.ToLower(), item.Key);
            }
        }

        return new_list;
    }
}
