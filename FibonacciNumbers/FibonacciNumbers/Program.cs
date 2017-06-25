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
                        int FNumb1 = 0, FNumb2 = 1, FNumbN = 1;
                        bool checkFibonacci = false;
                        for (int i = 0; i <= Number; i++)
                        {
                            FNumb1 = FNumb2;
                            FNumb2 = FNumbN;
                            FNumbN = FNumb1 + FNumb2;
                            if (Number == FNumbN || Number == 1)
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
