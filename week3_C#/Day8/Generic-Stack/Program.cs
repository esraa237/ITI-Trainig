using System;

namespace Day8
{
    public class MyGenStack<T>
    {
        T[] stk;
        int topOfStack;
        public MyGenStack()
        {
            stk = new T[2];
            topOfStack = 0;
        }
        public MyGenStack(int size)
        {
            stk = new T[size];
            topOfStack = 0;
        }

        public void push(T v)
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
        public T pop()
        {
            if (topOfStack > 0)
            {
                topOfStack--;
                return stk[topOfStack];
            }
            else
            {
                Console.WriteLine("stack is empty");
                return default(T);
            }
        }
    }
    internal class Program
    {
        static void Main()
        {
            MyGenStack<int> stack = new MyGenStack<int>(5);
            stack.push(10);
            stack.push(20);
            stack.push(30);
            stack.push(40);
            Console.WriteLine(stack.pop()+"\n"+ stack.pop() +"\n" +
                stack.pop() +"\n"+ stack.pop());
    
        }
    }
}
