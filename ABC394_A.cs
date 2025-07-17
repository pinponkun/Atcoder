class ABC394_A
{
    static void Main()
    {
        string S = Console.ReadLine();

        string ans = "";
        foreach (char c in S)
        {
            if (c == '2')
            {
                ans += c;
            }
        }

        Console.WriteLine(ans);
    }
}
