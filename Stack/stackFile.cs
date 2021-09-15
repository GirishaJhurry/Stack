using System;
using System.Collections.Generic;

namespace Stack
{
    public class Jedi
    {
        private int id;
        private string name;
        public string nameid => $"Jedi-{name}:{id}";

    
        public Jedi(int id, string name)
        {
            this.id = id;
            this.name=name;
        }
    
    }


}