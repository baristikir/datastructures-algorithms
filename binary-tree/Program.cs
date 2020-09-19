using System;

namespace binary_tree
{
    public class Knoten
    {
        public Knoten links { get; set; }
        public Knoten rechts { get; set; }
        public int data { get; set; }
    }

    public class BinaryTree
    {
        private Knoten _root { get; set; }

        public BinaryTree()
        {
            _root = null;
        }

        public void Ausgabe(Knoten root)
        {
            Console.WriteLine("Wurzel Wert:{0}", root.data);
            Console.WriteLine("Linke Knoten Wert:{0}", root.links.data);
            Console.WriteLine("Rechter Knoten Wert:{0}", root.rechts.data);
        }

        public Knoten Einfügen(Knoten root, string value)
        {
            if (root  == null)
            {
                root = new Knoten();
                root.data = Convert.ToInt32(value);
            }
            else if (Convert.ToInt32(value) < root.data)
            {
                root.links = Einfügen(root.links, value);
            }
            else
            {
                root.rechts = Einfügen(root.rechts, value);
            }

            return root;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
