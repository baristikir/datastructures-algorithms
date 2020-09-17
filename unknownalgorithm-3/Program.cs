using System;

namespace unknownalgorithm_3
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] a = new int[] { 2, 5, 8, 6 , 20, 30, 23, 2};
            int n = a.Length;

            for (int Foo = 1; Foo < n; Foo++)
            {
                int s = a[Foo];
                
                for (int Star = Foo; Star < n; Star++)
                {
                    if (s > a[Star])
                    {
                        int t = s;
                        s = a[Star];
                        a[Star] = t;
                        a[Foo] = s;
                    } 
                }
               
            }

            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
        }
    }
}
