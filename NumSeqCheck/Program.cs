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
                int[] Aarray = new int[size];
                string strAr;
                for (int i = 0; i < size; i++)
                {
                    Console.Write("Enter " + (i + 1) + " element of the sequence = ");
                    strAr = Console.ReadLine();
                    Aarray[i] = int.Parse(strAr);
                }
                bool cheсk = true;
                for (int i = 1; i < size; i++)
                {
                    if (Aarray[i] >= Aarray[i - 1])
                    {
                        cheсk = true;
                    }
                    if (Aarray[i] < Aarray[i - 1])
                    {
                        cheсk = false;
                        break;
                    }
                }
                if (cheсk == false)
                {
                    Console.WriteLine("This sequence is decreasing ");
                }
                else
                {
                    Console.WriteLine("This sequence is nondecreasing ");
                }
                Console.ReadKey();
                value = false;
            }
        }
    }
}
