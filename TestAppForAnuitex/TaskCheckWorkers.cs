using System;

namespace TestAppForAnuitex
{
    class TaskCheckWorkers : IAdditionalTask
    {
        public void DoTask()
        {
            Console.WriteLine("Brigadier is Checking workers...");
        }
    }
}
