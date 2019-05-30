using System;

namespace _4._2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 11;
            int[] sbyteAr = new int[n];
            int[] shortAr = new int[n];
            int[] intAr = new int[n];
            Random rnd = new Random();
            int sbyteCount = 0;
            int shortCount = 0;
            int intCount = 0;
            int count = 0;
            for(int i = 0; i < 2147483647; i++)
            {
                int rndNumber = rnd.Next(2147483647);
                if (rndNumber < 128 && sbyteCount < (n - 1))
                {
                    sbyteAr[sbyteCount] = rndNumber;
                    Console.WriteLine("sbyteAr["+sbyteCount+"]: "+ rndNumber);
                    sbyteCount++;
                }
                else
                {
                    if(rndNumber<32768 && shortCount < (n - 1))
                    {
                        shortAr[shortCount] = rndNumber;
                        Console.WriteLine("shortAr[" + shortCount + "]: " + rndNumber);
                        shortCount++;
                    }
                    else
                    {
                        if (intCount < (n-1))
                        {
                            intAr[intCount] = rndNumber;
                            Console.WriteLine("intAr[" + intCount + "]: " + rndNumber);
                            intCount++;
                        }
                    }
                }
                if(sbyteCount== (n - 1) && shortCount== (n - 1) && intCount == (n - 1))
                {
                    break;
                }                
                count++;
            }
            Console.WriteLine("Counter: " + count);
        }
    }
}
