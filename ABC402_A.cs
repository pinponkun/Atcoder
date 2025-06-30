class ABC402_A
{
    static void Main()
    {
        string S = Console.ReadLine();
        string ans = "";

        for (int i = 0; i < S.Length; i++)
        {
            char c = S[i];

            if (c >= 'A' && c <= 'Z')
            {
                ans += c;
            }
        }

        Console.WriteLine(ans);
    }
}
