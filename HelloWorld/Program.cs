using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Who R U?");
            string UserName;
            UserName = Console.ReadLine();

            Console.WriteLine("Hello, " + UserName);

            Console.Read();


        }
    }
}
