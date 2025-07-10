
class ABC399_A
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        char[] n = new char[N];
        for (int i = 0; i < N; i++)
        {
            n[i] = '-';
        }

        if (N % 2 == 1)
        {
            n[N / 2] = '=';
        }
        else if (N % 2 == 0)
        {
            n[N / 2 - 1] = '=';
            n[N / 2] = '=';
        }
        else
        {
            n[N / 2 - 1] = '=';
            n[N / 2] = '=';
        }
        string S = new string(n);

        Console.WriteLine(S);
    }
}
