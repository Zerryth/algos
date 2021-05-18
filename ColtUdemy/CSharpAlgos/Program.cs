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

            var stack = new Stack();
            var firstPush = stack.Push("RED");
            var secondPush = stack.Push("ORANGE");

            Console.WriteLine($"firstPush {firstPush}, secondPush {secondPush}");
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
