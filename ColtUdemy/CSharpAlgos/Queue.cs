namespace CSharpAlgos
{
    // add from the end and remove from the beginning
    public class Queue
    {
        public Queue()
        {
            First = null;
            Last = null;
            Size = 0;
        }

        public Node First { get; set; }

        public Node Last { get; set; }

        public int Size { get; set; }

        /// <summary>Adds to the end of our SLL.</summary>
        public int Enqueue(object val)
        {
            var node = new Node(val);

            if (Size == 0)
            {
                First = node;
                Last = node;
            }
            else
            {
                Last.Next = node;
                Last = node;
            }

            return ++Size;
        }

        /// <summary>Removes from the beginning of our SLL.</summary>
        public object Dequeue()
        {
            if (Size == 0) return null;

            var removedNode = First;
            if (First == Last) Last = null;

            First = First.Next;
            Size--;

            return removedNode.Value;
        }
    }
}