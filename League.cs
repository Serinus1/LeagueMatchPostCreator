using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LeagueMatchPostCreator
{
    public class League
    {
        public static List<League> AllLeagues = new();
        [DataMember]
        public string Name { get; set; } = "New League";
        [DataMember]
        public string Details { get; set; } = "Please add league details in markdown format.";

        internal static void SaveAllLeagues()
        {
            string serialized = JsonSerializer.Serialize(AllLeagues, Settings.SerializerOptions);
            File.WriteAllText(Settings.LeaguesFilePath, serialized);
        }

        internal static void LoadAllLeagues()
        {
            if (!File.Exists(Settings.LeaguesFilePath))
            {
                MessageBox.Show($"Leagues data not found at {Settings.LeaguesFilePath}.");
                return;
            }
            string serialized = File.ReadAllText(Settings.LeaguesFilePath);
            List<League>? allLeagues = JsonSerializer.Deserialize<List<League>>(serialized, Settings.SerializerOptions);
            if (allLeagues != null && allLeagues.Count > 0) League.AllLeagues = allLeagues;
        }
    }
}
