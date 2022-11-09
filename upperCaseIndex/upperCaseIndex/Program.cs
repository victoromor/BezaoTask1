using System;

namespace upperCaseIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Text = "My Second Bezao Task";
            List<int> index = new List<int>();
            for (int i = 0; i < Text.Length; i++)
            {
                if (Text[i] >= 'A' & Text[i] <= 'Z')
                {
                    index.Add(i);
                }
            }
            foreach (int letter in index)
            {
                Console.WriteLine($"Index: {letter}\t Value: {Text[letter]}");
            }
            Console.ReadLine();
        }
    }
}