namespace polymorphism
{
    public class Engineer : EmployeeType
    {
        public override int Type { get { return ENGINEER; } }

        public override decimal GetPayAmount(Employee employee)
        {
            return employee.Salary;
        }
    }
}
