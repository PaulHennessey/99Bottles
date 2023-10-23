using System;
using static Helpers;

namespace BottlesLibrary;

public class Bottles
{    
    public string Song()
    {
        return Verses(99, 0);
    }

    public string Verses(int upper, int lower)
    {
        var verses = DownTo(upper, lower)
            .Select(i => Verse(i));

        return String.Join('\n', verses);
    }

    public string Verse(int number)
    {
        var bottleNumber = new BottleNumber(number);
        var nextBottleNumber = new BottleNumber(bottleNumber.Successor());

        return $"{Capitalise(bottleNumber.Quantity())} {bottleNumber.Container()} of beer on the wall, " +
        $"{bottleNumber.Quantity()} {bottleNumber.Container()} of beer.\n" +
        $"{bottleNumber.Action()}, " +
        $"{nextBottleNumber.Quantity()} {nextBottleNumber.Container()} of beer on the wall.\n";
    }    
}

public class BottleNumber
{
    public int Number { get; }

    public BottleNumber(int number)
    {
        this.Number = number;
    }
    
    public int Successor()
    {
        if(this.Number == 0)
            return 99;
        else
            return this.Number - 1;
    }

    public string Action()
    {
        if(this.Number == 0)
            return "Go to the store and buy some more";
        else
            return $"Take {Pronoun()} down and pass it around";
    }

    public string Quantity()
    {
        if(this.Number == 0)
            return "no more";
        else
            return this.Number.ToString();
    }

    public string Container()
    {
        if(this.Number == 1)
            return "bottle";
        else
            return "bottles";
    }

    public string Pronoun()
    {
        if(this.Number == 1)
            return "it";
        else
            return "one";
    }    
}