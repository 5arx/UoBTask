using System;
using System.Text;

namespace UoBTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How far do you want to go (A - Z)");
            var limit = Console.ReadLine();
            
            var alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();
            
            var offset = 65;
            var spacerChar = '*';
            var sb = new StringBuilder();

            foreach (var c in alphabet)
            {
                var index = (int)c - offset;
                var charval = (int)c;

                for (int i = 0; i <= 24 - index; i++)
                {
                    sb.Append($"{spacerChar}");
                }

                sb.Append($"{c}");

                if (index > 0)
                {
                    for (int i = 0; i <= index * 2; i++)
                    {
                        sb.Append(spacerChar);
                    }

                    sb.Append(c);
                }

                sb.Append(Environment.NewLine);
            }
            Console.Write(sb.ToString());

            

		}
	}
}
