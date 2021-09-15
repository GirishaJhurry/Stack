using System;
using System.Collections.Generic;

namespace Stack
{
    class Program 
    { 
        static void Main(String[] args)
        {
            /*CustomStack<string> stack = new CustomStack<string>();

            stack.Push("Jedi");
            stack.Push("Skillslab");

            while (stack.Count()>0)
            {
                var item = stack.Pop();
                Console.WriteLine(item);
            }*/

            CustomStack<Jedi> intern = new CustomStack<Jedi>();

            intern.Push(new Jedi(1, "Girisha"));
            intern.Push(new Jedi(2, "Aashish"));
            intern.Push(new Jedi(3, "Kashiff"));

            CSExtendedOP.DisplayAllInternsNameandId(intern);

        }
    }
}
