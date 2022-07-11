using System;

namespace HelloWorld
{
    class Program
    {
        static void Main()
        {
            string password = Console.ReadLine();
            bool correct = password == "s3cr3t!P@ssw0rd";
            if (correct)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Wrong password!");
            }
        }
    }
}
