﻿namespace Console_IO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Do you want to create a:");
            Console.WriteLine();
            Console.WriteLine("S - Student");
            Console.WriteLine();
            Console.WriteLine("I - Instructor");
            Console.WriteLine();
            Console.WriteLine("Q - Quit");

            char response;
            response = Convert.ToChar(Console.Read());
        }
    }
}
