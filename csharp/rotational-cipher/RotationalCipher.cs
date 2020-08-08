using System;
using System.Linq;
using System.Collections.Generic;

public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
         return string.Concat(text.Select(x => Transform(x)));

        char Transform(char symbol)
        {
            if (!char.IsLetter(symbol))
                return symbol;
            var key = char.IsLower(symbol) ? 'a' : 'A';

            return (char)((((symbol - key) + shiftKey) % 26) + key);
        }

    }

}




