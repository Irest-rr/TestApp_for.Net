using System;

namespace TestAppForAnuitex
{
    class Manager : Employee
    {
        public Manager()
        {
            task = new TaskGiveTask();
        }

        public override void Work()
        {
            Console.WriteLine("Manager " + FullName + " is collecting orders...");
        }
    }
}
