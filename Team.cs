using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LeagueMatchPostCreator
{
    public class Team
    {
        public static List<Team> AllTeams = new List<Team>();
        [DataMember]
        public string League { get; set; } = string.Empty;
        [DataMember]
        public string ShortName { get; set; } = "NewTeam";
        [DataMember]
        public string LongName { get; set; } = "Long Team Name";
        [DataMember]
        public string IconURL { get; set; } = "Please provide team icon URL";
        [DataMember]
        public string Details { get; set; } = "Please provide team details in markdown format.";

        internal static void SaveAllTeams()
        {
            string serialized = JsonSerializer.Serialize(AllTeams, Settings.SerializerOptions);
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
            List<Team>? allTeams = JsonSerializer.Deserialize<List<Team>>(jsonString);
            if (allTeams != null && allTeams.Count > 0) Team.AllTeams = allTeams;
        }
    }
}
