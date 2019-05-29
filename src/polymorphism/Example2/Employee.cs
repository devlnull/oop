using System;

namespace polymorphism.e2
{
    public abstract class Employee
    {
        public decimal Salary { get; set; }
        public decimal Commission { get; set; }
        public decimal Bonus { get; set; }

        public void AddSalary(decimal val) => Salary += val;
        public void AddCommission(decimal val) => Commission += val;
        public void AddBonus(decimal val) => Bonus += val;
        public abstract EmployeeType GetEmployeeType();
        public abstract decimal GetPayAmount();
    }
}
