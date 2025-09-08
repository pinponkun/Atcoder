class ABC414_B
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        long max = 100;
        long total = 0;
        string ans = "";

        for (int i = 0; i < N; i++)
        {
            string[] cl = Console.ReadLine().Split();
            char c = cl[0][0];
            long l = long.Parse(cl[1]);

            total += l;

            if (total > max)
            {
                Console.WriteLine("Too Long");
                return;
            }

            ans += new string(c, (int)l);
        }

        Console.WriteLine(ans);
    }
}
