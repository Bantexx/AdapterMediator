using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterMediator
{
    abstract class Mobile
    {
        public List<string> logs;
        public abstract void Call(Operation op, Worker worker);
    }
}
