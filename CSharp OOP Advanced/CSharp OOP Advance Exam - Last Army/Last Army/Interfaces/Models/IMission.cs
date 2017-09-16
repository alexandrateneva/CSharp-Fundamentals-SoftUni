namespace Last_Army.Interfaces.Models
{
    public interface IMission
    {
        string Name { get; }

        double EnduranceRequired { get; }

        double ScoreToComplete { get; }

        double WearLevelDecrement { get; }
    }
}