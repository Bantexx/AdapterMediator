using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterMediator
{
    class HerbPicker : Worker
    {
        public HerbPicker(Mobile mob) : base(mob)
        {

        }
        public void CollectHerb()
        {
            Console.WriteLine("Собрать траву");
        }
        public override string Log(Operation op)
        {
            string message = "От Травника: " + op;
            Console.WriteLine(message);
            return message;
        }
    }
}
