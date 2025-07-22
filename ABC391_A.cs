class ABC391_A
{
    static void Main()
    {
        string D = Console.ReadLine();

        var opposite = new Dictionary<string, string>
        {
            {"N", "S"},
            {"S", "N"},
            {"E", "W"},
            {"W", "E"},
            {"NE", "SW"},
            {"NW", "SE"},
            {"SE", "NW"},
            {"SW", "NE"}
        };

        if (opposite.ContainsKey(D))
        {
            Console.WriteLine(opposite[D]);
        }
    }
}
