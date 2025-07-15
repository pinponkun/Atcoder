class ABC396_A
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] AN = Console.ReadLine().Split();
        int[] A = new int[N];
        for (int i = 0; i < N; i++)
        {
            A[i] = int.Parse(AN[i]);
        }

        for (int i = 0; i < N - 2; i++)
        {
            if (A[i] == A[i + 1] && A[i + 1] == A[i + 2])
            {
                Console.WriteLine("Yes");
                return;
            }
        }

        Console.WriteLine("No");
    }
}
