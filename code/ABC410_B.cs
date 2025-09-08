class ABC410_B
{
    static void Main()
    {
        string[] line_1 = Console.ReadLine().Split();
        int N = int.Parse(line_1[0]);
        int Q = int.Parse(line_1[1]);

        string[] line_2 = Console.ReadLine().Split();
        int[] X = new int[Q];
        for (int i = 0; i < Q; i++)
        {
            X[i] = int.Parse(line_2[i]);
        }

        int[] box = new int[N];
        int[] ans = new int[Q];

        for (int i = 0; i < Q; i++)
        {
            if (X[i] >= 1)
            {
                int index = X[i] - 1;
                box[index]++;
                ans[i] = X[i];
            }
            else
            {
                int min = box[0];
                for (int j = 1; j < N; j++)
                {
                    if (box[j] < min)
                    {
                        min = box[j];
                    }
                }

                for (int j = 0; j < N; j++)
                {
                    if (box[j] == min)
                    {
                        box[j]++;
                        ans[i] = j + 1;
                        break;
                    }
                }
            }
        }

        for (int i = 0; i < Q; i++)
        {
            Console.Write(ans[i]);
            if (i != Q - 1)
            {
                Console.Write(" ");
            }
        }
        Console.WriteLine();
    }
}
