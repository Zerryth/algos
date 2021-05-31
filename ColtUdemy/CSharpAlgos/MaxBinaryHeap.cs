using System;
using System.Collections.Generic;

namespace CSharpAlgos
{
    public class MaxBinaryHeap
    {
        public MaxBinaryHeap(List<int> values)
        {
            Values = values;
        }

        public List<int> Values { get; set; }

        public int Insert(int value)
        {
            Values.Add(value);
            return BubbleUp(Values.Count - 1);
        }

        // Also known as ExtractMax()
        // TODO finish recursive version
        public int Remove()
        {
            var removed = Values[0];
            SwapRootWithLastLeaf();
            BubbleDown(0);

            return removed;
        }

        public int Remove2()
        {
            var max = Values[0];
            var end = PopEnd();
            if (Values.Count > 0)
            {
                Values[0] = end;
                SinkDown();
            }

            return max;
        }

        private int BubbleUp(int index)
        {
            // var parentIdx = (int)Math.Floor(
            //     (double)(index - 1) / 2
            // );
            var parentIdx = (index - 1) / 2;
            var oldParentVal = Values[parentIdx];

            if (!IsGreaterThanParent(index, oldParentVal)) return index;

            // Swap bigger value with smaller parent, bubbling up heap
            Values[parentIdx] = Values[index];
            Values[index] = oldParentVal;

            return BubbleUp(parentIdx);
        }

        private int PopEnd()
        {
            var endIdx = Values.Count - 1;
            var endVal = Values[endIdx];
            Values.RemoveAt(endIdx);

            return endVal;
        }

        private void SinkDown()
        {
            var index = 0;
            var current = Values[0];
            while (true)
            {
                var leftChildIdx = GetLeftIdx(index);
                var rightChildIdx = GetRightIdx(index);
                var leftVal = -1;
                var rightVal = -1;
                var swap = -1;

                if (IsWithinBounds(leftChildIdx))
                {
                    leftVal = Values[leftChildIdx];
                    if (leftVal > current)
                    {
                        swap = leftChildIdx;
                    }
                }

                if (IsWithinBounds(rightChildIdx))
                {
                    rightVal = Values[rightChildIdx];
                    // swap was never set to L child OR was swapped but Right child is larger than Left
                    if (
                        (swap == -1 && rightVal > current) ||
                        (swap != -1 && rightVal > leftVal)
                    )
                    {
                        swap = rightChildIdx;
                    }
                }

                if (swap == -1) break;
                Values[index] = Values[swap];
                Values[swap] = current;
                index = swap;
            }
        }


        private void SwapRootWithLastLeaf()
        {
            var lastIdx = Values.Count - 1;
            Values[0] = Values[lastIdx];
            Values.RemoveAt(lastIdx);
        }

        // TODO finish recursive version
        private void BubbleDown(int index)
        {
            var current = Values[index];
            var leftIdx = GetLeftIdx(index);
            var leftVal = Values[leftIdx];
            var rightIdx = GetRightIdx(index);
            var rightVal = Values[rightIdx];

            if (leftVal > current && rightVal > current)
            {
                var bubbleDownTarget = GetGreaterIdx(rightIdx, leftIdx);
                var greaterVal = Values[bubbleDownTarget];
                Values[bubbleDownTarget] = current;
                Values[index] = greaterVal;
            }

        }

        private bool IsGreaterThanParent(int index, int parent) => Values[index] > parent;

        private int GetLeftIdx(int index) => 2 * index + 1;

        private int GetRightIdx(int index) => 2 * index + 2;

        private int GetGreaterIdx(int index1, int index2)
        {
            if (index2 > index1) return index2;

            return index1;
        }

        private bool IsWithinBounds(int index) => index < Values.Count;
    }
}

// var maxBinHeap = new MaxBinaryHeap(new List<int>() {
//     41, 39, 33, 18, 27, 12
// });
// var res = maxBinHeap.Insert(55);
// maxBinHeap.Remove2();
// var look = maxBinHeap.Values[0];
// Console.WriteLine(look);