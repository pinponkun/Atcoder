class ABC415_A
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());

        string[] input = Console.ReadLine().Split();
        int[] A = new int[N];
        for (int i = 0; i < N; i++)
        {
            A[i] = int.Parse(input[i]);
        }

        int X = int.Parse(Console.ReadLine());

        if (Array.Exists(A, element => element == X)) // 配列 A に X が含まれているかを判定する便利な方法
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("No");
        }
    }
}
