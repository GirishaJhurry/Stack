using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class CustomStack<T>
    {
        public int top;
        public T[] items = new T[10];
        public int internalIndex = -1;

        public void Push(T word)
        {
            items[++internalIndex] = word;
        }

        public T Pop()
        {
            return items[internalIndex--];
        }

        public int Count()
        {
            return internalIndex + 1;
        }
    }
}
