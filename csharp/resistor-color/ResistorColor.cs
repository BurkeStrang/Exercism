﻿using System;

public static class ResistorColor
{
    private static readonly string[] ColorArray = {
        "black", "brown", "red", "orange", "yellow",
        "green", "blue", "violet", "grey", "white",
    };

    public static int ColorCode(string color) => Array.IndexOf(ColorArray, color);

    public static string[] Colors() => ColorArray;
    
}