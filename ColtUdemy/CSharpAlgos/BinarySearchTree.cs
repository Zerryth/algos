using System.Collections.Generic;

namespace CSharpAlgos
{
    public class BinarySearchTree
    {
        public BinarySearchTree()
        {
            Root = null;
        }

        public BSTNode Root { get; set; }

        public BinarySearchTree Insert(object value)
        {
            var node = new BSTNode(value);

            if (Root == null)
            {
                Root = node;
                return this;
            }

            var current = Root;
            while (true)
            {
                // There are many ways to handle values that are equal
                // For now, we'll just do nothing and not insert
                if (value == current.Value) return null;
                // Move left (lesser values)
                if ((int)value < (int)current.Value)
                {
                    if (current.Left == null)
                    {
                        current.Left = node;
                        return this;
                    }
                    current = current.Left;
                }
                // Move right (greater values)
                else if ((int)value > (int)current.Value)
                {
                    if (current.Right == null)
                    {
                        current.Right = node;
                        return this;
                    }
                    current = current.Right;
                }
            }
        }

        public BSTNode Find(object value)
        {
            if (Root == null) return null;

            var current = Root;
            var found = false;
            while (current != null && !found)
            {
                if ((int)value < (int)current.Value)
                {
                    current = current.Left;
                }
                else if ((int)value > (int)current.Value)
                {
                    current = current.Right;
                }
                else
                {
                    found = true;
                }
            }

            if (!found) return null;

            return current;
        }

        public Queue<BSTNode> BreadthFirstSearch()
        {
            var data = new Queue<BSTNode>();
            var queue = new Queue<BSTNode>();
            var node = Root;

            queue.Enqueue(node);
            while (queue.Count > 0)
            {
                node = queue.Dequeue();
                data.Enqueue(node);
                if (node.Left != null) queue.Enqueue(node.Left);
                if (node.Right != null) queue.Enqueue(node.Right);
            }

            return data;
        }

        public List<BSTNode> DFSPreOrder()
        {
            var data = new List<BSTNode>();
            TraversePreOrder(Root, data);

            return data;
        }

        public List<BSTNode> DFSPostOrder()
        {
            var data = new List<BSTNode>();
            TraversePostOrder(Root, data);

            return data;
        }

        public List<BSTNode> DFSInOrder()
        {
            var data = new List<BSTNode>();
            TraverseInOrder(Root, data);

            return data;
        }

        private void TraversePreOrder(BSTNode node, List<BSTNode> data)
        {
            data.Add(node);
            if (node.Left != null) TraversePreOrder(node.Left, data);
            if (node.Right != null) TraversePreOrder(node.Right, data);
        }

        private void TraversePostOrder(BSTNode node, List<BSTNode> data)
        {
            if (node.Left != null) TraversePostOrder(node.Left, data);
            if (node.Right != null) TraversePostOrder(node.Right, data);
            data.Add(node);
        }

        private void TraverseInOrder(BSTNode node, List<BSTNode> data)
        {
            if (node.Left != null) TraverseInOrder(node.Left, data);
            data.Add(node);
            if (node.Right != null) TraverseInOrder(node.Right, data);
        }
    }
}

// var tree = new BinarySearchTree();
// tree.Insert(10);
// tree.Insert(6);
// tree.Insert(15);
// tree.Insert(3);
// tree.Insert(8);
// tree.Insert(20);
// var res = tree.DFSPreOrder();
// Console.WriteLine(tree);
// expected output for PreOrder [10, 6, 3, 8, 15, 20]
// expected output for PreOrder [3, 8, 6, 20, 15, 10]
