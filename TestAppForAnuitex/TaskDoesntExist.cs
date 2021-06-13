using System;

namespace TestAppForAnuitex

{
    class TaskDoesntExist : IAdditionalTask
    {
        public void DoTask()
        {
            Console.WriteLine("**Additioan task doesnt exist**");
        }
    }
}
