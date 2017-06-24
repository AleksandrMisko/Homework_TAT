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
