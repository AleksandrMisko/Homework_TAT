using System;


namespace FibonacciNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool Working = true;
            while (Working)
            {
                try
                {
                    Console.Write("Enter a number: ");
                    int Number = int.Parse(Console.ReadLine());
                    if (Number >= 0)
                    {
                    }
                    else
                    {
                        Console.WriteLine("It is a negative number. Try again");
                        continue;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("Error. Invalid input. Try it adain.");
                    continue;
                }
                Working = false;
            }
        }
    }
}
