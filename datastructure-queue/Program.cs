using System;

namespace datastructure_queue
{
    // Klasse für die Queue Datenstruktur
    class Queue 
    {
        // Klasse für die einzelnen Knoten innerhalb der Queue
        class Node 
        {
            public int data;
            public Node next;
            public Node(int i)
            {
                this.data  = i;
            }
        }

        private Node head;  // removing things from the head
        private Node tail;  // adding things to the tail of queue

        // Hilfsmethode
        // Zum Überprüfen ob der aktuelle Knoten leer ist
        public bool isEmpty()
        {
            return head == null;
        }

        
        // Methode zum Hinzufügen von Elementen in die Queue
        public void Enqueue(int i)
        {
            // Neuer Knoten Punkt für den Wert wird erstellt.
            Node node = new Node(i);
            //  Überprüfung ob das Ende der Queue nicht leer ist.
            if(tail != null)
            {
                tail.next = node;
            }
            // Der neue Tail Element wird das neue Knoten Element
            tail = node;
            // Überrprüfung ob das längste Element der Queue leer ist.
            if(head == null)
            {
                // Falls ja wird das erste Element der Queue das neue Knoten Element.
                head = node;
            }
        }

        // Methode zum entfernen des Knoten Elements, dabei wird das FIFO Prinzip angewandt.
        public int Dequeue()
        {
            // Lauf Variable, der den Wert des aktuellen Head Elements annimmmt.
            int data = head.data;
            // Neuer Head wird der am näheste Knoten Element zum Head.
            head = head.next;
            // Überprüfung ob die Queue leer ist.
            if(head == null)
            {
                // Sowohl das letzte Element, als auch das neueste Element der Queue, ist leer.
                tail = null;
                System.Console.WriteLine("Queue ist leer");
                return 0;
            }
            // Das zuentfernende Element wird zurückgegeben.
            return data;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            // Die Queue wird erstellt
            var q1 = new Queue();
            // Fügen 4 Elemente, als int's, in die Queue
            // mit Enqueue() Methode. Das am neusten hinzugefügte Element ist der Tail
            // und das am längsten gebliebene Element ist der Head, innerhalb der Queue.
            q1.Enqueue(212);
            q1.Enqueue(512);
            q1.Enqueue(172);
            q1.Enqueue(234);
            // Danach Entfernen wir jedes einzelne Elmente aus der Queue und geben dem Head
            // eine neue Position, indem wir den nähesten Knoten zum Head als neuen
            // Head definieren, mit der Methode Dequeue().
            // Die Ausgabe ist bei jedem Aufruf der Head der Queue, welcher entfernt wird.
            System.Console.WriteLine(q1.Dequeue());
            System.Console.WriteLine(q1.Dequeue());
            System.Console.WriteLine(q1.Dequeue());
            System.Console.WriteLine(q1.Dequeue());

        }
    }
}
