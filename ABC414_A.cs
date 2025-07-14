class ABC414_A
{
    static void Main()
    {
        string[] NLR = Console.ReadLine().Split();
        int N = int.Parse(NLR[0]);
        int L = int.Parse(NLR[1]);
        int R = int.Parse(NLR[2]);

        int ans = 0;
        for (int i = 0; i < N; i++)
        {
            string[] XiYi = Console.ReadLine().Split();
            int Xi = int.Parse(XiYi[0]);
            int Yi = int.Parse(XiYi[1]);

            if (Xi <= L && R <= Yi)
            {
                ans++;
            }
        }
        Console.WriteLine(ans);
    }
}
