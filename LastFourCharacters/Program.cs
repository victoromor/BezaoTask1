using System;

namespace LastFourCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to hash: ");
            int count = 4;
            char hash = '#';
            var input = Convert.ToString(Console.ReadLine());
            var length = input.Length;
            if (length < count)
            {
                Console.WriteLine("Input too short");
            }
            else
            {
                var result = new String(hash, length - 4) + input.Substring(length - 4);
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
