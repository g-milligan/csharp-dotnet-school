using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write($"{Environment.NewLine}Press any key to exit...");

            // wait for the user to input a key before exiting
            Console.ReadKey(true);
        }
    }
}
