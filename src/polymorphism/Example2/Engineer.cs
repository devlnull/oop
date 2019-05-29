namespace polymorphism.e2
{
    public class Engineer : Employee
    {
        public override EmployeeType GetEmployeeType() => EmployeeType.ENGINEER;

        public override decimal GetPayAmount()
        {
            return this.Salary;
        }
    }
}
