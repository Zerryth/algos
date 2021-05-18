using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace CSharpAlgos
{
    class Program
    {
        static void Main(string[] args)
        {
            // var sll = new SinglyLinkedList();
            // sll.Push("RED");
            // sll.Push("ORANGE");
            // sll.Push("YELLOW");
            // sll.Push("GREEN");
            // sll.Push("BLUE");

            // var doublyList = new DoublyLinkedList();
            // doublyList.Push("RED");
            // doublyList.Push("ORANGE");
            // doublyList.Push("YELLOW");
            // doublyList.Push("GREEN");
            // var added = doublyList.Unshift("HOY");

            // var stack = new Stack();
            // var firstPush = stack.Push("RED");
            // var secondPush = stack.Push("ORANGE");
            // var thirdPush = stack.Push("YELLOW");

            // var firstPop = stack.Pop();
            // var secondPop = stack.Pop();
            // var thirdPop = stack.Pop();
            // var fourthPop = stack.Pop();

            // Console.WriteLine($"firstPush {firstPush}, secondPush {secondPush}");
            // Console.WriteLine($"firstPop: {firstPop}, secondPop {secondPop}, thirdPop {thirdPop}, fourthPop {fourthPop}");

            var q = new Queue();
            var firstq = q.Enqueue("RED");
            var secondq = q.Enqueue("ORANGE");
            var thirdq = q.Enqueue("YELLOW");

            Console.WriteLine($"first q {firstq}, second q {secondq}, third q {thirdq}");

            var deq = q.Dequeue();
            var deq2 = q.Dequeue();

            Console.WriteLine($"deq {deq}, deq2 {deq2}");
            Console.WriteLine(q.Size);
        }

        internal static double GetMin(double a, double b)
        {
            if (b < a)
            {
                return b;
            }

            return a;
        }

        internal static int GetMax(int a, int b)
        {
            if (b > a)
            {
                return b;
            }

            return a;
        }
    }
}
