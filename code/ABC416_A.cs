class ABC416_A
{
    static void Main()
    {
        string[] NLR = Console.ReadLine().Split();
        int N = int.Parse(NLR[0]);
        int L = int.Parse(NLR[1]);
        int R = int.Parse(NLR[2]);
        string S = Console.ReadLine();

        bool flag = true;
        for (int i = L - 1; i < R; i++)
        {
            if (S[i] != 'o')
            {
                flag = false;
                break;
            }
        }
        if (flag == true)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
