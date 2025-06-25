class ABC406_A
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int A = int.Parse(input[0]);
        int B = int.Parse(input[1]);
        int C = int.Parse(input[2]);
        int D = int.Parse(input[3]);

        int deadline = A * 60 + B;
        int submit = C * 60 + D;

        if (deadline > submit)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}