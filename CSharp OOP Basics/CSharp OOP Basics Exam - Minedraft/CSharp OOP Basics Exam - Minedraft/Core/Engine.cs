namespace CSharp_OOP_Basics_Exam___Minedraft.Core
{
    using System;
    using System.Linq;

    public class Engine
    {
        private DraftManager manager;

        public Engine(DraftManager manager)
        {
            this.manager = manager;
        }

        public void Run()
        {
            var isRunning = true;
            while (isRunning)
            {
                var input = Console.ReadLine().Split().ToList();
                var command = input[0];
                input.RemoveAt(0);
                string result = null;

                switch (command)
                {
                    case "RegisterHarvester":
                        result = this.manager.RegisterHarvester(input);
                        break;
                    case "RegisterProvider":
                        result = this.manager.RegisterProvider(input);
                        break;
                    case "Day":
                        result = this.manager.Day();
                        break;
                    case "Mode":
                        result = this.manager.Mode(input);
                        break;
                    case "Check":
                        result = this.manager.Check(input);
                        break;
                    case "Shutdown":
                        result = this.manager.ShutDown();
                        isRunning = false;
                        break;
                }

                Console.WriteLine(result);
            }
        }
    }
}
