using System;
using System.Linq;

namespace TestAppForAnuitex
{
    public static class Extention
    {
        public static bool IsExist(this Firm firm, Employee emp) =>
            firm.Employees.Contains(emp);

        public static void GetAllWorkersList(this Firm firm)
        {
            var sequance = firm.Employees.Select(emp => new { fullName = emp.FullName, experience = emp.Experience });
            foreach (var emp in sequance)
                Console.WriteLine(emp.fullName + "  experience - " + emp.experience);
        }
    }
}
