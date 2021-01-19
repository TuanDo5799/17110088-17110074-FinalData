using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARO
{
    internal class MyStack<T>
    {
        static readonly int MAX = 1000;
        int top;
        playInfo[] stack = new playInfo[MAX];

        bool IsEmpty()
        {
            return (top < 0);
        }
        public MyStack()
        {
            top = -1;
        }
        internal bool Push(playInfo data)
        {
            if (top >= MAX)
            {
                return false;
            }
            else
            {
                stack[++top] = data;
                return true;
            }
        }

        internal playInfo Pop()
        {
            if (top < 0)
            {
                return null;
            }
            else
            {
                playInfo value = stack[top--];
                return value;
            }
        }

        internal playInfo Peek()
        {
            if (top < 0)
            {
                return null;
            }
            else
                return stack[top];
        }
        internal int Count()
        {
            return top;
        }
    }
}
