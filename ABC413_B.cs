using System.Collections.Generic;

class ABC413_B
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        string[] S = new string[N];
        for (int i = 0; i < N; i++)
        {
            S[i] = Console.ReadLine();
        }

        HashSet<string> C= new HashSet<string>();

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                if (i != j)
                {
                    string c = S[i] + S[j];
                    C.Add(c);
                }
            }
        }

        Console.WriteLine(C.Count);
    }
}
