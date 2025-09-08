class ABC393_A
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        string S1 = input[0];
        string S2 = input[1];

        if (S1 == "sick" && S2 == "sick")
        {
            Console.WriteLine(1);
        }
        else if (S1 == "sick" && S2 == "fine")
        {
            Console.WriteLine(2);
        }
        else if (S1 == "fine" && S2 == "sick")
        {
            Console.WriteLine(3);
        }
        else
        {
            Console.WriteLine(4);
        }
    }
}
