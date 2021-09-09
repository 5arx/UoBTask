using System;
using System.Text;

namespace UoBTask
{
    class Program
    {
        private static char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
        private const int Offset = 65;
        private const char SpacerChar = ' ';
        private static StringBuilder Sb = new StringBuilder();

        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("How far do you want to go (A - Z)");

                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input) || string.IsNullOrEmpty(input)
                || ! char.IsLetter(input.ToCharArray()[0])
                )
                {
                    Console.WriteLine("Invalid input! Please enter a letter between a and z");
                }
                else
                {
                    var limit = input.ToUpper().ToCharArray()[0];
                    Generate(limit);
                }
            }
        }

        static void Generate(char limit)
        {
            Sb.Clear();

            Console.WriteLine($"Printing diamond for '{limit}'");

            var arrIndex = (int) limit - Offset;

            for (int i = 0; i <= arrIndex; i++)
            {
                BuildLine(alphabet[i]);
            }

            for (int i = arrIndex-1; i >= 0; i--)
            {
                BuildLine(alphabet[i]);
            }

            Console.Write(Sb.ToString());
        }

        private static void BuildLine(char c)
        {
            var current = c;
            var index = (int)c - Offset;

            for (int i1 = 0; i1 <= 24 - index; i1++)
            {
                Sb.Append($"{SpacerChar}");
            }

            Sb.Append(current);

            if (index > 0)
            {
                for (int i2 = 0; i2 <= index * 2; i2++)
                {
                    Sb.Append(SpacerChar);
                }

                Sb.Append(current);
            }
            Sb.Append(Environment.NewLine);
        }

    }
}
