using System;

namespace AdapterMediator
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokia phone = new Nokia();

            WoodCutter Johnny = new WoodCutter(phone);
            HerbPicker Helen = new HerbPicker(phone);

            Axe BestAxe = new Axe();
            Johnny.PassThrough(BestAxe);

            Machete BestMachete = new Machete();
            ITool newExperimentalTool = new ConvertMacheteToTool(BestMachete);
            Johnny.PassThrough(newExperimentalTool);

            var JohnniesOperation = Operation.Ready;
            Johnny.Call(JohnniesOperation);

            Helen.CollectHerb();
            var HelenOperation = Operation.NotReady;
            Helen.Call(HelenOperation);

            Helen.ShowLogs();

            var HelenOperation2 = Operation.Ready;
            Helen.Call(HelenOperation2);

            Johnny.ShowLogs();

            Console.Read();
        }
    }
}
