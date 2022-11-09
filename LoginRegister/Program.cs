using System;

public class LoginRegister
{
    public static void Main()
    {
        Console.WriteLine("User Registration");

        Console.WriteLine("Enter username : ");
        var userName = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Enter Password : ");
        var password = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Re-enter your Password : ");
        var retypePassword = Convert.ToString(Console.ReadLine());

        if (password != retypePassword)
        {
            Console.WriteLine("Your Password does not match");
        }
        else
        {
            Console.WriteLine("Registration successful");

            Console.WriteLine("LOGIN");

            Console.WriteLine("Please enter your username");
            var userLogin = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Please enter your password");
            var passwordLogin = Convert.ToString(Console.ReadLine());

            if (userLogin != userName || passwordLogin != password)
            {
                Console.WriteLine("Username or Password is incorrect");
            }
            else
            {
                Console.WriteLine("You have logged in successfully");
            }

        }


        Console.ReadLine();
    }
}
