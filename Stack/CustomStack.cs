using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class CustomStack
    {
        public int top;
        public string[] items = new string[10];
        public int internalIndex = -1;

        public void Push(string word)
        {
            items[++internalIndex] = word;
        }

        public string Pop()
        {
            return items[internalIndex--];
        }

        public int Count()
        {
            return internalIndex + 1;
        }
    }
}
