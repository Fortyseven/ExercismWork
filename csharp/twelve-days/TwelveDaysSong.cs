using System;
using System.Collections.Generic;
using System.Text;

public class TwelveDaysSong
{
    private const string FORMAT = "On the {0} day of Christmas my true love gave to me, {1}.\n";

    private static readonly string[] ITEMS = {
        "a Partridge in a Pear Tree",
        "two Turtle Doves",
        "three French Hens",
        "four Calling Birds",
        "five Gold Rings",
        "six Geese-a-Laying",
        "seven Swans-a-Swimming",
        "eight Maids-a-Milking",
        "nine Ladies Dancing",
        "ten Lords-a-Leaping",
        "eleven Pipers Piping",
        "twelve Drummers Drumming"
    };

    private static readonly string[] COUNTS = {
        "first", "second", "third", "fourth",
        "fifth", "sixth", "seventh", "eighth",
        "ninth", "tenth", "eleventh", "twelfth"
    };


    public string Verse(int v)
    {
        v--; // Base 0
        var segments = new List<string>(v);
        for (int i = v; i >= 0; i--) {
            segments.Add((((v > 0) && (i == 0)) ? "and " : "") + ITEMS[i]);
        }
        return String.Format(FORMAT, COUNTS[v], String.Join(", ", segments.ToArray())); ;
    }

    public string Verses(int v1, int v2)
    {
        StringBuilder output = new StringBuilder();
        for (int i = v1; i <= v2; i++) {
            output.Append(Verse(i));
            output.Append("\n");
        }
        return output.ToString();
    }

    public string Sing()
    {
        return Verses(1, 12);
    }
}