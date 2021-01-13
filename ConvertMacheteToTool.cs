using System;
using System.Collections.Generic;
using System.Text;

namespace AdapterMediator
{
    class ConvertMacheteToTool : ITool
    {
        private Machete machete;
        public ConvertMacheteToTool(Machete mac)
        {
            machete = mac;
        }
        public void Cut()
        {
            machete.Chop();
        }
    }
}
