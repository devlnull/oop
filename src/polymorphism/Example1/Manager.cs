namespace polymorphism
{
    public class Manager : EmployeeType
    {
        public override int Type { get { return MANAGER; } }

        public override decimal GetPayAmount(Employee employee)
        {
            return employee.Salary + employee.Bonus;
        }
    }
}
