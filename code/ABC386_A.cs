class ABC386_A
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int[] ABCD= new int[4];
        for (int i = 0; i < 4; i++)
        {
            ABCD[i] = int.Parse(input[i]);
        }

        for (int num = 1; num <= 13; num++)
            {
                int[] ans = new int[5];
                for (int i = 0; i < 4; i++) ans[i] = ABCD[i];
                ans[4] = num;

                int[] count = new int[14];

                for (int i = 0; i < 5; i++)
                {
                    count[ans[i]]++;
                }

                bool ThreePair = false;
                bool TwoPair = false;

                for (int i = 1; i <= 13; i++)
                {
                    if (count[i] == 3) ThreePair = true;
                    if (count[i] == 2) TwoPair = true;
                }

                if (ThreePair && TwoPair)
                {
                    Console.WriteLine("Yes");
                    return;
                }
            }

        Console.WriteLine("No");
    }
}
