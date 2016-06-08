using System;

class Bob
{
    public static String Hey(String msg)
    {
        msg = msg.Trim();

        if (msg.Length == 0) return "Fine. Be that way!";

        char last_char = msg[msg.Length - 1];
        bool has_alpha = false;

        for (int i = 0; i < msg.Length; i++) {
            if (Char.IsLetter(msg[i])) {
                has_alpha = true;
                break;
            }
        }

        if (msg.ToUpper().Equals(msg) && has_alpha) {
            return "Whoa, chill out!";
        }
        else if (last_char == '?') {
            return "Sure.";
        }

        return "Whatever.";
    }
}
