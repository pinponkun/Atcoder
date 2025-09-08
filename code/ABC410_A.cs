class ABC410_A
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int[] A = new int[N];
        string[] a = Console.ReadLine().Split();
        for (int i = 0; i < N; i++)
        {
            A[i] = int.Parse(a[i]);
        }
        int K = int.Parse(Console.ReadLine());

        int count = 0;
        for (int i = 0; i < N; i++)
        {
            if (K <= A[i])
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}
