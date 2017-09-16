namespace _4.Work_Force
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using _4.Work_Force.Models;
    using _4.Work_Force.Models.Employees;

    public class Startup
    {
        public delegate void JobDoneEventHandler(object sender, JobEventArgs e);

        public static void Main()
        {
            var jobs = new JobsList();
            var emploees = new List<Employee>();

            var input = Console.ReadLine().Split();
            while (input[0] != "End")
            {
                switch (input[0])
                {
                    case "Job":
                        var realJob = new Job(input[1], int.Parse(input[2]), emploees.FirstOrDefault(e => e.Name == input[3]));
                        realJob.JobDone += realJob.OnJobDone;
                        jobs.Add(realJob);
                        break;
                    case "StandartEmployee":
                        emploees.Add(new StandartEmployee(input[1]));
                        break;
                    case "PartTimeEmployee":
                        emploees.Add(new PartTimeEmployee(input[1]));
                        break;
                    case "Pass":
                        foreach (var job in jobs)
                        {
                            job.Update();
                        }
                        break;
                    case "Status":
                        foreach (var job in jobs)
                        {
                            if (!job.IsDone)
                            {
                                Console.WriteLine(job.ToString());
                            }
                        }
                        break;
                }

                input = Console.ReadLine().Split();
            }
        }
    }
}
