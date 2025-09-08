class ABC417_A
{
    static void Main()
    {
        string[] NAB = Console.ReadLine().Split();
        int N = int.Parse(NAB[0]);
        int A = int.Parse(NAB[1]);
        int B = int.Parse(NAB[2]);
        string S = Console.ReadLine();

        for (int i = A; i < N - B; i++)
        {
            Console.Write(S[i]);
        }
        Console.WriteLine();
    }
}
