using System;

namespace _4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 5, 18, 6, -23, 64, 55 };
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
                Console.WriteLine(array[i]);
            }
        }
    }
}
