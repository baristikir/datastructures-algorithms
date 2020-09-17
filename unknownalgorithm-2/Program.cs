using System;

namespace unknownalgorithm_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(functiond());
        }

        static int functiond()
        {
            int[] a = new int[] { 6, 5, 1, 8, 1000};
            int p = -1;
            int q = p;
            int r = q;

            while (r < a.Length - 1)
            {
                r += 1;
                if (a[r] >= p)
                    p = a[r];
            }

            while (r > 0)
            {
                r -= 1;
                if (a[r] > q)
                {
                    if (p > a[r])
                    {
                        q = a[r];
                    }
                }
            }

            if (p > q)
            {
                return p - q;
            }
            if (q > p)
            {
                return q - p;
            }

            return 0;
        }
    }
}
