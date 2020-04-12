namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.teamNameValue = new System.Windows.Forms.TextBox();
            this.teamNameLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.addMembersButton = new System.Windows.Forms.Button();
            this.selectTeamMembersLabel = new System.Windows.Forms.Label();
            this.selectTeamMembersDropDown = new System.Windows.Forms.ComboBox();
            this.addNewMembersGroupBox = new System.Windows.Forms.GroupBox();
            this.createMembersButton = new System.Windows.Forms.Button();
            this.cellphoneValue = new System.Windows.Forms.TextBox();
            this.cellphoneLabel = new System.Windows.Forms.Label();
            this.emailValue = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.lastNameValue = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameValue = new System.Windows.Forms.TextBox();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.tournamentPlayersListLabel = new System.Windows.Forms.Label();
            this.teamMembersListBox = new System.Windows.Forms.ListBox();
            this.deleteSelectedTeamMembersButton = new System.Windows.Forms.Button();
            this.createTeamButton = new System.Windows.Forms.Button();
            this.addNewMembersGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teamNameValue
            // 
            this.teamNameValue.Location = new System.Drawing.Point(45, 116);
            this.teamNameValue.Name = "teamNameValue";
            this.teamNameValue.Size = new System.Drawing.Size(416, 35);
            this.teamNameValue.TabIndex = 13;
            // 
            // teamNameLabel
            // 
            this.teamNameLabel.AutoSize = true;
            this.teamNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.teamNameLabel.ForeColor = System.Drawing.Color.Blue;
            this.teamNameLabel.Location = new System.Drawing.Point(38, 76);
            this.teamNameLabel.Name = "teamNameLabel";
            this.teamNameLabel.Size = new System.Drawing.Size(151, 37);
            this.teamNameLabel.TabIndex = 12;
            this.teamNameLabel.Text = "Team Name";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.Color.Blue;
            this.headerLabel.Location = new System.Drawing.Point(14, 10);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(213, 50);
            this.headerLabel.TabIndex = 11;
            this.headerLabel.Text = "Create Team";
            // 
            // addMembersButton
            // 
            this.addMembersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.addMembersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.addMembersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addMembersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addMembersButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMembersButton.ForeColor = System.Drawing.Color.Blue;
            this.addMembersButton.Location = new System.Drawing.Point(136, 290);
            this.addMembersButton.Name = "addMembersButton";
            this.addMembersButton.Size = new System.Drawing.Size(191, 53);
            this.addMembersButton.TabIndex = 20;
            this.addMembersButton.Text = "Add Member";
            this.addMembersButton.UseVisualStyleBackColor = true;
            // 
            // selectTeamMembersLabel
            // 
            this.selectTeamMembersLabel.AutoSize = true;
            this.selectTeamMembersLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.selectTeamMembersLabel.ForeColor = System.Drawing.Color.Blue;
            this.selectTeamMembersLabel.Location = new System.Drawing.Point(38, 192);
            this.selectTeamMembersLabel.Name = "selectTeamMembersLabel";
            this.selectTeamMembersLabel.Size = new System.Drawing.Size(253, 37);
            this.selectTeamMembersLabel.TabIndex = 18;
            this.selectTeamMembersLabel.Text = "Select Team Member";
            // 
            // selectTeamMembersDropDown
            // 
            this.selectTeamMembersDropDown.FormattingEnabled = true;
            this.selectTeamMembersDropDown.Location = new System.Drawing.Point(45, 232);
            this.selectTeamMembersDropDown.Name = "selectTeamMembersDropDown";
            this.selectTeamMembersDropDown.Size = new System.Drawing.Size(416, 38);
            this.selectTeamMembersDropDown.TabIndex = 17;
            // 
            // addNewMembersGroupBox
            // 
            this.addNewMembersGroupBox.Controls.Add(this.createMembersButton);
            this.addNewMembersGroupBox.Controls.Add(this.cellphoneValue);
            this.addNewMembersGroupBox.Controls.Add(this.cellphoneLabel);
            this.addNewMembersGroupBox.Controls.Add(this.emailValue);
            this.addNewMembersGroupBox.Controls.Add(this.emailLabel);
            this.addNewMembersGroupBox.Controls.Add(this.lastNameValue);
            this.addNewMembersGroupBox.Controls.Add(this.lastNameLabel);
            this.addNewMembersGroupBox.Controls.Add(this.firstNameValue);
            this.addNewMembersGroupBox.Controls.Add(this.firstNameLabel);
            this.addNewMembersGroupBox.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewMembersGroupBox.ForeColor = System.Drawing.Color.Blue;
            this.addNewMembersGroupBox.Location = new System.Drawing.Point(23, 381);
            this.addNewMembersGroupBox.Name = "addNewMembersGroupBox";
            this.addNewMembersGroupBox.Size = new System.Drawing.Size(447, 369);
            this.addNewMembersGroupBox.TabIndex = 21;
            this.addNewMembersGroupBox.TabStop = false;
            this.addNewMembersGroupBox.Text = "Add New Member";
            // 
            // createMembersButton
            // 
            this.createMembersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createMembersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createMembersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createMembersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createMembersButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createMembersButton.ForeColor = System.Drawing.Color.Blue;
            this.createMembersButton.Location = new System.Drawing.Point(113, 299);
            this.createMembersButton.Name = "createMembersButton";
            this.createMembersButton.Size = new System.Drawing.Size(191, 53);
            this.createMembersButton.TabIndex = 21;
            this.createMembersButton.Text = "Create Member";
            this.createMembersButton.UseVisualStyleBackColor = true;
            // 
            // cellphoneValue
            // 
            this.cellphoneValue.Location = new System.Drawing.Point(153, 237);
            this.cellphoneValue.Name = "cellphoneValue";
            this.cellphoneValue.Size = new System.Drawing.Size(288, 43);
            this.cellphoneValue.TabIndex = 16;
            this.cellphoneValue.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // cellphoneLabel
            // 
            this.cellphoneLabel.AutoSize = true;
            this.cellphoneLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.cellphoneLabel.ForeColor = System.Drawing.Color.Blue;
            this.cellphoneLabel.Location = new System.Drawing.Point(15, 240);
            this.cellphoneLabel.Name = "cellphoneLabel";
            this.cellphoneLabel.Size = new System.Drawing.Size(132, 37);
            this.cellphoneLabel.TabIndex = 15;
            this.cellphoneLabel.Text = "Cellphone";
            this.cellphoneLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // emailValue
            // 
            this.emailValue.Location = new System.Drawing.Point(153, 177);
            this.emailValue.Name = "emailValue";
            this.emailValue.Size = new System.Drawing.Size(288, 43);
            this.emailValue.TabIndex = 14;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.emailLabel.ForeColor = System.Drawing.Color.Blue;
            this.emailLabel.Location = new System.Drawing.Point(15, 180);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(78, 37);
            this.emailLabel.TabIndex = 13;
            this.emailLabel.Text = "Email";
            // 
            // lastNameValue
            // 
            this.lastNameValue.Location = new System.Drawing.Point(153, 119);
            this.lastNameValue.Name = "lastNameValue";
            this.lastNameValue.Size = new System.Drawing.Size(288, 43);
            this.lastNameValue.TabIndex = 12;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.lastNameLabel.ForeColor = System.Drawing.Color.Blue;
            this.lastNameLabel.Location = new System.Drawing.Point(15, 122);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(135, 37);
            this.lastNameLabel.TabIndex = 11;
            this.lastNameLabel.Text = "Last Name";
            // 
            // firstNameValue
            // 
            this.firstNameValue.Location = new System.Drawing.Point(153, 59);
            this.firstNameValue.Name = "firstNameValue";
            this.firstNameValue.Size = new System.Drawing.Size(288, 43);
            this.firstNameValue.TabIndex = 10;
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.firstNameLabel.ForeColor = System.Drawing.Color.Blue;
            this.firstNameLabel.Location = new System.Drawing.Point(15, 62);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(138, 37);
            this.firstNameLabel.TabIndex = 9;
            this.firstNameLabel.Text = "First Name";
            // 
            // tournamentPlayersListLabel
            // 
            this.tournamentPlayersListLabel.AutoSize = true;
            this.tournamentPlayersListLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F);
            this.tournamentPlayersListLabel.ForeColor = System.Drawing.Color.Blue;
            this.tournamentPlayersListLabel.Location = new System.Drawing.Point(506, 78);
            this.tournamentPlayersListLabel.Name = "tournamentPlayersListLabel";
            this.tournamentPlayersListLabel.Size = new System.Drawing.Size(189, 37);
            this.tournamentPlayersListLabel.TabIndex = 23;
            this.tournamentPlayersListLabel.Text = "Teams / Players";
            // 
            // teamMembersListBox
            // 
            this.teamMembersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.teamMembersListBox.FormattingEnabled = true;
            this.teamMembersListBox.ItemHeight = 30;
            this.teamMembersListBox.Location = new System.Drawing.Point(513, 118);
            this.teamMembersListBox.Name = "teamMembersListBox";
            this.teamMembersListBox.Size = new System.Drawing.Size(340, 632);
            this.teamMembersListBox.TabIndex = 22;
            // 
            // deleteSelectedTeamMembersButton
            // 
            this.deleteSelectedTeamMembersButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.deleteSelectedTeamMembersButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.deleteSelectedTeamMembersButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.deleteSelectedTeamMembersButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.deleteSelectedTeamMembersButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteSelectedTeamMembersButton.ForeColor = System.Drawing.Color.Blue;
            this.deleteSelectedTeamMembersButton.Location = new System.Drawing.Point(878, 290);
            this.deleteSelectedTeamMembersButton.Name = "deleteSelectedTeamMembersButton";
            this.deleteSelectedTeamMembersButton.Size = new System.Drawing.Size(116, 79);
            this.deleteSelectedTeamMembersButton.TabIndex = 25;
            this.deleteSelectedTeamMembersButton.Text = "Delete Selected";
            this.deleteSelectedTeamMembersButton.UseVisualStyleBackColor = true;
            // 
            // createTeamButton
            // 
            this.createTeamButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.createTeamButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.createTeamButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.createTeamButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.createTeamButton.Font = new System.Drawing.Font("Segoe UI Light", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createTeamButton.ForeColor = System.Drawing.Color.Blue;
            this.createTeamButton.Location = new System.Drawing.Point(375, 769);
            this.createTeamButton.Name = "createTeamButton";
            this.createTeamButton.Size = new System.Drawing.Size(320, 66);
            this.createTeamButton.TabIndex = 26;
            this.createTeamButton.Text = "Create Team";
            this.createTeamButton.UseVisualStyleBackColor = true;
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1061, 843);
            this.Controls.Add(this.createTeamButton);
            this.Controls.Add(this.deleteSelectedTeamMembersButton);
            this.Controls.Add(this.tournamentPlayersListLabel);
            this.Controls.Add(this.teamMembersListBox);
            this.Controls.Add(this.addNewMembersGroupBox);
            this.Controls.Add(this.addMembersButton);
            this.Controls.Add(this.selectTeamMembersLabel);
            this.Controls.Add(this.selectTeamMembersDropDown);
            this.Controls.Add(this.teamNameValue);
            this.Controls.Add(this.teamNameLabel);
            this.Controls.Add(this.headerLabel);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.addNewMembersGroupBox.ResumeLayout(false);
            this.addNewMembersGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox teamNameValue;
        private System.Windows.Forms.Label teamNameLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.Button addMembersButton;
        private System.Windows.Forms.Label selectTeamMembersLabel;
        private System.Windows.Forms.ComboBox selectTeamMembersDropDown;
        private System.Windows.Forms.GroupBox addNewMembersGroupBox;
        private System.Windows.Forms.TextBox cellphoneValue;
        private System.Windows.Forms.Label cellphoneLabel;
        private System.Windows.Forms.TextBox emailValue;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.TextBox lastNameValue;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox firstNameValue;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button createMembersButton;
        private System.Windows.Forms.Label tournamentPlayersListLabel;
        private System.Windows.Forms.ListBox teamMembersListBox;
        private System.Windows.Forms.Button deleteSelectedTeamMembersButton;
        private System.Windows.Forms.Button createTeamButton;
    }
}