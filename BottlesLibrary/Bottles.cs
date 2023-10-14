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
        switch (number)
        {
            case 0:
                return "No more bottles of beer on the wall, " +
                       "no more bottles of beer.\n" +
                       "Go to the store and buy some more, " +
                       "99 bottles of beer on the wall.\n";
            case 1:
                return "1 bottle of beer on the wall, " +
                       "1 bottle of beer.\n" +
                       "Take it down and pass it around, " +
                       "no more bottles of beer on the wall.\n";
            case 2:
                return "2 bottles of beer on the wall, " +
                       "2 bottles of beer.\n" +
                       "Take one down and pass it around, " +
                       "1 bottle of beer on the wall.\n";
            default:
                return $"{number} bottles of beer on the wall, " +
                       $"{number} bottles of beer.\n" +
                       "Take one down and pass it around, " +
                       $"{number-1} bottles of beer on the wall.\n";
        }
    }
}