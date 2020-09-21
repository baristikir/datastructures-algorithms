using System;

namespace sortalgorithm_bubblesort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 78, 55, 45, 98, 13 };
            int[] sortedArray = bubbleSort(arr);

            Console.WriteLine("Sorted:");
            foreach (int p in sortedArray)
                Console.Write(p + " ");
            Console.Read();
        }

        static int[] bubbleSort (int[] array)
        {
            int temp;
            for (int j = 0; j <= array.Length - 2; j++)
            {
                for (int i = 0; i <= array.Length - 2; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        temp = array[i + 1];
                        array[i + 1] = array[i];
                        array[i] = temp;
                    }
                }
            }
            return array;
        }
    }
}
