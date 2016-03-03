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
            this.login.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login.ForeColor = System.Drawing.SystemColors.WindowText;
            this.login.Location = new System.Drawing.Point(0, 128);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(334, 33);
            this.login.TabIndex = 1;
            this.login.Text = "LOGIN";
            this.login.UseVisualStyleBackColor = true;
            this.login.Click += new System.EventHandler(this.login_Click);
            // 
            // uidTextBox
            // 
            this.uidTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uidTextBox.Location = new System.Drawing.Point(12, 12);
            this.uidTextBox.Name = "uidTextBox";
            this.uidTextBox.Size = new System.Drawing.Size(310, 26);
            this.uidTextBox.TabIndex = 2;
            // 
            // pwdTextBox
            // 
            this.pwdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdTextBox.Location = new System.Drawing.Point(12, 64);
            this.pwdTextBox.Name = "pwdTextBox";
            this.pwdTextBox.PasswordChar = '*';
            this.pwdTextBox.Size = new System.Drawing.Size(310, 26);
            this.pwdTextBox.TabIndex = 3;
            // 
            // uidLabel
            // 
            this.uidLabel.AutoSize = true;
            this.uidLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uidLabel.Location = new System.Drawing.Point(8, 41);
            this.uidLabel.Name = "uidLabel";
            this.uidLabel.Size = new System.Drawing.Size(83, 20);
            this.uidLabel.TabIndex = 4;
            this.uidLabel.Text = "Username";
            // 
            // pwdLabel
            // 
            this.pwdLabel.AutoSize = true;
            this.pwdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pwdLabel.Location = new System.Drawing.Point(8, 93);
            this.pwdLabel.Name = "pwdLabel";
            this.pwdLabel.Size = new System.Drawing.Size(78, 20);
            this.pwdLabel.TabIndex = 5;
            this.pwdLabel.Text = "Password";
            // 
            // loginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(334, 161);
            this.Controls.Add(this.pwdLabel);
            this.Controls.Add(this.uidLabel);
            this.Controls.Add(this.pwdTextBox);
            this.Controls.Add(this.uidTextBox);
            this.Controls.Add(this.login);
            this.ForeColor = System.Drawing.SystemColors.Window;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
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

