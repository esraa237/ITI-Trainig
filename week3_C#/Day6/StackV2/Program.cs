using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6
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
        public int this[int index]
        {
            get { return stk[index]; }
        }
        public static myStack operator +(myStack stack1, myStack stack2)
        {
            int size = stack1.stk.Length + stack2.stk.Length;
            var stack = new myStack(size);
            for (int i = 0; i < stack1.stk.Length; i++)
            {
                stack.push(stack1[i]);
            }
            for (int i = 0; i < stack2.stk.Length; i++)
            {
                stack.push(stack2[i]);
            }
            return stack;
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
    internal class Program
    {
        static void Main(string[] args)
        {
            myStack stack1 = new myStack();
            myStack stack2 = new myStack();
            stack1.push(1);
            stack1.push(2);
            stack1.push(3);
            stack2.push(3);
            stack2.push(4);
            stack2.push(5);
            myStack stack3 = stack1 + stack2;
            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine(stack3.pop());
            }
            Console.ReadKey();
        }
    }
}
