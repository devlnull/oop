namespace polymorphism.e2
{
    public class Salesman : Employee
    {
        public override EmployeeType GetEmployeeType() => EmployeeType.SALESMAN;

        public override decimal GetPayAmount()
        {
            return this.Salary + this.Commission;
        }
    }
}
