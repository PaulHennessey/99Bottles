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
        return $"{Capitalise(this.Quantity(number))} {this.Container(number)} of beer on the wall, " +
        $"{this.Quantity(number)} {this.Container(number)} of beer.\n" +
        $"{this.Action(number)}, " +
        $"{this.Quantity(this.Successor(number))} {this.Container(this.Successor(number))} of beer on the wall.\n";
    }
    
    private int Successor(int number)
    {
        return new BottleNumber(number).Successor();
    }

    private string Action(int number)
    {
        return new BottleNumber(number).Action();
    }

    private string Quantity(int number)
    {
        return new BottleNumber(number).Quantity();
    }

    private string Container(int number)
    {
        return new BottleNumber(number).Container();
    }

    private string Pronoun(int number)
    {
        return new BottleNumber(number).Pronoun();
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