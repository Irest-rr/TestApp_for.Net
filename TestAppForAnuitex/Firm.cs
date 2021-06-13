using System.Collections.Generic;

namespace TestAppForAnuitex
{
    public class Firm
    {
        public List<Employee> Employees { get; set; }

        public Firm() {
            Employees = new List<Employee>();
        }

        public static Firm operator + (Firm firm, Employee employee)
        {
            firm.Employees.Add(employee);
            return firm;
        }

        public static Firm operator -(Firm firm, Employee employee)
        {
            firm.Employees.Remove(employee);
            return firm;

        }

        public static List<int> GetEmployeesId<T>(List<Employee> employees)
        {
            List<int> temp = new List<int>();
            for (int i = 0; i < employees.Count; i++)
            {
                if (typeof(T).Equals(employees[i].GetType()))
                    temp.Add(i);
            }
            return temp;
        }

        public List<Employee> GetEmployeesByType<T>() {
            var sequance = GetEmployeesId<T>(Employees);
            List<Employee> employeeList = new List<Employee>();
            foreach (var item in sequance)
                employeeList.Add(Employees[item]);
            return employeeList;
        }

        public int GetCountEmploeesByType<T>()
        {
            return GetEmployeesId<T>(Employees).Count;
        }
    }

}
