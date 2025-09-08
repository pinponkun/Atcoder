class ABC411_B
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] D = Console.ReadLine().Split();
        int[] d = new int[N - 1];
        for (int i = 0; i < N - 1; i++)
        {
            d[i] = int.Parse(D[i]);
        }

        for (int i = 0; i < N - 1; i++)
        {
            int sum = 0;
            for (int j = i; j < N - 1; j++)
            {
                sum += d[j];
                Console.Write(sum);
                if (j != N - 2)
                {
                    Console.Write(" ");
                }
            }
            Console.WriteLine();
        }
    }
}
