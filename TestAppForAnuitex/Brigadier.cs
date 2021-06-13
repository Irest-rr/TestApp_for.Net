using System;

namespace TestAppForAnuitex
{
    class Brigadier : Employee
    {
        public Brigadier()
        {
            task = new TaskCheckWorkers();
        }

        public override void Work()
        {
            Console.WriteLine("Brigadier " + FullName + " is buying materials...");
        }
    }
}
