class ABC418_A
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string S = Console.ReadLine();

        if (N >= 3 && S[N - 3] == 't' && S[N - 2] == 'e' && S[N - 1] == 'a')
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
