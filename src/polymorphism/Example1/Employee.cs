using System;

namespace polymorphism
{
    public class Employee
    {
        public EmployeeType EmployeeType { get; set; }
        public decimal Salary { get; set; }
        public decimal Commision { get; set; }
        public decimal Bonus { get; set; }

        public Employee(EmployeeType type)
        {
            this.EmployeeType = type;
        }

        public decimal GetPayAmount()
        {
            return EmployeeType.GetPayAmount(this);
        }
    }
}
