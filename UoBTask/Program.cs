using System;
using System.Text;

namespace UoBTask
{
    class Program
    {
        static char[] alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray();





        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("How far do you want to go (A - Z)");

                var input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input) || string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Error! Please enter a letter between a and z");
                }
                else
                {
                    var limit = input.ToUpper().ToCharArray()[0];

                    const int offset = 65;
                    var spacerChar = '*';

                    var sb = new StringBuilder();

                    foreach (var c in alphabet)
                    {
                        if ((int) c <= (int) limit)
                        {


                            var index = (int) c - offset;
                            var charval = (int) c;

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
                        else
                        {
                            var _content = sb.ToString();

                            for (int i = sb.Length; i == 0; i--)
                            {
                                sb.Append(_content[i]);
                            }
                            //Console.WriteLine($"{sb..Length} lines in the stringbuilder");
                        }
                    }
                    Console.Write(sb.ToString());

                }
            }
        }
    }
}
