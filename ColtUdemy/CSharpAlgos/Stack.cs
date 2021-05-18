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

        public void Pop()
        {

        }
    }
}