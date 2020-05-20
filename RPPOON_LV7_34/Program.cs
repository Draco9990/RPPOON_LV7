using System;

namespace RPPOON_LV7_34
{
    class Program
    {
        static void Main(string[] args)
        {
            SystemDataProvider systemDataProvider = new SystemDataProvider();
            systemDataProvider.Attach(new ConsoleLogger());
            while (true)
            {
                systemDataProvider.GetCPULoad();
                systemDataProvider.GetAvailableRAM();
                System.Threading.Thread.Sleep(1000);
            }
        }
    }
}
