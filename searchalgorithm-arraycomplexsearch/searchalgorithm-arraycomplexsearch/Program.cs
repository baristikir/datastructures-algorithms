using System;

// Lineare Suche im Array
namespace searchalgorithm_arraycomplexsearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Res = new int[] { 9, 4, 2, 78, 2, 2, 1 };
            Console.WriteLine("Res = " + linearFoo(Res,2 ,0));
        }


        /// <summary>
        /// Doppelte Lineare Suche im Array nach gesuchter Zahl.
        /// </summary>
        /// <param name="Bar">Array mit Elementen</param>
        /// <param name="Star">Gesuchte Zahl</param>
        /// <param name="Megastar">Array Element Inkrement</param>
        /// <returns>Anzahl der Gesuchten Zahl im Array</returns>
        public static int Foo(int[] Bar, int Star, int Megastar)
        {
            if (Megastar > Bar.Length -1)
            {
                return 0;
            }
            if (Star == Bar[Megastar])
            {
                return (Foo(Bar, Star, Megastar + 1) + 1);
            }
            else
            {
                return Foo(Bar, Star, Megastar + 1);
            }
        }

        /// <summary>
        /// Zur Optimierung der Zeitkomplexität von dem Suchalgorithmus.
        /// Lineare Suche im Array nach der gesuchten Zahl.
        /// </summary>
        /// <param name="Bar">Array mit Elementen</param>
        /// <param name="Star">Gesuchte Zahl</param>
        /// <param name="Megastar">Array Element Inkrement</param>
        /// <returns>Anzahl der gesuchten Zahl im Array</returns>
        public static int linearFoo(int[] Bar, int Star, int Megastar)
        {
            int count = 0;
            for (Megastar = 0; Megastar < Bar.Length -1; Megastar++)
            {
                if (Star == Bar[Megastar])
                {
                    count++;
                }
            }

            return count;
        }
    }
}
