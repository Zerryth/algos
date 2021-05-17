namespace CSharpAlgos
{
    public class Node
    {
        public Node(object val)
        {
            Value = val;
            Next = null;
        }

        public object Value { get; set; }

        public Node Next { get; set; }
    }
}