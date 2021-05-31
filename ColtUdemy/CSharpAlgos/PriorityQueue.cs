using System.Collections.Generic;

namespace CSharpAlgos
{
    // Will use a MinBinaryHeap
    // Lower the number, the higher the priority
    public class PriorityQueue
    {
        public PriorityQueue(List<PriorityNode> values)
        {
            Values = values;
        }

        public List<PriorityNode> Values { get; set; }

        public int Enqueue(object value, int priority)
        {
            var newNode = new PriorityNode(value, priority);
            Values.Add(newNode);
            return BubbleUp(Values.Count - 1);
        }

        // TODO implement Dequeue

        private int BubbleUp(int index)
        {
            var parentIdx = (index - 1) / 2;
            var parentNode = Values[parentIdx];

            if (!IsGreaterPriorityThanParent(index, parentNode)) return index;

            // Swap curr. value, since it is higher priority
            Values[parentIdx] = Values[index];
            Values[index] = parentNode;

            return BubbleUp(parentIdx);
        }

        /// The smaller the priority value, the greater the priority.
        private bool IsGreaterPriorityThanParent(int index, PriorityNode parent) => Values[index].Priority < parent.Priority;
    }
}