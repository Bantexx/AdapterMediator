using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterMediator
{
    class WoodCutter : Worker
    {
        public WoodCutter(Mobile mob):base(mob) 
        {

        }
        public void PassThrough(ITool tool)
        {
            tool.Cut();
        }
        public override string Log(Operation op)
        {
            string message = "От Лесника: " + op;
            Console.WriteLine(message);
            return message;
        }
    }
}
