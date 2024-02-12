namespace LeagueMatchPostCreator
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cboLeague = new ComboBox();
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            addNewToolStripMenuItem = new ToolStripMenuItem();
            mnuAddLeague = new ToolStripMenuItem();
            mnuAddTeam = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            mnuEditLeague = new ToolStripMenuItem();
            mnuEditTeam1 = new ToolStripMenuItem();
            mnuEditTeam2 = new ToolStripMenuItem();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            cboTeam1 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            cboTeam2 = new ComboBox();
            nudWeek = new NumericUpDown();
            nudDay = new NumericUpDown();
            dtpMatchDate = new DateTimePicker();
            txtMatchPost = new TextBox();
            label7 = new Label();
            label8 = new Label();
            txtPatchNumber = new TextBox();
            txtPatchNotesUrl = new TextBox();
            txtPostTitle = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudWeek).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudDay).BeginInit();
            SuspendLayout();
            // 
            // cboLeague
            // 
            cboLeague.FormattingEnabled = true;
            cboLeague.Location = new Point(59, 31);
            cboLeague.Name = "cboLeague";
            cboLeague.Size = new Size(121, 23);
            cboLeague.TabIndex = 0;
            cboLeague.SelectedIndexChanged += cboLeague_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(8, 35);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 1;
            label1.Text = "League";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { addNewToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(806, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // addNewToolStripMenuItem
            // 
            addNewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuAddLeague, mnuAddTeam });
            addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            addNewToolStripMenuItem.Size = new Size(68, 20);
            addNewToolStripMenuItem.Text = "Add New";
            // 
            // mnuAddLeague
            // 
            mnuAddLeague.Name = "mnuAddLeague";
            mnuAddLeague.Size = new Size(112, 22);
            mnuAddLeague.Text = "League";
            mnuAddLeague.Click += mnuAddLeague_Click;
            // 
            // mnuAddTeam
            // 
            mnuAddTeam.Name = "mnuAddTeam";
            mnuAddTeam.Size = new Size(112, 22);
            mnuAddTeam.Text = "Team";
            mnuAddTeam.Click += mnuAddTeam_Click;
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuEditLeague, mnuEditTeam1, mnuEditTeam2 });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // mnuEditLeague
            // 
            mnuEditLeague.Name = "mnuEditLeague";
            mnuEditLeague.Size = new Size(223, 22);
            mnuEditLeague.Text = "League (No league selected)";
            mnuEditLeague.Click += mnuEditLeague_Click;
            // 
            // mnuEditTeam1
            // 
            mnuEditTeam1.Name = "mnuEditTeam1";
            mnuEditTeam1.Size = new Size(223, 22);
            mnuEditTeam1.Text = "Team 1 (No team selected)";
            mnuEditTeam1.Click += mnuEditTeam1_Click;
            // 
            // mnuEditTeam2
            // 
            mnuEditTeam2.Name = "mnuEditTeam2";
            mnuEditTeam2.Size = new Size(223, 22);
            mnuEditTeam2.Text = "Team 2 (No team selected)";
            mnuEditTeam2.Click += mnuEditTeam2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(196, 35);
            label2.Name = "label2";
            label2.Size = new Size(68, 15);
            label2.TabIndex = 3;
            label2.Text = "Match Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(8, 63);
            label3.Name = "label3";
            label3.Size = new Size(46, 15);
            label3.TabIndex = 4;
            label3.Text = "Week #";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 63);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 5;
            label4.Text = "Day #";
            // 
            // cboTeam1
            // 
            cboTeam1.FormattingEnabled = true;
            cboTeam1.Location = new Point(8, 137);
            cboTeam1.Name = "cboTeam1";
            cboTeam1.Size = new Size(121, 23);
            cboTeam1.TabIndex = 6;
            cboTeam1.SelectedIndexChanged += cboTeam1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(196, 119);
            label5.Name = "label5";
            label5.Size = new Size(44, 15);
            label5.TabIndex = 8;
            label5.Text = "Team 2";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(8, 119);
            label6.Name = "label6";
            label6.Size = new Size(44, 15);
            label6.TabIndex = 7;
            label6.Text = "Team 1";
            // 
            // cboTeam2
            // 
            cboTeam2.FormattingEnabled = true;
            cboTeam2.Location = new Point(196, 137);
            cboTeam2.Name = "cboTeam2";
            cboTeam2.Size = new Size(121, 23);
            cboTeam2.TabIndex = 9;
            cboTeam2.SelectedIndexChanged += cboTeam2_SelectedIndexChanged;
            // 
            // nudWeek
            // 
            nudWeek.Location = new Point(65, 59);
            nudWeek.Name = "nudWeek";
            nudWeek.Size = new Size(45, 23);
            nudWeek.TabIndex = 10;
            // 
            // nudDay
            // 
            nudDay.Location = new Point(161, 59);
            nudDay.Name = "nudDay";
            nudDay.Size = new Size(42, 23);
            nudDay.TabIndex = 11;
            // 
            // dtpMatchDate
            // 
            dtpMatchDate.Location = new Point(271, 31);
            dtpMatchDate.Name = "dtpMatchDate";
            dtpMatchDate.Size = new Size(200, 23);
            dtpMatchDate.TabIndex = 12;
            // 
            // txtMatchPost
            // 
            txtMatchPost.Location = new Point(8, 211);
            txtMatchPost.Multiline = true;
            txtMatchPost.Name = "txtMatchPost";
            txtMatchPost.Size = new Size(786, 254);
            txtMatchPost.TabIndex = 13;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(8, 91);
            label7.Name = "label7";
            label7.Size = new Size(84, 15);
            label7.TabIndex = 14;
            label7.Text = "Patch Number";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(180, 91);
            label8.Name = "label8";
            label8.Size = new Size(95, 15);
            label8.TabIndex = 15;
            label8.Text = "Patch Notes URL";
            // 
            // txtPatchNumber
            // 
            txtPatchNumber.Location = new Point(97, 87);
            txtPatchNumber.Name = "txtPatchNumber";
            txtPatchNumber.Size = new Size(83, 23);
            txtPatchNumber.TabIndex = 16;
            // 
            // txtPatchNotesUrl
            // 
            txtPatchNotesUrl.Location = new Point(281, 87);
            txtPatchNotesUrl.Name = "txtPatchNotesUrl";
            txtPatchNotesUrl.Size = new Size(409, 23);
            txtPatchNotesUrl.TabIndex = 17;
            // 
            // txtPostTitle
            // 
            txtPostTitle.Location = new Point(11, 182);
            txtPostTitle.Name = "txtPostTitle";
            txtPostTitle.Size = new Size(387, 23);
            txtPostTitle.TabIndex = 18;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(806, 477);
            Controls.Add(txtPostTitle);
            Controls.Add(txtPatchNotesUrl);
            Controls.Add(txtPatchNumber);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(txtMatchPost);
            Controls.Add(dtpMatchDate);
            Controls.Add(nudDay);
            Controls.Add(nudWeek);
            Controls.Add(cboTeam2);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(cboTeam1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cboLeague);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Main";
            Text = "League Match Post Creator";
            FormClosing += Main_FormClosing;
            Load += Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudWeek).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudDay).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboLeague;
        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem addNewToolStripMenuItem;
        private ToolStripMenuItem mnuAddLeague;
        private ToolStripMenuItem mnuAddTeam;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem mnuEditLeague;
        private ToolStripMenuItem mnuEditTeam1;
        private ToolStripMenuItem mnuEditTeam2;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox cboTeam1;
        private Label label5;
        private Label label6;
        private ComboBox cboTeam2;
        private NumericUpDown nudWeek;
        private NumericUpDown nudDay;
        private DateTimePicker dtpMatchDate;
        private TextBox txtMatchPost;
        private Label label7;
        private Label label8;
        private TextBox txtPatchNumber;
        private TextBox txtPatchNotesUrl;
        private TextBox txtPostTitle;
    }
}