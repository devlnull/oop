using System;
using System.Collections.Generic;

namespace polymorphism.e2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>();
            var engineer = new Engineer();
            engineer.AddSalary(70000000);
            var manager = new Manager();
            manager.AddSalary(150000000);
            manager.AddBonus(50000000);
            var salesman = new Salesman();
            salesman.AddSalary(120000000);
            salesman.AddCommission(40000000);
            employees.Add(engineer);
            employees.Add(manager);
            employees.Add(salesman);

            foreach(var emp in employees)
                Console.WriteLine($"{emp.GetEmployeeType()} got {emp.GetPayAmount()}");
        }
    }
}
