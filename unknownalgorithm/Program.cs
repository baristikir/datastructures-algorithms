using System;

namespace unknownalgorithm
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Gebe die Anzahl von Zahlen im Array an:");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] a = new int[n];

            for(int i = 0; i < n; i++)
            {
                System.Console.WriteLine($"Gebe die {i+1}. Zahl an");
                int j = Convert.ToInt32(Console.ReadLine());
                a[i] = j;
            }

            System.Console.WriteLine();

            int x = 0;
            // foreach (var item in a)
            // {
            //     System.Console.Write(item + " ");
            // }
            int Foo = 1;
            System.Console.WriteLine("Foo:" + Foo);
            for (int Bar = 2; Bar < n; Bar++)    
            {
                 if (x < Math.Abs(a[Foo] - a[Bar]))
                 {
                     System.Console.WriteLine("Bar:" + Bar);
                     x = Math.Abs(a[Foo] - a[Bar]);
                 }   
            }

            System.Console.WriteLine();
            Console.Write(x);
            Console.ReadKey();
        }
    }
}
