namespace AR_MAC_DB
{
    partial class soForm
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
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.listUsersButton = new System.Windows.Forms.Button();
            this.addUserButton = new System.Windows.Forms.Button();
            this.modifyUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.viewLogButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.listUsersListBox = new System.Windows.Forms.ListBox();
            this.fnameTextBox = new System.Windows.Forms.TextBox();
            this.lnameTextBox = new System.Windows.Forms.TextBox();
            this.uidTextBox = new System.Windows.Forms.TextBox();
            this.pwdTextBox = new System.Windows.Forms.TextBox();
            this.permComboBox = new System.Windows.Forms.ComboBox();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.listTablesButton = new System.Windows.Forms.Button();
            this.modifyTableButton = new System.Windows.Forms.Button();
            this.listTablesListBox = new System.Windows.Forms.ListBox();
            this.tableNameTextBox = new System.Windows.Forms.TextBox();
            this.tablePermComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Location = new System.Drawing.Point(12, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(55, 13);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Welcome!";
            // 
            // listUsersButton
            // 
            this.listUsersButton.Location = new System.Drawing.Point(12, 62);
            this.listUsersButton.Name = "listUsersButton";
            this.listUsersButton.Size = new System.Drawing.Size(100, 23);
            this.listUsersButton.TabIndex = 1;
            this.listUsersButton.Text = "List Users";
            this.listUsersButton.UseVisualStyleBackColor = true;
            this.listUsersButton.Click += new System.EventHandler(this.listUsersButton_Click);
            // 
            // addUserButton
            // 
            this.addUserButton.Location = new System.Drawing.Point(12, 91);
            this.addUserButton.Name = "addUserButton";
            this.addUserButton.Size = new System.Drawing.Size(100, 23);
            this.addUserButton.TabIndex = 2;
            this.addUserButton.Text = "Add User";
            this.addUserButton.UseVisualStyleBackColor = true;
            this.addUserButton.Click += new System.EventHandler(this.addUserButton_Click);
            // 
            // modifyUserButton
            // 
            this.modifyUserButton.Location = new System.Drawing.Point(12, 120);
            this.modifyUserButton.Name = "modifyUserButton";
            this.modifyUserButton.Size = new System.Drawing.Size(100, 23);
            this.modifyUserButton.TabIndex = 3;
            this.modifyUserButton.Text = "Modify User";
            this.modifyUserButton.UseVisualStyleBackColor = true;
            this.modifyUserButton.Click += new System.EventHandler(this.modifyUserButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.Location = new System.Drawing.Point(12, 149);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(100, 23);
            this.deleteUserButton.TabIndex = 4;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = true;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // viewLogButton
            // 
            this.viewLogButton.Location = new System.Drawing.Point(606, 121);
            this.viewLogButton.Name = "viewLogButton";
            this.viewLogButton.Size = new System.Drawing.Size(100, 23);
            this.viewLogButton.TabIndex = 5;
            this.viewLogButton.Text = "View Log";
            this.viewLogButton.UseVisualStyleBackColor = true;
            this.viewLogButton.Click += new System.EventHandler(this.viewLogButton_Click);
            // 
            // logoutButton
            // 
            this.logoutButton.Location = new System.Drawing.Point(607, 150);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(99, 23);
            this.logoutButton.TabIndex = 6;
            this.logoutButton.Text = "Log Out";
            this.logoutButton.UseVisualStyleBackColor = true;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // listUsersListBox
            // 
            this.listUsersListBox.FormattingEnabled = true;
            this.listUsersListBox.Location = new System.Drawing.Point(118, 62);
            this.listUsersListBox.Name = "listUsersListBox";
            this.listUsersListBox.Size = new System.Drawing.Size(376, 160);
            this.listUsersListBox.TabIndex = 7;
            this.listUsersListBox.Click += new System.EventHandler(this.listUsersListBox_Click);
            // 
            // fnameTextBox
            // 
            this.fnameTextBox.Location = new System.Drawing.Point(500, 62);
            this.fnameTextBox.Name = "fnameTextBox";
            this.fnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.fnameTextBox.TabIndex = 8;
            // 
            // lnameTextBox
            // 
            this.lnameTextBox.Location = new System.Drawing.Point(500, 89);
            this.lnameTextBox.Name = "lnameTextBox";
            this.lnameTextBox.Size = new System.Drawing.Size(100, 20);
            this.lnameTextBox.TabIndex = 9;
            // 
            // uidTextBox
            // 
            this.uidTextBox.Location = new System.Drawing.Point(500, 116);
            this.uidTextBox.Name = "uidTextBox";
            this.uidTextBox.Size = new System.Drawing.Size(100, 20);
            this.uidTextBox.TabIndex = 10;
            // 
            // pwdTextBox
            // 
            this.pwdTextBox.Location = new System.Drawing.Point(500, 143);
            this.pwdTextBox.Name = "pwdTextBox";
            this.pwdTextBox.Size = new System.Drawing.Size(100, 20);
            this.pwdTextBox.TabIndex = 11;
            // 
            // permComboBox
            // 
            this.permComboBox.FormattingEnabled = true;
            this.permComboBox.Location = new System.Drawing.Point(500, 169);
            this.permComboBox.Name = "permComboBox";
            this.permComboBox.Size = new System.Drawing.Size(100, 21);
            this.permComboBox.TabIndex = 12;
            // 
            // logListBox
            // 
            this.logListBox.FormattingEnabled = true;
            this.logListBox.Location = new System.Drawing.Point(12, 233);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(976, 277);
            this.logListBox.TabIndex = 14;
            // 
            // listTablesButton
            // 
            this.listTablesButton.Location = new System.Drawing.Point(606, 62);
            this.listTablesButton.Name = "listTablesButton";
            this.listTablesButton.Size = new System.Drawing.Size(100, 23);
            this.listTablesButton.TabIndex = 15;
            this.listTablesButton.Text = "List Tables";
            this.listTablesButton.UseVisualStyleBackColor = true;
            this.listTablesButton.Click += new System.EventHandler(this.listTablesButton_Click);
            // 
            // modifyTableButton
            // 
            this.modifyTableButton.Location = new System.Drawing.Point(606, 92);
            this.modifyTableButton.Name = "modifyTableButton";
            this.modifyTableButton.Size = new System.Drawing.Size(100, 23);
            this.modifyTableButton.TabIndex = 16;
            this.modifyTableButton.Text = "Modify Table";
            this.modifyTableButton.UseVisualStyleBackColor = true;
            this.modifyTableButton.Click += new System.EventHandler(this.modifyTableButton_Click);
            // 
            // listTablesListBox
            // 
            this.listTablesListBox.FormattingEnabled = true;
            this.listTablesListBox.Location = new System.Drawing.Point(712, 62);
            this.listTablesListBox.Name = "listTablesListBox";
            this.listTablesListBox.Size = new System.Drawing.Size(171, 160);
            this.listTablesListBox.TabIndex = 17;
            this.listTablesListBox.Click += new System.EventHandler(this.listTablesListBox_Click);
            // 
            // tableNameTextBox
            // 
            this.tableNameTextBox.Location = new System.Drawing.Point(889, 62);
            this.tableNameTextBox.Name = "tableNameTextBox";
            this.tableNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.tableNameTextBox.TabIndex = 18;
            // 
            // tablePermComboBox
            // 
            this.tablePermComboBox.FormattingEnabled = true;
            this.tablePermComboBox.Location = new System.Drawing.Point(889, 88);
            this.tablePermComboBox.Name = "tablePermComboBox";
            this.tablePermComboBox.Size = new System.Drawing.Size(100, 21);
            this.tablePermComboBox.TabIndex = 20;
            // 
            // soForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 522);
            this.Controls.Add(this.tablePermComboBox);
            this.Controls.Add(this.tableNameTextBox);
            this.Controls.Add(this.listTablesListBox);
            this.Controls.Add(this.modifyTableButton);
            this.Controls.Add(this.listTablesButton);
            this.Controls.Add(this.logListBox);
            this.Controls.Add(this.permComboBox);
            this.Controls.Add(this.pwdTextBox);
            this.Controls.Add(this.uidTextBox);
            this.Controls.Add(this.lnameTextBox);
            this.Controls.Add(this.fnameTextBox);
            this.Controls.Add(this.listUsersListBox);
            this.Controls.Add(this.logoutButton);
            this.Controls.Add(this.viewLogButton);
            this.Controls.Add(this.deleteUserButton);
            this.Controls.Add(this.modifyUserButton);
            this.Controls.Add(this.addUserButton);
            this.Controls.Add(this.listUsersButton);
            this.Controls.Add(this.welcomeLabel);
            this.Name = "soForm";
            this.Text = "System Officer Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Button listUsersButton;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button modifyUserButton;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button viewLogButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.ListBox listUsersListBox;
        private System.Windows.Forms.TextBox fnameTextBox;
        private System.Windows.Forms.TextBox lnameTextBox;
        private System.Windows.Forms.TextBox uidTextBox;
        private System.Windows.Forms.TextBox pwdTextBox;
        private System.Windows.Forms.ComboBox permComboBox;
        private System.Windows.Forms.ListBox logListBox;
        private System.Windows.Forms.Button listTablesButton;
        private System.Windows.Forms.Button modifyTableButton;
        private System.Windows.Forms.ListBox listTablesListBox;
        private System.Windows.Forms.TextBox tableNameTextBox;
        private System.Windows.Forms.ComboBox tablePermComboBox;
    }
}