using System;

public class BreakContinue
{
    public static void Main()
    {
        for (int i = 0; i < 20; i++)
        {
            if (i == 10)
                break;
            Console.WriteLine("The value of i in break is : " + i);
        }

        Console.WriteLine("Continue Example");

        for (int i = 0; i < 20; i++)
        {
            if (i == 15)
                continue;
            Console.WriteLine("The value of i in continue is : " + i);
        }
        Console.ReadLine();
    }
}
