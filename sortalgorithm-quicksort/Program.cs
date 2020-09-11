using System;

namespace sortalgorithm_quicksort
{
    class Program
    {
        public static void quicksort(int[] array)
        {
            quicksort(array, 0, array.Length - 1);
        }

        // public static void quicksort(int[] array,  int left, int  right)
        // {
        //     if(left >= right)
        //     {
        //         return;
        //     }
        //     int pivot = array[(left + right)/2];
        //     int index =  partition(array, left, right, pivot);
        //     quicksort(array, left, index-1);
        //     quicksort(array, index, right);
        // }

        private static void quicksort(int[] arr, int left, int right) 
        {
            if (left < right)
            {
                int pivot = partition(arr, left, right);

                if (pivot > 1) {
                    quicksort(arr, left, pivot - 1);
                }
                if (pivot + 1 < right) {
                    quicksort(arr, pivot + 1, right);
                }
            }
        
        }

        public static int partition(int[] array, int left, int right)
        {
            // while(left >= right)
            // {
            //     while(array[left] < pivot)
            //     {
            //         left++;
            //     }
            //     while(array[right] > pivot)
            //     {
            //         right--;
            //     }
            //     if(left <= right)
            //     {
            //         swap(array, left, right);
            //         left++;
            //         right--;
            //     }
            // }
            int pivot = array[left];
            while (true) 
            {

                while (array[left] < pivot) 
                {
                    left++;
                }

                while (array[right] > pivot)
                {
                    right--;
                }

                if (left < right)
                {
                    if (array[left] == array[right]) return right;

                    int temp = array[left];
                    array[left] = array[right];
                    array[right] = temp;


                }
                else 
                {
                    return right;
                }
            }
        }

       static void Main(string[] args)
        {
            int[] arr = new int[] { 2, 5, -4, 11, 0, 18, 22, 67, 51, 6 };

            Console.WriteLine("Original array : ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);    
            }
            Console.WriteLine();

            quicksort(arr, 0, arr.Length-1);
            
            Console.WriteLine();
            Console.WriteLine("Sorted array : ");
           
		   foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();
        }
    }
}
