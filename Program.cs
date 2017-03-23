using System;
using System.Globalization;
using System.Linq;

namespace ParametersTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello, World!");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Executable Line:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Environment.CommandLine);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Current Directory:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Environment.CurrentDirectory);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Current User:");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(Environment.UserDomainName + "\\" + Environment.UserName);
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Executable arguments:");
            if (!args.Any())
            {
                Console.WriteLine("\tNo arguments");
            }

            foreach (string arg in args)
            {
                int position = args.ToList().IndexOf(arg);
                string positionValue = position.ToString(CultureInfo.InvariantCulture).PadLeft(args.Count().ToString(CultureInfo.InvariantCulture).Count());

                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(positionValue + ": ");

                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write(arg);

                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}