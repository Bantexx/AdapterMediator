using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterMediator
{
    class Nokia : Mobile
    {
        public Nokia()
        {
            logs = new List<string>();
        }

        public override void Call(Operation op, Worker worker)
        {
            Type currtype = worker.GetType();
            logs.Add($" message by:{currtype.Name}:" + op);
            worker.Log(op);
        }
    }
}
