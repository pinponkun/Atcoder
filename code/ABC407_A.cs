class ABC407_A
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);

        double a = (double)A / B;
        int i = (int)(a + 0.5);

        Console.WriteLine(i);
    }
}
