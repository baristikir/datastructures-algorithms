using System;
using System.Collections;
using System.Collections.Generic;

namespace hashalgorithm
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creates and initializes the one-dimensional target Array.
            var myTargetArray = new String[8];
            myTargetArray[0] = "The";
            myTargetArray[1] = "quick";
            myTargetArray[2] = "brown";
            myTargetArray[3] = "fox";
            myTargetArray[4] = "jumps";
            myTargetArray[5] = "fox";
            myTargetArray[6] = "the";
            myTargetArray[7] = "lazy";

            var table = new Hashtable();


            foreach (var item in myTargetArray)
            {
                if (!table.ContainsValue(item))
                {
                    table.Add(item.GetHashCode(), item);
                }
                else
                {
                    table.Add(item.GetHashCode() + 1, item);
                }
            }

            SearchTableEntry("lazy", table);
            DeleteTableEntry("the", table);
            PrintHashtableValues(table);

        }

        public static bool SearchTableEntry(String value, Hashtable table)
        {
 
            foreach (DictionaryEntry entry in table)
            {
                if (entry.Value == value)
                {
                    Console.WriteLine("Found Entry! The Entry Key:{1} & Entry Value:{0}", entry.Value, entry.Key);
                    return true;
                }
            }

            Console.WriteLine("Entry Not Found!");
            return false;
        }

        public static void DeleteTableEntry(String value, Hashtable table)
        {
            if (table.ContainsValue(value))
            {
                table.Remove(value.GetHashCode());
                Console.WriteLine("Deleted Entry with Value: {0}", value);
            }
        }

        public static void PrintHashtableValues(Hashtable table)
        {
            foreach (DictionaryEntry entry in table)
            {
                Console.WriteLine(entry.Key + ":" + entry.Value);
            }
        }

        public static void PrintValues(String[] myArr, char mySeparator)
        {
            for (int i = 0; i < myArr.Length; i++)
                Console.Write($"{mySeparator}{myArr[i]}");
            Console.WriteLine();
        }
    }
}
