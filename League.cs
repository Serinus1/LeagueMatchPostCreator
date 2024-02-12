using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LeagueMatchPostCreator
{
    internal class League
    {
        internal static List<League> AllLeagues = new();
        internal string Name { get; set; } = "New League";
        internal string Details { get; set; } = "Please add league details in markdown format.";

        internal static void SaveAllLeagues()
        {
            string serialized = JsonSerializer.Serialize(AllLeagues);
            File.WriteAllText(Settings.LeaguesFilePath, serialized);
        }

        internal static void LoadAllLeagues()
        {
            if (!File.Exists(Settings.LeaguesFilePath))
            {
                MessageBox.Show($"Leagues data not found at {Settings.LeaguesFilePath}.");
                return;
            }
        }
    }
}
