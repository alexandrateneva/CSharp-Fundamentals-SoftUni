namespace _4.Work_Force.Models.Employees
{
    public class StandartEmployee : Employee
    {
        private const int WorkHoursPerWeekConst = 40;

        public override int WorkHoursPerWeek => WorkHoursPerWeekConst;

        public StandartEmployee(string name)
            : base(name)
        {
        }
    }
}
