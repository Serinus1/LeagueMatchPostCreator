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
    public partial class frmLeague : Form
    {
        League league;
        private frmLeague()
        {
            InitializeComponent();
            league = new League();
        }
        internal frmLeague(League _league)
        {
            InitializeComponent();
            league = _league;
            txtLeagueDetails.Text = league.Details;
            txtLeagueName.Text = league.Name;
            if (league.Name != "New League")
                txtLeagueName.ReadOnly = true;
            else
                txtLeagueName.ReadOnly = false;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate input
            if (txtLeagueName.Text == "New League")
            {
                MessageBox.Show("Please enter a name for the new league.");
                return;
            }
            league.Details = txtLeagueDetails.Text;
            league.Name = txtLeagueName.Text;
            if (League.AllLeagues.Count(l => l.Name == txtLeagueName.Text) == 0)
                League.AllLeagues.Add(league);
            League.SaveAllLeagues();
            this.Close();
        }
    }
}
