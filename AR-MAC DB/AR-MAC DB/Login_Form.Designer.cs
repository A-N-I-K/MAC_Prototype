namespace AR_MAC_DB
{
    partial class loginForm
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
            this.login = new System.Windows.Forms.Button();
            this.uidTextBox = new System.Windows.Forms.TextBox();
            this.pwdTextBox = new System.Windows.Forms.TextBox();
            this.uidLabel = new System.Windows.Forms.Label();
            this.pwdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login
            // 
            this.login.Location = new System.Drawing.Point(355, 185);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(75, 23);
            this.login.TabIndex = 1;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // uidTextBox
            // 
            this.uidTextBox.Location = new System.Drawing.Point(355, 133);
            this.uidTextBox.Name = "uidTextBox";
            this.uidTextBox.Size = new System.Drawing.Size(100, 20);
            this.uidTextBox.TabIndex = 2;
            this.uidTextBox.Text = "mrk123";
            // 
            // pwdTextBox
            // 
            this.pwdTextBox.Location = new System.Drawing.Point(355, 159);
            this.pwdTextBox.Name = "pwdTextBox";
            this.pwdTextBox.Size = new System.Drawing.Size(100, 20);
            this.pwdTextBox.TabIndex = 3;
            this.pwdTextBox.Text = "test123";
            // 
            // uidLabel
            // 
            this.uidLabel.AutoSize = true;
            this.uidLabel.Location = new System.Drawing.Point(294, 136);
            this.uidLabel.Name = "uidLabel";
            this.uidLabel.Size = new System.Drawing.Size(55, 13);
            this.uidLabel.TabIndex = 4;
            this.uidLabel.Text = "Username";
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.Location = new System.Drawing.Point(296, 162);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(53, 13);
            this.pwdLabel.TabIndex = 5;
            this.pwdLabel.Text = "Password";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.uidLabel);
            this.Controls.Add(this.pwdTextBox);
            this.Controls.Add(this.uidTextBox);
            this.Controls.Add(this.login);
            this.Name = "loginForm";
            this.Text = "Login Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button login;
        private System.Windows.Forms.TextBox uidTextBox;
        private System.Windows.Forms.TextBox pwdTextBox;
        private System.Windows.Forms.Label uidLabel;
        private System.Windows.Forms.Label pwdLabel;
    }
}

