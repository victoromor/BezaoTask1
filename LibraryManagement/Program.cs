using System;

public class LibraryManagement
{
    public static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose from these options to see available books {c, o, d, e}");
            string option = Convert.ToString(Console.ReadLine());
            Console.WriteLine(" ");

            if (option.ToLower() == "c")
            {
                Console.WriteLine("C# books");
                break;
            }
            else if (option.ToLower() == "o")
            {
                Console.WriteLine(" NET core books");
                break;
            }
            else if (option.ToLower() == "d")
            {
                Console.WriteLine("clean coding books");
                break;
            }
            else if (option.ToLower() == "e")
            {
                Console.WriteLine(" EFCore books");
                break;
            }
            else
            {
                Console.WriteLine("Try Again");
            }


            Console.ReadLine();
        }

        Console.ReadLine();

    }
}
