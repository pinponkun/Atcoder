class ABC392_A
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int[] A = new int[3];
        for (int i = 0; i < 3; i++)
        {
            A[i] = int.Parse(input[i]);
        }

        if (Check(A[0], A[1], A[2]) ||
            Check(A[0], A[2], A[1]) ||
            Check(A[1], A[0], A[2]) ||
            Check(A[1], A[2], A[0]) ||
            Check(A[2], A[0], A[1]) ||
            Check(A[2], A[1], A[0]))
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }

    static bool Check(int b1, int b2, int b3)
    {
        return b1 * b2 == b3;
    }
}
