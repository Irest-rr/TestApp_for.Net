using System;

namespace TestAppForAnuitex
{
    class Program
    {
        static void Main(string[] args)
        {
            Firm Xfrim = new Firm();

            Employee stive = new Brigadier
            {
                FullName = "Stive Roger",
                Experience = 4
            };

            Employee bob = new Manager
            {
                FullName = "bob simence",
                Experience = 10
            };

            Employee ken = new Manager
            {
                FullName = "Ken Roof",
                Experience = 10
            };

            Employee patrick = new Worker
            {
                FullName = "Ken Roof",
                Experience = 10
            };

            Xfrim += stive;
            Xfrim += bob;
            Xfrim += ken;
            Xfrim += patrick;
       
            Xfrim.GetAllWorkersList();
            Console.WriteLine("=====================");

            Xfrim -= bob;
            Xfrim.GetAllWorkersList();
            Console.WriteLine("=====================");

            var temp = Xfrim.GetEmployeesByType<Manager>();         //
            foreach (var item in temp)                              // Use method and output to the screen employees by type
                Console.WriteLine(item.FullName + " experiance - " + item.Experience); //

            Console.WriteLine("=====================");

            Console.WriteLine("Count ---- " + Xfrim.GetCountEmploeesByType<Brigadier>()); // Use method and output to the screen count employees by type
       
            Console.WriteLine(Xfrim.IsExist(stive)); // does an employee
            Console.WriteLine(Xfrim.IsExist(ken));   // exist in the company

            Console.WriteLine("=====================");

            Xfrim.GetAllWorkersList();  // get all list employees in the firm

            Console.WriteLine("=====================");

            stive.Work();
            ken.Work();
            patrick.Work();

            Console.WriteLine("=====================");

            stive.DoTask();
            ken.DoTask();
            patrick.DoTask();

            Console.ReadLine();
        }
    }
}
