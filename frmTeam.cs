using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeagueMatchPostCreator
{
    public partial class frmTeam : Form
    {
        Team team = new Team();
        private frmTeam()
        {
            InitializeComponent();
        }

        internal frmTeam(Team _team)
        {
            InitializeComponent();
            team = _team;
            txtShortName.Text = team.ShortName;
            txtLongName.Text = team.LongName;
            txtIconUrl.Text = team.IconURL;
            txtDetails.Text = team.Details;
            cboLeague.SelectedValue = team.League;

            if (team.ShortName == "NewTeam")
                txtShortName.ReadOnly = false;
            else
                txtShortName.ReadOnly = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate Input
            if (txtShortName.Text == "NewTeam")
            {
                MessageBox.Show("Please enter a name for the new team.");
                return;
            }
            team.ShortName = txtShortName.Text;
            team.LongName = txtLongName.Text;
            team.IconURL = txtIconUrl.Text;
            team.Details = txtDetails.Text;
            team.League = cboLeague.Text;

            if (Team.AllTeams.Count(t => t.ShortName == team.ShortName) == 0)
                Team.AllTeams.Add(team);
            Team.SaveAllTeams();
            Close();
        }

        private void frmTeam_Load(object sender, EventArgs e)
        {
            if (League.AllLeagues.Count == 0)
            {
                MessageBox.Show("Please create and save a league before creating a team.");
                this.Close();
            }
            cboLeague.Items.Clear();
            foreach (League league in League.AllLeagues)
                cboLeague.Items.Add(league.Name);
        }
    }
}
