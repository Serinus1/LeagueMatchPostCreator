namespace LeagueMatchPostCreator
{
    partial class frmLeague
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
            label1 = new Label();
            label2 = new Label();
            txtLeagueName = new TextBox();
            txtLeagueDetails = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 18);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 0;
            label1.Text = "League Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(20, 51);
            label2.Name = "label2";
            label2.Size = new Size(164, 15);
            label2.TabIndex = 1;
            label2.Text = "League Details (in markdown)";
            // 
            // txtLeagueName
            // 
            txtLeagueName.Location = new Point(117, 14);
            txtLeagueName.Name = "txtLeagueName";
            txtLeagueName.Size = new Size(100, 23);
            txtLeagueName.TabIndex = 2;
            // 
            // txtLeagueDetails
            // 
            txtLeagueDetails.Location = new Point(20, 69);
            txtLeagueDetails.Multiline = true;
            txtLeagueDetails.Name = "txtLeagueDetails";
            txtLeagueDetails.Size = new Size(505, 231);
            txtLeagueDetails.TabIndex = 4;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(358, 318);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(450, 318);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmLeague
            // 
            AcceptButton = btnSave;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            CancelButton = btnCancel;
            ClientSize = new Size(544, 352);
            Controls.Add(btnSave);
            Controls.Add(btnCancel);
            Controls.Add(txtLeagueDetails);
            Controls.Add(txtLeagueName);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmLeague";
            Text = "Add/Edit League";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtLeagueName;
        private TextBox txtLeagueDetails;
        private Button btnCancel;
        private Button btnSave;
    }
}