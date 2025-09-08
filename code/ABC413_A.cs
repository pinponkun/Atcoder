class ABC413_A
{
    static void Main()
    {
        string[] line_1 = Console.ReadLine().Split();
        int N = int.Parse(line_1[0]);
        int M = int.Parse(line_1[1]);

        string[] input = Console.ReadLine().Split();
        int[] A = new int[N];
        for (int i = 0; i < N; i++)
        {
            A[i] = int.Parse(input[i]);
        }

        int m = 0;
        for (int i = 0; i < N; i++)
        {
            m += A[i];
        }

        if (m <= M)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
