using System;


namespace FibonacciNumbers
{
    class CheckFibonacciNumber
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
                        int FibonacciNumb1 = 0, FibonacciNumb2 = 1, FibonacciNumbN = 1;
                        bool checkFibonacci = false;
                        for (int i = 0; i < Number; i++)
                        {
                            FibonacciNumb1 = FibonacciNumb2;
                            FibonacciNumb2 = FibonacciNumbN;
                            FibonacciNumbN = FibonacciNumb1 + FibonacciNumb2;
                            if (Number == FibonacciNumbN || Number == 1)
                            {
                                checkFibonacci = true;
                                break;
                            }
                        }
                        if (checkFibonacci)
                        {
                            Console.WriteLine("This is the Fibonacci number.");
                        }
                        else
                        {
                            Console.WriteLine("This is not the Fibonacci number.");
                        }
                        Console.WriteLine("\nPress any key to exit.");
                        Console.ReadKey();
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
