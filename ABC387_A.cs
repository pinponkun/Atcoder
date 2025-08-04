class ABC387_A
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);

        int ans = (A + B) * (A + B);

        Console.WriteLine(ans);
    }
}
