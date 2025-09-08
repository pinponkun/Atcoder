class ABC400_A
{
    static void Main()
    {
        int A = int.Parse(Console.ReadLine());
        int B = 400;

        int ans = B / A;

        if (B % A == 0)
        {
            Console.WriteLine(ans);
        }
        else
        {
            Console.WriteLine("-1");
        }
    }
}