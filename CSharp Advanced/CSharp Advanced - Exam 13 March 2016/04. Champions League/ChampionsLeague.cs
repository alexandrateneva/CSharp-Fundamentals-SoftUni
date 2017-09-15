namespace _04.Champions_League
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ChampionsLeague
    {
        public static void Main()
        {
            var result = new Dictionary<string, Dictionary<string, int>>();

            var input = Console.ReadLine();
            while (input != "stop")
            {
                var tokens = input.Split(new[] { " | " }, StringSplitOptions.RemoveEmptyEntries);
                var team1 = tokens[0];
                var team2 = tokens[1];
                AddTeam(result, team1, team2);
                AddTeam(result, team2, team1);
                var firstMatch = tokens[2].Split(':').Select(int.Parse).ToArray();
                var secondMatch = tokens[3].Split(':').Select(int.Parse).ToArray();
                var team1homegoals = firstMatch[0];
                var team1awaygoals = secondMatch[1];
                var team2homegoals = secondMatch[0];
                var team2awaygoals = firstMatch[1];
                if (team1homegoals + team1awaygoals > team2homegoals + team2awaygoals)
                {
                    result[team1][team2]++;
                }
                else if (team1homegoals + team1awaygoals < team2homegoals + team2awaygoals)
                {
                    result[team2][team1]++;
                }
                else
                {
                    if (team1awaygoals > team2awaygoals)
                    {
                        result[team1][team2]++;
                    }
                    else
                    {
                        result[team2][team1]++;
                    }
                }

                input = Console.ReadLine();
            }
            foreach (var team in result.OrderByDescending(n => n.Value.Values.Sum()).ThenBy(n => n.Key))
            {
                Console.WriteLine($"{team.Key}");
                Console.WriteLine($"- Wins: {team.Value.Values.Sum()}");
                Console.WriteLine($"- Opponents: {string.Join(", ", team.Value.Keys.OrderBy(n => n).ToArray())}");
            }
        }

        static void AddTeam(Dictionary<string, Dictionary<string, int>> result, string team1, string team2)
        {
            if (!result.ContainsKey(team1))
            {
                result.Add(team1, new Dictionary<string, int>());
            }
            result[team1].Add(team2, 0);
        }
    }
}
