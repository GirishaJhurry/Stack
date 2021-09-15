using System;
using System.Collections.Generic;
using System.Text;

namespace Stack
{
    class CSExtendedOP
    {
        public static void DisplayAllInternsNameandId(CustomStack<Jedi> Stack)
        { 
            while (Stack.Count()>0)
            {
                var item = Stack.Pop();
                Console.WriteLine(item.nameid);
            }
        }
    }
}
