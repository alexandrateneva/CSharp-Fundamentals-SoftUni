namespace CSharp_OOP_Basics_Exam___Need_For_Speed.Models.Races
{
    public class DriftRace : Race
    {
        public DriftRace(int length, string route, int prizePool) 
            : base(length, route, prizePool)
        {
        }

        public override int GetPerformance(int id)
        {
            var car = this.Participants[id];
            return (car.Suspension + car.Durability);
        }
    }
}
