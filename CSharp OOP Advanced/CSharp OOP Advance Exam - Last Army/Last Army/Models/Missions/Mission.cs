namespace Last_Army.Models.Missions
{
    using Last_Army.Interfaces.Models;

    public abstract class Mission : IMission
    {
        protected Mission(double scoreToComplete)
        {
            this.ScoreToComplete = scoreToComplete;
        }
    
        public double ScoreToComplete { get; }

        public abstract double EnduranceRequired { get; }

        public abstract double WearLevelDecrement { get; }

        public abstract string Name { get; }
    }
}