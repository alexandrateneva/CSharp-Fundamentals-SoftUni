namespace CSharp_OOP_Basics_Exam___Need_For_Speed.Models
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public abstract class Race
    {
        private int lenght;
        private int prizePool;
        private string route;
        private Dictionary<int, Car> participants;
        private List<Car> winners;

        public Race(int length, string route, int prizePool)
        {
            this.Length = length;
            this.Route = route;
            this.PrizePool = prizePool;
            this.Participants = new Dictionary<int, Car>();
            this.Winners = new List<Car>();
        }

        public int Length
        {
            get { return this.lenght; }
            private set { this.lenght = value; }
        }

        public string Route
        {
            get { return this.route; }
            private set { this.route = value; }
        }

        public int PrizePool
        {
            get { return this.prizePool; }
            private set { this.prizePool = value; }
        }

        public Dictionary<int, Car> Participants
        {
            get { return this.participants; }
            private set { this.participants = value; }
        }

        public List<Car> Winners
        {
            get { return this.winners; }
            private set { this.winners = value; }
        }

        public Dictionary<int, Car> GetWinners()
        {
            var winners = this.Participants
                .OrderByDescending(n => this.GetPerformance(n.Key))
                .Take(3)
                .ToDictionary(n => n.Key, m => m.Value);

            return winners;
        }

        public List<int> GetPrizes()
        {
            var result = new List<int>();
            result.Add((this.PrizePool * 50) / 100);
            result.Add((this.PrizePool * 30) / 100);
            result.Add((this.PrizePool * 20) / 100);
            return result;
        }

        public abstract int GetPerformance(int id);

        public string StartRace()
        {
            var winners = this.GetWinners();
            var prizes = this.GetPrizes();

            var sb = new StringBuilder();
            sb.AppendLine($"{this.Route} - {this.Length}");
            for (int i = 0; i < winners.Count; i++)
            {
                var car = winners.ElementAt(i);
                sb.AppendLine(
                    $"{i + 1}. {car.Value.Brand} {car.Value.Model} {this.GetPerformance(car.Key)}PP - ${prizes[i]}");
            }
            return sb.ToString().Trim();
        }
    }
}
