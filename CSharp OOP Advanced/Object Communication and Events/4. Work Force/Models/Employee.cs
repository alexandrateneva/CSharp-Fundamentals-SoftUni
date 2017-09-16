namespace _4.Work_Force.Models
{
    public abstract class Employee
    {
        public string Name { get; private set; }
        public abstract int WorkHoursPerWeek { get; }

        protected Employee(string name)
        {
            this.Name = name;
        }
    }
}