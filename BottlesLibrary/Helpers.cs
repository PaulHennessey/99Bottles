public static class Helpers
{
    public static string Capitalise(string s)
    {
        return string.Concat(s[0].ToString().ToUpper(), s.AsSpan(1));
    }

    public static List<int> DownTo(int i, int j)
    {  
        List<int> numbers = new();

        for(int n = i; n >= j; n--)
            numbers.Add(n);

        return numbers;
    } 
}