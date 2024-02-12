using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace LeagueMatchPostCreator
{
    public class LastKnownSettings
    {
        public int Week { get; set; } = 0;
        public int Day { get; set; } = 0;
        public DateTime LastOpen { get; set; } = new DateTime(2024, 2, 12);
        public string PatchNumber { get; set; } = "14.3";
        public string PatchNotesUrl { get; set; } = "https://www.leagueoflegends.com/en-pl/news/game-updates/patch-14-3-notes/";

        [JsonConstructorAttribute]
        /// <summary>
        /// Should only be referenced once, in its own class.
        /// </summary>
        public LastKnownSettings()
        {
            // This would be private if the JsonDeserializer didn't need it.
        }
        public static LastKnownSettings LoadLastKnownSettings()
        {
            LastKnownSettings singleton = new LastKnownSettings();
            if (File.Exists(Settings.GeneralSettingsFilePath))
                ReadFromFile(ref singleton);
            else
                singleton.Save();
            return singleton;

        }

        private static void ReadFromFile(ref LastKnownSettings singleton)
        {
            string jsonString = File.ReadAllText(Settings.GeneralSettingsFilePath);
            LastKnownSettings? deserialized = JsonSerializer.Deserialize<LastKnownSettings>(jsonString);
            if (deserialized != null) singleton = deserialized;
        }

        /// <summary>
        /// Attempts to guess at things like Week, Day, and Patch 
        /// by comparing the date of the last time the app was opened to today's date.
        /// </summary>
        public void Increment()
        {
            if ((DateTime.Now - LastOpen).TotalDays > 10)
            {
                Week = 0;
                Day = 0;
                PatchNumber = "0.0";
                PatchNotesUrl = "https://www.leagueoflegends.com/en-pl/news/tags/patch-notes/";
            }
            else if ((DateTime.Now - LastOpen).TotalDays > 4)
            {
                Week++;
                Day++;
            }
        }
        public void Save()
        {
            this.LastOpen = DateTime.Now;
            string serialized = JsonSerializer.Serialize(this, Settings.SerializerOptions);
            File.WriteAllText(Settings.GeneralSettingsFilePath, serialized);
        }
    }
}
