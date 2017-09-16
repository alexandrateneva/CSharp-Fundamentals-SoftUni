namespace _4.Work_Force.Models
{
    using System;

    public class Job
    {
        public event Startup.JobDoneEventHandler JobDone;
    
        public string Name { get; private set; }
        public int WorkHoursRequired { get; private set; }
        public Employee Emploee { get; private set; }
        public bool IsDone { get; private set; }

        public Job(string name, int workHoursRequired, Employee emploee)
        {
            this.Name = name;
            this.WorkHoursRequired = workHoursRequired;
            this.Emploee = emploee;
            this.IsDone = false;
        }
    
        public void Update()
        {
            this.WorkHoursRequired -= this.Emploee.WorkHoursPerWeek;
            if (this.WorkHoursRequired <= 0 && !this.IsDone)
            {
                this.JobDone?.Invoke(this, new JobEventArgs(this));
            }
        }

        public void OnJobDone(object sender, JobEventArgs e)
        {
            Console.WriteLine($"Job {this.Name} done!");
            this.IsDone = true;
        }

        public override string ToString()
        {
            return $"Job: {this.Name} Hours Remaining: {this.WorkHoursRequired}";
        }
    }
}
