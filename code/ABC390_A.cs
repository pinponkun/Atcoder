using System.Linq; // LINQ（Language Integrated Query）機能

class ABC390_A
{
    static void Main()
    {
        int[] A = Console.ReadLine().Split().Select(int.Parse).ToArray();
        // Select(int.Parse) で int 型に変換
        // ToArray() で int[] に変換
        int[] target = {1, 2, 3, 4, 5};

        for (int i = 0; i < 4; i++)
        {
            int[] B = (int[])A.Clone();

            int change = B[i];
            B[i] = B[i + 1];
            B[i + 1] = change;

            if (B.SequenceEqual(target))
            {
                Console.WriteLine("Yes");
                return;
            }
        }

        Console.WriteLine("No");
    }
}
