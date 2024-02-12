using System.Text;

namespace LeagueMatchPostCreator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Settings.InitializeSettings();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            League.LoadAllLeagues();
            Team.LoadAllTeams();

            cboLeague.Items.Clear();
            cboTeam1.Items.Clear();
            cboTeam2.Items.Clear();
            foreach (League league in League.AllLeagues)
                cboLeague.Items.Add(league.Name);
            foreach (Team team in Team.AllTeams)
            {
                if (team.lea)
                    cboTeam1.Items.Add(team.LongName);
                cboTeam2.Items.Add(team.LongName);
            }

        }

        private void cboLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnuEditLeague.Text = $"League ({cboLeague.Text})";
        }

        private void cboTeam1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnuEditTeam1.Text = $"Team 1 ({cboTeam1.Text})";
            CreateMatchPost();
        }

        private void cboTeam2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnuEditTeam2.Text = $"Team 2 ({cboTeam2.Text})";
            DisplayMatchPost();
        }

        private void DisplayMatchPost()
        {
            League league = League.AllLeagues.First(l => l.Name == txtMatchPost.Name);
            Team team1 = Team.AllTeams.First(t => t.LongName == cboTeam1.Text);
            Team team2 = Team.AllTeams.First(t => t.LongName == cboTeam2.Text);

            txtPostTitle.Text = $"{team1.LongName} vs {team2.LongName} - {league.Name} Week {nudWeek.Value}, Day {nudDay.Value}";

            txtMatchPost.Text = CreateMatchPost(PostFormats.Lemmy, league, team1, team2);
        }

        private string CreateMatchPost(PostFormats format, League league, Team team1, Team team2)
        {
            StringBuilder matchpost = new StringBuilder();

            if (format == PostFormats.Lemmy)
            {
                matchpost.Append($"{team1.LongName} vs {team2.LongName})";
                matchpost.Append("  ");
                matchpost.Append(Environment.NewLine);
                matchpost.Append($"{league.Name} {dtpMatchDate.Value.Year} - Week {nudWeek.Value}, Day {nudDay.Value}");
                matchpost.Append(league.Details);
                matchpost.Append(Environment.NewLine);
                matchpost.Append($"[Patch {txtPatchNumber.Text}]({txtPatchNotesUrl.Text})");
                matchpost.Append(Environment.NewLine);
                matchpost.Append("----");
                matchpost.Append(Environment.NewLine);
                matchpost.Append($"![{team1.LongName}]({team1.IconURL}) vs ![{team2.LongName}]({team2.IconURL})");
                matchpost.Append(Environment.NewLine);
                matchpost.Append(team1.Details);
                matchpost.Append(Environment.NewLine);
                matchpost.Append(team2.Details);
                matchpost.Append("---");
                matchpost.Append(Environment.NewLine);
                matchpost.Append("::: spoiler results");
                matchpost.Append(Environment.NewLine);
                matchpost.Append("---");
                matchpost.Append(Environment.NewLine);
                matchpost.Append(":::");
            }
            else if (format == PostFormats.Reddit)
            {
                throw new NotImplementedException();
            }
            else
            {
                throw new NotImplementedException();
            }
            return matchpost.ToString(); ;
        }

    }
}