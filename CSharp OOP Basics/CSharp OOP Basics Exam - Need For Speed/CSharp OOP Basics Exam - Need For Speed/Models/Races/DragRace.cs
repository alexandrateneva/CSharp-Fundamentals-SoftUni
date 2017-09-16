namespace CSharp_OOP_Basics_Exam___Need_For_Speed.Models.Races
{
    public class DragRace : Race
    {
        public DragRace(int lenght, string route, int prizePool)
            : base(lenght, route, prizePool)
        {
        }

        public override int GetPerformance(int id)
        {
            var car = this.Participants[id];

            return (car.HorsePower / car.Acceleration);
        }
    }
}
