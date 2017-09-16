namespace _4.Work_Force.Models.Employees
{
    public class PartTimeEmployee : Employee
    {
        private const int WorkHoursPerWeekConst = 20;

        public override int WorkHoursPerWeek => WorkHoursPerWeekConst;

        public PartTimeEmployee(string name)
            : base(name)
        {
        }
    }
}
