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

            DisplayLeagues();
            if (cboLeague.SelectedValue?.ToString() != string.Empty)
                DisplayTeams();
        }

        private void DisplayLeagues()
        {
            cboLeague.Items.Clear();
            cboLeague.SelectedValue = null;
            foreach (League league in League.AllLeagues)
                cboLeague.Items.Add(league.Name);
            // TODO: If they've just added a league, select that one. On load select the league they left off with last time.
            if (cboLeague.Items.Count > 0)
                cboLeague.SelectedIndex = cboLeague.Items.Count - 1;
        }

        private void DisplayTeams()
        {
            cboTeam1.Items.Clear();
            cboTeam2.Items.Clear();
            foreach (Team team in Team.AllTeams)
            {
                if (team.League == cboLeague.SelectedItem?.ToString())
                {
                    cboTeam1.Items.Add(team.LongName);
                    cboTeam2.Items.Add(team.LongName);
                }
            }
        }

        private void cboLeague_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnuEditLeague.Text = $"League ({cboLeague.Text})";
            if (cboLeague.SelectedItem?.ToString() != string.Empty)
                DisplayTeams();
        }

        private void cboTeam1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnuEditTeam1.Text = $"Team 1 ({cboTeam1.Text})";
            DisplayMatchPost();
        }

        private void cboTeam2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mnuEditTeam2.Text = $"Team 2 ({cboTeam2.Text})";
            DisplayMatchPost();
        }

        private void DisplayMatchPost()
        {
            if (cboLeague.SelectedItem?.ToString() == string.Empty || cboTeam1.SelectedItem?.ToString() == string.Empty || cboTeam2.SelectedItem?.ToString() == string.Empty)
                return;

            League league = League.AllLeagues.First(l => l.Name == cboLeague.SelectedItem?.ToString());
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
                matchpost.Append($"{team1.LongName} vs {team2.LongName})");
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

        private void mnuAddLeague_Click(object sender, EventArgs e)
        {
            new frmLeague(new League()).ShowDialog();
            DisplayLeagues();
        }

        private void mnuAddTeam_Click(object sender, EventArgs e)
        {
            new frmTeam(new Team()).ShowDialog();
            DisplayTeams();
        }

        private void mnuEditLeague_Click(object sender, EventArgs e)
        {
            if (cboLeague.Items.Count == 0) // TODO: Ensure there's a selected value?
            {
                MessageBox.Show("Select a league before editing.");
            }
            new frmLeague(League.AllLeagues.First(l => l.Name == cboLeague.SelectedValue.ToString())).ShowDialog();
        }

        private void mnuEditTeam1_Click(object sender, EventArgs e)
        {
            if (cboTeam1.Items.Count == 0)
            {
                MessageBox.Show("Select a team before editing.");
            }
            new frmTeam(Team.AllTeams.First(t => t.LongName == cboTeam1.SelectedValue.ToString())).ShowDialog();
        }

        private void mnuEditTeam2_Click(object sender, EventArgs e)
        {
            if (cboTeam2.Items.Count == 0)
            {
                MessageBox.Show("Select a team before editing.");
            }
            new frmTeam(Team.AllTeams.First(t => t.LongName == cboTeam2.SelectedValue.ToString())).ShowDialog();
        }
    }
}