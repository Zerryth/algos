namespace CSharpAlgos
{
    public class Stack
    {
        public Stack()
        {
            First = null;
            Last = null;
            Size = 0;
        }

        public Node First { get; set; }

        public Node Last { get; set; }

        public int Size { get; set; }

        // ORG First
        // RED  oldFirst
        public int Push(object val)
        {
            var newNode = new Node(val);
            if (First == null)
            {
                First = newNode;
                Last = newNode;
            }
            else
            {
                var oldFirst = First;
                First = newNode;
                First.Next = oldFirst;
            }

            return ++Size;
        }

        // last RED first 
        // 
        // 
        public object Pop()
        {
            if (First == null) return null;

            var poppedNode = First;
            if (First == Last) Last = null;

            First = First.Next;
            Size--;

            return poppedNode.Value;
        }
    }
}