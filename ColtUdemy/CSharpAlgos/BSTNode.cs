namespace CSharpAlgos
{
    public class BSTNode
    {
        public BSTNode(object value)
        {
            Value = value;
            Left = null;
            Right = null;
        }

        public object Value { get; set; }

        public BSTNode Left { get; set; }
        public BSTNode Right { get; set; }
    }
}