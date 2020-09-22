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
            int[] a = new int[] { 6, 5, 1, 8, 1000 , 4, 25};
            int p = -1;
            int q = p;
            int r = q;

            //******************************
            //*** NEW MODIFIED CODE O(n) ***
            //******************************
            for (int i = 0; i < a.Length; i++)
            {
                int tmp = 0;
                if (a[i] >= p)
                {
                    tmp = p;
                    p = a[i];
                }
                else if (a[i] < p && a[i] > q)
                {
                    q = a[i];
                }
                if (tmp < p && q < tmp)
                {
                    q = tmp;
                }
            }

            //**************************************
            //*** OLD UNMODIFIED ALGORITHM O(n^2)***
            //**************************************
            //while (r < a.Length - 1)
            //{
            //    r += 1;
            //    if (a[r] >= p)
            //        p = a[r];
            //}

            //while (r > 0)
            //{
            //    r -= 1;
            //    if (a[r] > q)
            //    {
            //        if (p > a[r])
            //        {
            //            q = a[r];
            //        }
            //    }
            //}


            if (q > p)
            {
                return q - p;
            }
            return p - q;
        }
    }
}
