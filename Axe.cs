using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterMediator
{
    class Axe : ITool
    {
        public void Cut()
        {
            Console.WriteLine("Рубим дерево");
        }
    }
}
