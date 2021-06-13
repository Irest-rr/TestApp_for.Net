using System;

namespace TestAppForAnuitex
{
    class TaskGiveTask : IAdditionalTask
    {
        public void DoTask()
        {
            Console.WriteLine("Manager gave a task...");
        }
    }
}
