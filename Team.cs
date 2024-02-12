using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LeagueMatchPostCreator
{
    internal class Team
    {
        internal static List<Team> AllTeams = new List<Team>();
        internal string ShortName { get; set; } = "NewTeam";
        internal string LongName { get; set; } = "Long Team Name";
        internal string IconURL { get; set; } = "Please provide team icon URL";
        internal string Details { get; set; } = "Please provide team details in markdown format.";

        internal static void SaveAllTeams()
        {
            string serialized = JsonSerializer.Serialize(AllTeams);
            File.WriteAllText(Settings.TeamsFilePath, serialized);
        }

        internal static void LoadAllTeams()
        {
            if (!File.Exists(Settings.TeamsFilePath))
            {
                MessageBox.Show($"Teams data not found at {Settings.TeamsFilePath}.");
                return;
            }
            string jsonString = File.ReadAllText(Settings.TeamsFilePath);
            AllTeams = JsonSerializer.Deserialize<List<Team>>(jsonString)!;
        }
    }
}
