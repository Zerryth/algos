namespace CSharpAlgos
{
    public class DLLNode : Node
    {
        public DLLNode(object val)
            : base(val)
        {
            Previous = null;
        }

        public DLLNode Previous { get; set; }
    }
}