class ABC405_A
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int R = int.Parse(input[0]);
        int X = int.Parse(input[1]);

        bool i = false;

        if (X == 1)
        {
            if (1600 <= R && R <= 2999) i = true;
        }
        else if (X == 2)
        {
            if (1200 <= R && R <= 2399) i = true;
        }
        if (i == true)
        {
            Console.WriteLine("Yes");
        }
        else if (i == false)
        {
            Console.WriteLine("No");
        }
    }
}
