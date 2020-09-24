using System;

namespace HelloWorld
{
    class Program
    {
        /// <summary>
        /// Defines the entry point of the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World by sai!");

            Add add = new Add();

            int b = add.addNums(5, 10);

            Console.WriteLine(b);
        }
    }
}
