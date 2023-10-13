using System;
using static Helpers;

namespace BottlesLibrary;

public class Bottles
{    
    public static string Song()
    {
        return Verses(99, 0);
    }

    public static string Verses(int upper, int lower)
    {
        var verses = DownTo(upper, lower)
            .Select(i => Verse(i));

        return String.Join('\n', verses);
    }

    public static string Verse(int number)
    {
        return $"{Capitalise(Quantity(number))} {Container(number)} of beer on the wall, " +
        $"{Quantity(number)} {Container(number)} of beer.\n" +
        $"{Action(number)}, " +
        $"{Quantity(Successor(number))} {Container(Successor(number))} of beer on the wall.\n";
    }



    private static int Successor(int number)
    {
        if(number == 0)
            return 99;
        else
            return number - 1;
    }

    private static string Action(int number)
    {
        if(number == 0)
            return "Go to the store and buy some more";
        else
            return $"Take {Pronoun(number)} down and pass it around";
    }

    private static string Quantity(int number)
    {
        if(number == 0)
            return "no more";
        else
            return number.ToString();
    }

    private static string Container(int number)
    {
        if(number == 1)
            return "bottle";
        else
            return "bottles";
    }

    private static string Pronoun(int number)
    {
        if(number == 1)
            return "it";
        else
            return "one";
    }
}
