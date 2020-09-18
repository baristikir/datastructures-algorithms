using System;
using System.Collections.Generic;

namespace sortalgorithm_insertion
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 2, 4, 7};
            int links = 0;

            if (links < array.Length)
            {
                for (int i = links; i < array.Length -1 ; i++)
                {
                    for (int k = i + 1; k > 0; k--)
                    {
                        if (array[k - 1] > array[k])
                        {
                            int j = array[k - 1];
                            array[k - 1] = array[k];
                            array[k] = j;
                        }
                    }

                }

                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}
