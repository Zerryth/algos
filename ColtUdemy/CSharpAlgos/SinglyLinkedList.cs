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
            if (this.Length == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail = penultimate;
            }
            penultimate.Next = null;
            Length--;

            return poppedTail;
        }

        public Node Shift()
        {
            if (this.Length == 0) return null;

            var oldHead = Head;
            Head = oldHead.Next;
            Length--;

            return oldHead;
        }

        public SinglyLinkedList Unshift(object val)
        {
            var newNode = new Node(val);
            AssignNodeToHead(newNode);
            Length++;

            return this;
        }

        public Node GetNode(int index)
        {
            if (index < 0 || index >= Length)
            {
                return null;
            }

            if (index == 0)
            {
                return Head;
            }
            var current = Head;
            var count = 0;
            while (!(index == count))
            {
                current = current.Next;
                count++;
            }

            return current;
        }

        public bool SetNode(int index, object val)
        {
            var node = GetNode(index);
            if (node != null)
            {
                node.Value = val;
                return true;
            }

            return false;
        }

        public bool Insert(int index, object val)
        {
            if (index < 0 || index > Length) return false;

            if (index == 0)
            {
                Unshift(val);
                return true;
            }

            if (index == Length)
            {
                Push(val);
                return true;
            }

            var previousNode = GetNode(index - 1);
            var nodeInCurrentTargetIndex = GetNode(index);
            var newNode = new Node(val);

            newNode.Next = nodeInCurrentTargetIndex;
            previousNode.Next = newNode;
            Length++;

            return true;
        }

        public Node Remove(int index)
        {
            if (index < 0 || index >= Length) return null;
            if (index == 0) return Shift();
            if (index == Length - 1) return Pop();

            var previousNode = GetNode(index - 1);
            var removedNode = GetNode(index);
            previousNode.Next = removedNode.Next;
            removedNode.Next = null;
            Length--;

            return removedNode;
        }

        public SinglyLinkedList Reverse()
        {
            var node = Head;
            Head = Tail;
            Tail = node;
            Node previous = null;
            Node next = null;
            for (var i = 0; i < Length; i++)
            {
                next = node.Next;
                node.Next = previous;
                previous = node;
                node = next;
            }

            return this;
        }

        private Node FindPenultimate()
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

        private void AssignNodeToHead(Node node)
        {
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                node.Next = Head;
                Head = node;
            }
        }

    }
}