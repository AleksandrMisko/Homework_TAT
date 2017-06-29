using System;

namespace NumSeqCheck
{
    class NumericalSequenceCheck
    {
        static void Main(string[] args)
        {
            const string ENTER_LINE = "Enter size of the sequence = ";
            const string ANSWER_YES = "This sequence is non-decreasing";
            const string ANSWER_NO = "This sequence is not non-decreasing";
            const string CHK_SIZE = "Are you seriously? Let's enter size of the SEQUENCE.";
            const string INPUT = "Enter next element of the sequence = ";
            const string EXCPT = "Error. Check input and try again.";
            bool value = true;
            while (value)
            {
                try
                {
                    Console.Write(ENTER_LINE);
                    String sizeArr = Console.ReadLine();
                    int size = int.Parse(sizeArr);
                    int[] Aarray = new int[size];
                    string strAr;
                    bool cheсk = true;
                    if (size <= 1)
                    {
                        Console.WriteLine(CHK_SIZE);
                        continue;
                    }
                    else
                    {
                        int i = 0;
                        Console.Write(INPUT);
                        strAr = Console.ReadLine();
                        Aarray[i] = int.Parse(strAr);
                        for (i = 1; i < size; i++)
                        {
                            Console.Write(INPUT);
                            strAr = Console.ReadLine();
                            Aarray[i] = int.Parse(strAr);
                            if (Aarray[i] < Aarray[i - 1])
                            {
                                cheсk = false;
                                break;
                            }
                            if (Aarray[i] >= Aarray[i - 1])
                            {
                                cheсk = true;
                            }
                        }
                        if (cheсk == false)
                        {
                            Console.WriteLine(ANSWER_NO);
                        }
                        else
                        {
                            Console.WriteLine(ANSWER_YES);
                        }
                        Console.ReadKey();
                        value = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine(EXCPT);
                    continue;
                }
            }
        }
    }
}
