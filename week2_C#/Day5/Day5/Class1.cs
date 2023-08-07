using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day5
{
    internal class myStack
    {
        int[] stk;
        int topOfStack;
        public myStack()
        {
            stk = new int[3];
            topOfStack = 0;
        }
        public myStack(int size)
        {
            stk = new int[size];
            topOfStack = 0;
        }
        public void push(int v)
        {
            if (topOfStack < stk.Length)
            {
                stk[topOfStack++] = v;
            }
            else
            {
                Console.WriteLine("The stack is full");
            }
        }
        public int pop()
        {
            if (topOfStack > 0)
            {
                topOfStack--;
                return stk[topOfStack];
            }
            else
            {
                Console.WriteLine("stack is empty");
                return -1;
            }
        }
    }
}
