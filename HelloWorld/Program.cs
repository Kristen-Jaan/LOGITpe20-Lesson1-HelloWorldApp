using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //this is a commentary
            //Console.WriteLine("Minecraft2!");
            Console.WriteLine("What's Your Name?");
            string Name;
            //read the input from the user
            Name = Console.ReadLine();
            Console.WriteLine("Hello," + Name);

        }
    }
}
