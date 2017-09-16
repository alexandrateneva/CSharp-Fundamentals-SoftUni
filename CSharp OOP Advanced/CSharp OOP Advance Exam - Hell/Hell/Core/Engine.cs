using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Hell.Core
{
    using Hell.Interfaces;
    using Hell.Interfaces.IO;

    public class Engine
    {
        private IInputReader reader;
        private IOutputWriter writer;
        private IManager heroManager;

        public Engine(IInputReader reader, IOutputWriter writer, IManager heroManager)
        {
            this.reader = reader;
            this.writer = writer;
            this.heroManager = heroManager;
        }

        public void Run()
        {
            bool isRunning = true;

            while (isRunning)
            {
                string inputLine = this.reader.ReadLine();
                List<string> arguments = this.parseInput(inputLine);
                this.writer.AppendLine(this.processInput(arguments));
                if (inputLine == "Quit")
                {
                    break;
                }
            }

            this.writer.Write();
        }

        private List<string> parseInput(string input)
        {
            return input.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        }

        private string processInput(IList<string> arguments)
        {
            string command = arguments[0];
            arguments.RemoveAt(0);

            string nameOfCommand = command + "Command";

            Type commandType = Assembly.GetExecutingAssembly().GetTypes()
                .FirstOrDefault(t => t.Name.Equals(nameOfCommand, StringComparison.OrdinalIgnoreCase));
            var constructor = commandType.GetConstructor(new Type[] { typeof(IList<string>), typeof(IManager) });
            IExecutable cmd = (IExecutable)constructor.Invoke(new object[] { arguments, this.heroManager });

            return cmd.Execute();
        }
    }
}