namespace TrackerUI
{
    partial class Form1
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
            HeaderLabel = new Label();
            label2 = new Label();
            RoundLabel = new Label();
            roundDropDown1 = new ComboBox();
            checkBox1 = new CheckBox();
            matchupListBox = new ListBox();
            teamOneName = new Label();
            teamOneScoreLabel = new Label();
            TeamOneScoreText = new TextBox();
            TeamTwoScoreText = new TextBox();
            teamTwoScoreLabel = new Label();
            teamTwoName = new Label();
            VersusLabel = new Label();
            scoreButton = new Button();
            SuspendLayout();
            // 
            // HeaderLabel
            // 
            HeaderLabel.AutoSize = true;
            HeaderLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HeaderLabel.ForeColor = Color.CornflowerBlue;
            HeaderLabel.Location = new Point(12, 49);
            HeaderLabel.Name = "HeaderLabel";
            HeaderLabel.Size = new Size(287, 62);
            HeaderLabel.TabIndex = 1;
            HeaderLabel.Text = "Tournament:";
            HeaderLabel.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.CornflowerBlue;
            label2.Location = new Point(305, 49);
            label2.Name = "label2";
            label2.Size = new Size(198, 62);
            label2.TabIndex = 2;
            label2.Text = "<none>";
            // 
            // RoundLabel
            // 
            RoundLabel.AutoSize = true;
            RoundLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            RoundLabel.ForeColor = Color.CornflowerBlue;
            RoundLabel.Location = new Point(25, 138);
            RoundLabel.Name = "RoundLabel";
            RoundLabel.Size = new Size(174, 62);
            RoundLabel.TabIndex = 3;
            RoundLabel.Text = "Round:";
            RoundLabel.Click += label3_Click;
            // 
            // roundDropDown1
            // 
            roundDropDown1.FormattingEnabled = true;
            roundDropDown1.Location = new Point(196, 159);
            roundDropDown1.Name = "roundDropDown1";
            roundDropDown1.Size = new Size(172, 28);
            roundDropDown1.TabIndex = 4;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.FlatStyle = FlatStyle.Flat;
            checkBox1.Font = new Font("Segoe UI", 20.25F);
            checkBox1.ForeColor = Color.CornflowerBlue;
            checkBox1.Location = new Point(196, 193);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(257, 50);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Unplayed Only";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // matchupListBox
            // 
            matchupListBox.BorderStyle = BorderStyle.FixedSingle;
            matchupListBox.FormattingEnabled = true;
            matchupListBox.Location = new Point(25, 245);
            matchupListBox.Name = "matchupListBox";
            matchupListBox.Size = new Size(343, 302);
            matchupListBox.TabIndex = 6;
            // 
            // teamOneName
            // 
            teamOneName.AutoSize = true;
            teamOneName.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamOneName.ForeColor = Color.CornflowerBlue;
            teamOneName.Location = new Point(445, 193);
            teamOneName.Name = "teamOneName";
            teamOneName.Size = new Size(289, 62);
            teamOneName.TabIndex = 7;
            teamOneName.Text = "<team one>";
            teamOneName.Click += label3_Click_1;
            // 
            // teamOneScoreLabel
            // 
            teamOneScoreLabel.AutoSize = true;
            teamOneScoreLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamOneScoreLabel.ForeColor = Color.CornflowerBlue;
            teamOneScoreLabel.Location = new Point(459, 255);
            teamOneScoreLabel.Name = "teamOneScoreLabel";
            teamOneScoreLabel.Size = new Size(153, 62);
            teamOneScoreLabel.TabIndex = 8;
            teamOneScoreLabel.Text = "Score:";
            teamOneScoreLabel.Click += TournamentViewerScore_Click;
            // 
            // TeamOneScoreText
            // 
            TeamOneScoreText.Location = new Point(608, 274);
            TeamOneScoreText.Name = "TeamOneScoreText";
            TeamOneScoreText.Size = new Size(149, 27);
            TeamOneScoreText.TabIndex = 9;
            // 
            // TeamTwoScoreText
            // 
            TeamTwoScoreText.Location = new Point(608, 515);
            TeamTwoScoreText.Name = "TeamTwoScoreText";
            TeamTwoScoreText.Size = new Size(149, 27);
            TeamTwoScoreText.TabIndex = 12;
            // 
            // teamTwoScoreLabel
            // 
            teamTwoScoreLabel.AutoSize = true;
            teamTwoScoreLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamTwoScoreLabel.ForeColor = Color.CornflowerBlue;
            teamTwoScoreLabel.Location = new Point(459, 496);
            teamTwoScoreLabel.Name = "teamTwoScoreLabel";
            teamTwoScoreLabel.Size = new Size(153, 62);
            teamTwoScoreLabel.TabIndex = 11;
            teamTwoScoreLabel.Text = "Score:";
            // 
            // teamTwoName
            // 
            teamTwoName.AutoSize = true;
            teamTwoName.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            teamTwoName.ForeColor = Color.CornflowerBlue;
            teamTwoName.Location = new Point(445, 434);
            teamTwoName.Name = "teamTwoName";
            teamTwoName.Size = new Size(287, 62);
            teamTwoName.TabIndex = 10;
            teamTwoName.Text = "<team two>";
            // 
            // VersusLabel
            // 
            VersusLabel.AutoSize = true;
            VersusLabel.Font = new Font("Segoe UI", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            VersusLabel.ForeColor = Color.CornflowerBlue;
            VersusLabel.Location = new Point(531, 341);
            VersusLabel.Name = "VersusLabel";
            VersusLabel.Size = new Size(183, 62);
            VersusLabel.TabIndex = 13;
            VersusLabel.Text = "-- VS --";
            VersusLabel.Click += label3_Click_2;
            // 
            // scoreButton
            // 
            scoreButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(102, 102, 102);
            scoreButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(242, 242, 242);
            scoreButton.FlatStyle = FlatStyle.Flat;
            scoreButton.Location = new Point(820, 322);
            scoreButton.Name = "scoreButton";
            scoreButton.Size = new Size(94, 29);
            scoreButton.TabIndex = 14;
            scoreButton.Text = "Score";
            scoreButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(967, 578);
            Controls.Add(scoreButton);
            Controls.Add(VersusLabel);
            Controls.Add(TeamTwoScoreText);
            Controls.Add(teamTwoScoreLabel);
            Controls.Add(teamTwoName);
            Controls.Add(TeamOneScoreText);
            Controls.Add(teamOneScoreLabel);
            Controls.Add(teamOneName);
            Controls.Add(matchupListBox);
            Controls.Add(checkBox1);
            Controls.Add(roundDropDown1);
            Controls.Add(RoundLabel);
            Controls.Add(label2);
            Controls.Add(HeaderLabel);
            Name = "Form1";
            Text = "Tournament Viwer";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label HeaderLabel;
        private Label label2;
        private Label RoundLabel;
        private ComboBox roundDropDown1;
        private CheckBox checkBox1;
        private ListBox matchupListBox;
        private Label teamOneName;
        private Label teamOneScoreLabel;
        private TextBox TeamOneScoreText;
        private TextBox TeamTwoScoreText;
        private Label teamTwoScoreLabel;
        private Label teamTwoName;
        private Label VersusLabel;
        private Button scoreButton;
    }
}
