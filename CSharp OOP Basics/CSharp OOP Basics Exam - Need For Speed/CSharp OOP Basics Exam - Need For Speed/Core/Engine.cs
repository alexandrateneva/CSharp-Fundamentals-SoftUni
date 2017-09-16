namespace CSharp_OOP_Basics_Exam___Need_For_Speed.Core
{
    using System;

    public class Engine
    {
        private CarManager manager;

        public Engine()
        {
            this.manager = new CarManager();
        }

        public void Run()
        {
            string command = String.Empty;

            while ((command = Console.ReadLine()) != "Cops Are Here")
            {
                var cmdArg = command.Split(' ');
                this.ExecuteCommand(cmdArg);
            }
        }

        public void ExecuteCommand(string[] cmdArgs)
        {
            int id;
            string type;
            int raceId;

            switch (cmdArgs[0])
            {
                case "register":
                    id = int.Parse(cmdArgs[1]);
                    type = cmdArgs[2];
                    var brand = cmdArgs[3];
                    var model = cmdArgs[4];
                    var yearOfProduction = int.Parse(cmdArgs[5]);
                    var horsepower = int.Parse(cmdArgs[6]);
                    var acceleration = int.Parse(cmdArgs[7]);
                    var suspension = int.Parse(cmdArgs[8]);
                    var durability = int.Parse(cmdArgs[9]);
                    this.manager.Register(id, type, brand, model, yearOfProduction, horsepower, acceleration, suspension, durability);
                    break;
                case "check":
                    Console.WriteLine(this.manager.Check(int.Parse(cmdArgs[1])));
                    break;
                case "open":
                    id = int.Parse(cmdArgs[1]);
                    type = cmdArgs[2];
                    var lenght = int.Parse(cmdArgs[3]);
                    var route = cmdArgs[4];
                    var pricePool = int.Parse(cmdArgs[5]);
                    this.manager.Open(id, type, lenght, route, pricePool);
                    break;
                case "participate":
                    var carId = int.Parse(cmdArgs[1]);
                    raceId = int.Parse(cmdArgs[2]);
                    this.manager.Participate(carId, raceId);
                    break;
                case "start":
                    raceId = int.Parse(cmdArgs[1]);
                    Console.WriteLine(this.manager.Start(raceId));
                    break;
                case "park":
                    id = int.Parse(cmdArgs[1]);
                    this.manager.Park(id);
                    break;
                case "unpark":
                    id = int.Parse(cmdArgs[1]);
                    this.manager.Unpark(id);
                    break;
                case "tune":
                    var tuneIndex = int.Parse(cmdArgs[1]);
                    var addon = cmdArgs[2];
                    this.manager.Tune(tuneIndex, addon);
                    break;
            }
        }
    }
}
