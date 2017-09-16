namespace Last_Army.Models.Missions.Factory
{
    using System;
    using System.Linq;
    using System.Reflection;
    using Last_Army.Interfaces.Factories;
    using Last_Army.Interfaces.Models;

    public class MissionFactory : IMissionFactory
    {
        public IMission CreateMission(string missionName, double neededPoints)
        {
            Type missionType = Assembly
                .GetExecutingAssembly()
                .GetTypes()
                .FirstOrDefault(t => t.Name == missionName);

            return (IMission)Activator.CreateInstance(missionType, neededPoints);
        }
    }
}