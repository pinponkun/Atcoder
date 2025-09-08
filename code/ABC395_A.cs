class ABC395_A
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

        bool flag = true;
        for (int i = 0; i < N - 1; i++)
        {
            if (A[i] >= A[i + 1])
            {
                flag = false;
                break;
            }
        }
        if (flag == true)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}