using System;

namespace datastructure_stack
{
    // Klasse für die Stack Datenstruktur
    public class Stack
    {
            // Klasse für die einzelnen Knoten innerhalb der Queue
        class Node {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }
        }

        private Node top;  // adding & removing things from and to the top Stack Element

        // Hilfsmethode
        // Zum Überprüfen ob der aktuelle Knoten leer ist
        public bool isEmpty()
        {
            return top == null;
        }

        // Hilfsmethode
        public int peek() 
        {
            return top.data;
        }

        // Methode zum Hinzufügen von Elementen in den Stack
        public void push(int data)
        {
            // Neues Stack Element für den Wert wird erstellt.
            var node =  new Node(data);
            // Das näheste Stack Element zum erstellten ist das aktuelle Top Element
            node.next = top;
            // Das erstellte Element wird das neue Top Element, da es nun über dem alten Top Element 
            // sich befindet und erfolgreich zum Stack hinzugefügt wurde.
            top = node;
        }

        // Methode zum entfernen des Stack Elementes, dabei wird das LIFO Prinzip angewandt.
        public int pop()
        {
            // Lauf Variable, der den Wert des aktuellen Top Elements annimmmt.
            int data = top.data;
            // Neues Top Stack Element wird das näheste untergeordnete Stack Element.
            top = top.next;
            return data;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            // Der Stack wird erstellt
            var stack = new Stack();
            // Fügen 4 Elemente, als int's, in den Stack
            // mit der push() Methode. Das am neusten hinzugefügte Element ist der Top.
            stack.push(272);
            stack.push(235);
            stack.push(571);
            stack.push(138);
            // Danach Entfernen wird die einzelnen Elemente die an obersten Position 
            // des Stacks sind mithilfe der pop() Methode. 
            // Der Reihenfolge nach werden diese untergeordneten Elemente der Stack entfernt.
            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.pop());
            Console.WriteLine(stack.pop());
        }
    }
}
