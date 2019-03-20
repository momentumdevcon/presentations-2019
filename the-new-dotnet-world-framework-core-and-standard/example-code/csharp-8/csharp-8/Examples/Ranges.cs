using System;
using System.Collections.Generic;
using System.Text;

namespace csharp_8
{
    public static partial class Examples
    {
        public static void Ranges()
        {
            string[] awesomeConferences =
            {
                "MomentumDevCon",
                "CodeMash",
                "StirTrek"
            };

            Console.WriteLine("Traditional Looping:");
            foreach (var conference in awesomeConferences)
            {
                Console.WriteLine($"{conference} is an awesome conference!");
            }

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Range-based Looping: ");
            foreach (var conference in awesomeConferences[1..3])
            {
                Console.WriteLine($"{conference} is an awesome conference!");
            }

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Range-based Looping with Type:");
            Range confRange = 0..2;
            foreach (var conference in awesomeConferences[confRange])
            {
                Console.WriteLine($"{conference} is an awesome conference!");
            }

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Ranges - From Beginning to End");
            foreach (var conference in awesomeConferences[0..^0])
            {
                Console.WriteLine($"{conference} is an awesome conference!");
            }

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Ranges - From Beginning to 2 from the End");
            foreach (var conference in awesomeConferences[0..^2])
            {
                Console.WriteLine($"{conference} is an awesome conference!");
            }

            Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Ranges - From Beginning to End");
            int start = 0;
            int end = awesomeConferences.Length;
            
            Range newRange = start..end;
            //Range newRange = new Range(start, end);
            foreach (var conference in awesomeConferences[newRange])
            {
                Console.WriteLine($"{conference} is an awesome conference!");
            }

            Console.ReadLine();
            Console.WriteLine();
        }
    }
}
