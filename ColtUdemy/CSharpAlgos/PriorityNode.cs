namespace CSharpAlgos
{
    public class PriorityNode
    {
        public PriorityNode(object value, int priority)
        {
            Value = value;
            Priority = priority;
        }

        public int Priority { get; set; }

        public object Value { get; set; }
    }
}