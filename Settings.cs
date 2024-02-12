using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LeagueMatchPostCreator
{
    internal static class Settings
    {
        internal static string TeamsFilePath { get; set; } = string.Empty;
        internal static string LeaguesFilePath { get; set; } = string.Empty;
        public static string GeneralSettingsFilePath { get; internal set; } = string.Empty;

        internal static JsonSerializerOptions SerializerOptions = new JsonSerializerOptions();

        public static LastKnownSettings LastKnown;

        internal static void InitializeSettings()
        {

            string mydocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string settingsDir = Path.Combine(mydocs, "League of Legends", "Match Post Creator");
            Directory.CreateDirectory(settingsDir);
            TeamsFilePath = Path.Combine(settingsDir, "teams.json");
            LeaguesFilePath = Path.Combine(settingsDir, "leagues.json");
            GeneralSettingsFilePath = Path.Combine(settingsDir, "generalsettings.json");

            SerializerOptions.WriteIndented = true;
            SerializerOptions.IncludeFields = true;

            LastKnown = LastKnownSettings.LoadLastKnownSettings();
            LastKnown.Increment();
        }

    }
}
