using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterMediator
{
    abstract class Worker
    {
        public Mobile mobile;

        public Worker(Mobile mob)
        {
            mobile = mob;
        }
        public virtual void Call(Operation op)
        {
            mobile.Call(op,this);
        }
        public abstract string Log(Operation op);

        public  List<string> ShowLogs()
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Вызов лога от: " + GetType().Name);
            foreach (var l in mobile.logs)
            {
                Console.WriteLine(l);
            }
            Console.WriteLine("-----------------------");
            return mobile.logs;
        }
        
    }
}
