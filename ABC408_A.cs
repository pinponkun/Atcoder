class ABC408_A
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int N = int.Parse(input[0]);
        int S = int.Parse(input[1]);

        string[] t = Console.ReadLine().Split();
        int[] T = new int[N];
        for (int i = 0; i < N; i++)
        {
            T[i] = int.Parse(t[i]);
        }

        int TN = 0;
        for (int i = 0; i < N; i++)
        {
            if (T[i] - TN >= S + 0.5)
            {
                Console.WriteLine("No");
                return;
            }
            TN = T[i];
        }

        Console.WriteLine("Yes");
    }
}
