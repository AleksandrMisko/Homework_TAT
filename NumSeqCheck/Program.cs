using System;


namespace NumSeqCheck
{
    class NumericalSequenceCheck
    {
        static void Main(string[] args)
        {
            bool value = true;
            while (value)
            {
                Console.Write("Enter size of the sequence = ");
                String sizeArr = Console.ReadLine();
                int size = int.Parse(sizeArr);
                value = false;
            }
        }
    }
}
