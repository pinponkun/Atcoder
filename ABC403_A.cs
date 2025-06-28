class ABC403_A
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] AN = Console.ReadLine().Split();

        int sum = 0;
        for (int i = 0; i < N; i++)
        {
            int a = int.Parse(AN[i]);

            if (i % 2 == 0)
            {
                sum += a;
            }
        }

        Console.WriteLine(sum);
    }
}
