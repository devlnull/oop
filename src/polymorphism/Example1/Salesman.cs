namespace polymorphism
{
    public class Salesman : EmployeeType
    {
        public override int Type { get { return SALESMAN; } }

        public override decimal GetPayAmount(Employee employee)
        {
            return employee.Salary + employee.Commision;
        }
    }
}
