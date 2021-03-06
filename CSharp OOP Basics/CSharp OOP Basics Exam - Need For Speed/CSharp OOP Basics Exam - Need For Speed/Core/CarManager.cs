﻿namespace CSharp_OOP_Basics_Exam___Need_For_Speed.Core
{
    using System.Collections.Generic;
    using System.Linq;
    using CSharp_OOP_Basics_Exam___Need_For_Speed.Models;
    using CSharp_OOP_Basics_Exam___Need_For_Speed.Models.Cars;
    using CSharp_OOP_Basics_Exam___Need_For_Speed.Models.Races;

    public class CarManager
    {
        private Dictionary<int, Car> cars;
        private Dictionary<int, Race> races;
        private Garage garage;

        private List<int> racesClosed;

        public CarManager()
        {
            this.cars = new Dictionary<int, Car>();
            this.races = new Dictionary<int, Race>();
            this.garage = new Garage();
            this.racesClosed = new List<int>();
        }

        public void Register(int id, string type, string brand, string model, int yearOfProduction, int horsepower, int acceleration, int suspension, int durability)
        {
            if (type == "Performance")
            {
                this.cars.Add(id, new PerformanceCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability));
            }
            else
            {
                this.cars.Add(id, new ShowCar(brand, model, yearOfProduction, horsepower, acceleration, suspension, durability));
            }
        }

        public string Check(int id)
        {
            return this.cars[id].ToString();
        }

        public void Open(int id, string type, int length, string route, int prizePool)
        {
            switch (type)
            {
                case "Casual":
                    this.races.Add(id, new CasualRace(length, route, prizePool));
                    break;
                case "Drag":
                    this.races.Add(id, new DragRace(length, route, prizePool));
                    break;
                case "Drift":
                    this.races.Add(id, new DriftRace(length, route, prizePool));
                    break;
            }
        }

        public void Participate(int carId, int raceId)
        {
            if (!this.garage.ParkedCars.Contains(carId))
            {
                if (!this.racesClosed.Contains(raceId))
                {
                    this.races[raceId].Participants.Add(carId, this.cars[carId]);
                }
            }
        }

        public string Start(int id)
        {
            if (this.races[id].Participants.Count == 0)
            {
                return "Cannot start the race with zero participants.";
            }
            var result = this.races[id].StartRace();
            this.racesClosed.Add(id);
            //races.Remove(id);
            return result;
        }

        public void Park(int id)
        {
            foreach (var race in this.races.Where(r => !this.racesClosed.Contains(r.Key)))
            {
                if (race.Value.Participants.ContainsKey(id))
                {
                    return;
                }
            }

            this.garage.AddCar(id);
        }

        public void Unpark(int id)
        {
            this.garage.RemoveCar(id);
        }

        public void Tune(int tuneIndex, string addOn)
        {
            foreach (var id in this.garage.ParkedCars)
            {
                this.cars[id].Tune(tuneIndex, addOn);
            }
        }
    }
}
