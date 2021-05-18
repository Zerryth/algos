namespace CSharpAlgos
{
    public class DoublyLinkedList
    {
        public DoublyLinkedList()
        {
            Head = null;
            Tail = null;
            Length = 0;
        }

        public DLLNode Head { get; set; }

        public DLLNode Tail { get; set; }

        public int Length { get; set; }

        public DoublyLinkedList Push(object val)
        {
            var node = new DLLNode(val);
            if (Head == null)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Tail.Next = node;
                node.Previous = Tail;
                Tail = node;
            }

            Length++;

            return this;
        }

        public DLLNode Pop()
        {
            if (Length == 0) return null;

            var poppedNode = Tail;
            if (Length == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Tail = poppedNode.Previous;
                Tail.Next = null;
                poppedNode.Previous = null;
            }

            Length--;

            return poppedNode;
        }

        /// <summary>Remove node from beginning of DoublyLinkedList</summary>
        public DLLNode Shift()
        {
            if (Length <= 0) return null;

            var oldHead = Head;
            if (Length == 1)
            {
                Head = null;
                Tail = null;
            }
            else
            {
                Head = (DLLNode)oldHead.Next;
                Head.Previous = null;
                oldHead.Next = null;
            }

            Length--;

            return oldHead;
        }

        // RED ORANGE
        /// <summary>Add node to beginning of DoublyLinkedList</summary>
        public DoublyLinkedList Unshift(object val)
        {
            var node = new DLLNode(val);

            if (Length == 0)
            {
                Head = node;
                Tail = node;
            }
            else
            {
                Head.Previous = node;
                node.Next = Head;
                Head = node;
            }

            Length++;

            return this;
        }
    }
}