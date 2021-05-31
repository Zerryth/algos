using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;

namespace CSharpAlgos
{
    class Program
    {
        static void Main(string[] args)
        {
            var priorityQueue = new PriorityQueue(
                new List<PriorityNode>()
                {
                    new PriorityNode("sun", 1),
                    new PriorityNode("moon", 3),
                    new PriorityNode("stars", 4),
                    new PriorityNode("pluto", 7),
                    new PriorityNode("rainbow", 38),
                    new PriorityNode("whale", 30),
                }
            );
            priorityQueue.Enqueue("super hero", 0);
            var enq = priorityQueue.Enqueue("2dlez", 2);
            // Console.WriteLine($"top: {priorityQueue.Values[0].Value}");
            Console.WriteLine($"enqueued at idx: {enq}");
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

// var q = new Queue();
// var firstq = q.Enqueue("RED");
// var secondq = q.Enqueue("ORANGE");
// var thirdq = q.Enqueue("YELLOW");

// Console.WriteLine($"first q {firstq}, second q {secondq}, third q {thirdq}");

// var deq = q.Dequeue();
// var deq2 = q.Dequeue();

// Console.WriteLine($"deq {deq}, deq2 {deq2}");
// Console.WriteLine(q.Size);
