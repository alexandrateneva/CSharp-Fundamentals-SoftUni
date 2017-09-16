namespace _4.Work_Force.Models
{
    public class JobEventArgs
    {
        public Job Job { get; private set; }

        public JobEventArgs(Job job)
        {
            this.Job = job;
        }
    }
}
