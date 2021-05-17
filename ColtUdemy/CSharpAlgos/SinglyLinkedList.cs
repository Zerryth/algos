using System;

namespace CSharpAlgos
{
    public class SinglyLinkedList
    {
        public SinglyLinkedList()
        {
            Head = null;
            Tail = null;
            Length = 0;
        }

        public Node Head { get; set; }

        public Node Tail { get; set; }

        public int Length { get; set; }

        public SinglyLinkedList Push(object val)
        {
            var newNode = new Node(val);
            if (Head == null)
            {
                Head = newNode;
                Tail = newNode;
            }
            else
            {
                Tail.Next = newNode;
                Tail = newNode;
            }
            Length++;

            return this;
        }

        /// Removes the last Node from the SinglyLinkedList.
        /// If the list is empty, then return null
        public Node Pop()
        {
            if (this.Length == 0) return null;

            var poppedTail = Tail;
            var penultimate = FindPenultimate();
            Tail = penultimate;
            penultimate.Next = null;
            Length--;

            return poppedTail;
        }

        public Node FindPenultimate()
        {
            if (this.Length == 0) return null;

            var current = Head;
            while (current.Next?.Next != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }

            return current;
        }
    }
}