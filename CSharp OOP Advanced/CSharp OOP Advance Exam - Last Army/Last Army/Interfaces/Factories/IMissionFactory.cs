namespace Last_Army.Interfaces.Factories
{
    using Last_Army.Interfaces.Models;

    public interface IMissionFactory
    {
        IMission CreateMission(string difficultyLevel, double neededPoints);
    }
}
