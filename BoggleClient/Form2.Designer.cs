namespace BoggleClient
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.playerNameTextBox = new System.Windows.Forms.TextBox();
            this.hostNameTextBox = new System.Windows.Forms.TextBox();
            this.playerNameFieldTitle = new System.Windows.Forms.Label();
            this.hostNameLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(119, 141);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // playerNameTextBox
            // 
            this.playerNameTextBox.Location = new System.Drawing.Point(85, 57);
            this.playerNameTextBox.Name = "playerNameTextBox";
            this.playerNameTextBox.Size = new System.Drawing.Size(144, 20);
            this.playerNameTextBox.TabIndex = 1;
            // 
            // hostNameTextBox
            // 
            this.hostNameTextBox.Location = new System.Drawing.Point(85, 102);
            this.hostNameTextBox.Name = "hostNameTextBox";
            this.hostNameTextBox.Size = new System.Drawing.Size(144, 20);
            this.hostNameTextBox.TabIndex = 2;
            // 
            // playerNameFieldTitle
            // 
            this.playerNameFieldTitle.AutoSize = true;
            this.playerNameFieldTitle.Location = new System.Drawing.Point(12, 60);
            this.playerNameFieldTitle.Name = "playerNameFieldTitle";
            this.playerNameFieldTitle.Size = new System.Drawing.Size(67, 13);
            this.playerNameFieldTitle.TabIndex = 3;
            this.playerNameFieldTitle.Text = "Player Name";
            // 
            // hostNameLabel
            // 
            this.hostNameLabel.AutoSize = true;
            this.hostNameLabel.Location = new System.Drawing.Point(12, 102);
            this.hostNameLabel.Name = "hostNameLabel";
            this.hostNameLabel.Size = new System.Drawing.Size(60, 13);
            this.hostNameLabel.TabIndex = 5;
            this.hostNameLabel.Text = "Host Name";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.hostNameLabel);
            this.Controls.Add(this.playerNameFieldTitle);
            this.Controls.Add(this.hostNameTextBox);
            this.Controls.Add(this.playerNameTextBox);
            this.Controls.Add(this.button1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox playerNameTextBox;
        private System.Windows.Forms.TextBox hostNameTextBox;
        private System.Windows.Forms.Label playerNameFieldTitle;
        private System.Windows.Forms.Label hostNameLabel;
    }
}