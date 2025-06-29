class ABC412_B
{
    static void Main()
    {
        string S = Console.ReadLine();
        string T = Console.ReadLine();

        bool flag1 = true;

        for (int i = 1; i < S.Length; i++)
        {
            char s1 = S[i];
            char s2 = S[i - 1];
            if ('A' <= s1 && s1 <= 'Z')
            {
                bool flag2 = true;

                for (int j = 0; j < T.Length; j++)
                {
                    if (s2 == T[j])
                    {
                        flag2 = false;
                        break;
                    }
                }
                if (flag2)
                {
                    flag1 = false;
                    break;
                }
            }
        }

        if (flag1)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}