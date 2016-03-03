namespace AR_MAC_DB
{
    partial class userForm
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
            this.consoleListBox = new System.Windows.Forms.ListBox();
            this.commandTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // consoleListBox
            // 
            this.consoleListBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.consoleListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consoleListBox.ForeColor = System.Drawing.Color.Lime;
            this.consoleListBox.FormattingEnabled = true;
            this.consoleListBox.ItemHeight = 20;
            this.consoleListBox.Location = new System.Drawing.Point(12, 49);
            this.consoleListBox.Name = "consoleListBox";
            this.consoleListBox.Size = new System.Drawing.Size(760, 384);
            this.consoleListBox.TabIndex = 0;
            // 
            // commandTextBox
            // 
            this.commandTextBox.BackColor = System.Drawing.SystemColors.WindowText;
            this.commandTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commandTextBox.ForeColor = System.Drawing.Color.Lime;
            this.commandTextBox.Location = new System.Drawing.Point(12, 12);
            this.commandTextBox.Name = "commandTextBox";
            this.commandTextBox.Size = new System.Drawing.Size(760, 26);
            this.commandTextBox.TabIndex = 1;
            this.commandTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.commandTextBox_KeyPress);
            // 
            // userForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowText;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.commandTextBox);
            this.Controls.Add(this.consoleListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "userForm";
            this.Text = "User Panel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox consoleListBox;
        private System.Windows.Forms.TextBox commandTextBox;
    }
}