class ABC412_A
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        int day = 0;
        for (int i = 0; i < N; i++)
        {
            string[] input = Console.ReadLine().Split();
            int A = int.Parse(input[0]);
            int B = int.Parse(input[1]);

            if (A < B)
            {
                day++;
            }
        }
        Console.WriteLine(day);
    }
}