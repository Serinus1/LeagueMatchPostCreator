namespace LeagueMatchPostCreator
{
    partial class frmTeam
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            btnCancel = new Button();
            txtDetails = new TextBox();
            txtLongName = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtShortName = new TextBox();
            label3 = new Label();
            txtIconUrl = new TextBox();
            label4 = new Label();
            label5 = new Label();
            cboLeague = new ComboBox();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(442, 383);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 14;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(350, 383);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 12;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // txtDetails
            // 
            txtDetails.Location = new Point(12, 134);
            txtDetails.Multiline = true;
            txtDetails.Name = "txtDetails";
            txtDetails.Size = new Size(505, 231);
            txtDetails.TabIndex = 10;
            // 
            // txtLongName
            // 
            txtLongName.Location = new Point(114, 37);
            txtLongName.Name = "txtLongName";
            txtLongName.Size = new Size(162, 23);
            txtLongName.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 116);
            label2.Name = "label2";
            label2.Size = new Size(154, 15);
            label2.TabIndex = 7;
            label2.Text = "Team Details (in markdown)";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 41);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 6;
            label1.Text = "Team Long Name";
            // 
            // txtShortName
            // 
            txtShortName.Location = new Point(114, 11);
            txtShortName.Name = "txtShortName";
            txtShortName.Size = new Size(66, 23);
            txtShortName.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(7, 15);
            label3.Name = "label3";
            label3.Size = new Size(101, 15);
            label3.TabIndex = 12;
            label3.Text = "Team Short Name";
            // 
            // txtIconUrl
            // 
            txtIconUrl.Location = new Point(114, 66);
            txtIconUrl.Name = "txtIconUrl";
            txtIconUrl.Size = new Size(356, 23);
            txtIconUrl.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(7, 70);
            label4.Name = "label4";
            label4.Size = new Size(85, 15);
            label4.TabIndex = 14;
            label4.Text = "Team Icon URL";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(186, 15);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 16;
            label5.Text = "League";
            // 
            // cboLeague
            // 
            cboLeague.FormattingEnabled = true;
            cboLeague.Location = new Point(236, 11);
            cboLeague.Name = "cboLeague";
            cboLeague.Size = new Size(121, 23);
            cboLeague.TabIndex = 4;
            // 
            // frmTeam
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(532, 425);
            Controls.Add(cboLeague);
            Controls.Add(label5);
            Controls.Add(txtIconUrl);
            Controls.Add(label4);
            Controls.Add(txtShortName);
            Controls.Add(label3);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtDetails);
            Controls.Add(txtLongName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmTeam";
            Text = "Add/Edit Team";
            Load += frmTeam_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Button btnCancel;
        private TextBox txtDetails;
        private TextBox txtLongName;
        private Label label2;
        private Label label1;
        private TextBox txtShortName;
        private Label label3;
        private TextBox txtIconUrl;
        private Label label4;
        private Label label5;
        private ComboBox cboLeague;
    }
}