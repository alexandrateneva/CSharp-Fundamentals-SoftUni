namespace _3.Barracks_Wars.Core
{
    using System;
    using _3.Barracks_Wars.Core.Commands;
    using _3.Barracks_Wars.Interfaces;

    class Engine : IRunnable
    {
        private IRepository repository;
        private IUnitFactory unitFactory;

        public Engine(IRepository repository, IUnitFactory unitFactory)
        {
            this.repository = repository;
            this.unitFactory = unitFactory;
        }

        public void Run()
        {
            while (true)
            {
                try
                {
                    string input = Console.ReadLine();
                    string[] data = input.Split();
                    string commandName = data[0];
                    string result = this.InterpredCommand(data, commandName);
                    Console.WriteLine(result);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }

        // TODO: refactor for Problem 4
        private string InterpredCommand(string[] data, string commandName)
        {
            string result = string.Empty;
            Command command;

            switch (commandName)
            {
                case "add":
                    command = new Add(data, this.repository, this.unitFactory);
                    break;
                case "report":
                    command = new Report(data, this.repository);
                    break;
                case "fight":
                    command = new Fight();
                    break;
                case "retire":
                    command = new Retire(data, this.repository);
                    break;
                default:
                    throw new InvalidOperationException("Invalid command!");
            }
            
            result = command.Execute();
            return result;
        }

    }
}
