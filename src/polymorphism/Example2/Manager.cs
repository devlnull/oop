namespace polymorphism.e2
{
    public class Manager : Employee
    {
        public override EmployeeType GetEmployeeType() => EmployeeType.MANAGER;
        public override decimal GetPayAmount()
        {
            return this.Salary + this.Bonus;
        }
    }
}
