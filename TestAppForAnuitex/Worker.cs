using System;

namespace TestAppForAnuitex
{
    class Worker : Employee
    {
        public Worker()
        {
            task = new TaskDoesntExist();
        }

        public override void Work()
        {
            Console.WriteLine("Worker " + FullName + " making products...");
        }
    }
}
