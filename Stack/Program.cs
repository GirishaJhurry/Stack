using System;
using System.Collections.Generic;

namespace Stack
{
    class Program 
    { 
        static void Main(string[] args)
        {
            CustomStack stack = new CustomStack();

            stack.Push("Jedi");
            stack.Push("Skillslab");

            while (stack.Count()>0)
            {
                var item = stack.Pop();
                Console.WriteLine(item);
            }
        }
    }
}
