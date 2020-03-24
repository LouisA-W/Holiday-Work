using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NodeStack
{
    class Program
    {
        class Stack
        {
            private int top;
            private static int MaxSize;
            string[] stack = new string[MaxSize];
            public void push(string Data)
            {
                if (top >= MaxSize)
                {
                    Console.WriteLine("The stack is full");
                }
                else
                {
                    stack[top++] = Data;
                }
            }
            public string pop()
            {
                if (top == 0)
                {
                    Console.WriteLine("The stack is empty");
                    return null;
                }
                else
                {
                    string value;
                    value = stack[top--];
                    return value;
                }
            }

        }
        class Node : Stack
        {
            private string Data;
            public Node(string data)
            {
                Data = data;
            }

            public string getData() => Data;
        }
        static void Main(string[] args)
        {
        }
    }
}
