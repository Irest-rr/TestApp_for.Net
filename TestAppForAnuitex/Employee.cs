namespace TestAppForAnuitex
{
    public abstract class Employee
    {
        public IAdditionalTask task;

        public Employee() { }

        public string FullName {get; set;}
        public int Experience { get; set; }


        public abstract void Work();
        public void DoTask()
        {
            task.DoTask();
        }
    }
}
