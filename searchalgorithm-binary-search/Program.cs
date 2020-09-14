using System;

namespace searchalgorithm_binary_search
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] list = new int[] { 2, 5, 10, 8, 3, 6, 100};
            Array.Sort(list);
            int binaryPos = binarySearch(list, 100);

            if(binaryPos >= 0)
            {
                System.Console.WriteLine("Gefunden bei:" + binaryPos + ". Wert: " + list[binaryPos]);
            }
            else
            {
                System.Console.WriteLine("Gesuchte Zahl konnte nicht gefunden werden.");
            }
        }

        static int binarySearch(int[] list, int search)
        {
            int start = 0;
            int end = list.Length;
            
            // Solange Start- und Endpunkt nicht identisch sind
            while(start != end)
            {
                int center = start + ((end - start) /2 );

                // Element Vergleich mit gesuchter Zahl
                if(list[center] == search)
                {
                    // Ausgabe index der gesuchten Zahl in der Liste
                    return center;
                }

                // Für alle Fälle, wenn das gesuchte Element nicht die mittlere Zahl ist
                if(list[center] > search)
                {
                    end = center;
                } 
                else
                { 
                    start = center + 1;
                }
            }

            // For searched element not found in the list
            return -1;
        }
    }
}
