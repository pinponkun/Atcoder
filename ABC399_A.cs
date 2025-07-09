class ABC399_A
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string S = Console.ReadLine();
        string T = Console.ReadLine();

        int D = 0;
        for (int i = 0; i < N; i++)
        {
            if (S[i] != T[i])
            {
                D++;
            }
        }

        Console.WriteLine(D);
    }
}
