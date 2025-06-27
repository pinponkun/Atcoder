class ABC404_A
{
    static void Main()
    {
        string S = Console.ReadLine();
        bool[] used = new bool[26];

        foreach (char c in S)
        {
            used[c - 'a'] = true;
        }

        for (int i = 0; i < 26; i++)
        {
            if (!used[i])
            {
                Console.WriteLine((char)('a' + i));
                return;
            }
        }
    }
}
