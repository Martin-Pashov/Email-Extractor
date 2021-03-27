using System;
using System.Text.RegularExpressions;

namespace Email_Extractor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some text that contains emails: ");
            string input = Console.ReadLine();

            string pattern = @"[A-Z0-9._%+-]+@[A-Z0-9.-]+\.[A-Z]{2,}";
            Regex regX = new Regex(pattern, RegexOptions.IgnoreCase);
            Match fit = regX.Match(input);

            Console.WriteLine();
            Console.WriteLine("The emails listed below have been extracted ↓");
            while (fit.Success)
            {
                Console.WriteLine($"{fit}");

                fit = fit.NextMatch();
            }
        }
    }
}
