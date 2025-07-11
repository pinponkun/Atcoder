class ABC397_A
{
    static void Main()
    {
        double X = double.Parse(Console.ReadLine());

        if (X >= 38.0)
        {
            Console.WriteLine(1);
        }
        else if (X >= 37.5)
        {
            Console.WriteLine(2);
        }
        else
        {
            Console.WriteLine(3);
        }
    }
}
