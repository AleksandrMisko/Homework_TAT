using System;

namespace SpecialOutputOfMultipleNumbers_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number_counter = 0; number_counter <= 100; number_counter++)
            {
                String Output = (number_counter % 3 == 0 ? "3*" + number_counter / 3 : number_counter.ToString());
                Console.Write(Output + ";\n");
            }
            Console.WriteLine("The program has completed work. Press any key to exit.");
            Console.ReadLine();
        }
    }
}
