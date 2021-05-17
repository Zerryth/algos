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
            var sll = new SinglyLinkedList();
            sll.Push("RED");
            // sll.Push("ORANGE");
            // sll.Push("YELLOW");
            // sll.Push("GREEN");
            var popped = sll.Pop();
            Console.WriteLine($"SLL length: {sll.Length}");
            // Console.WriteLine($"SLL tail: {sll.Tail.Value}, SLL length: {sll.Length}");
            Console.WriteLine($"Popped tail: {popped.Value}");
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
