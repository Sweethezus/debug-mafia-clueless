namespace ClueLessClient
{
    partial class Form1
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
            this.connectButton = new System.Windows.Forms.Button();
            this.connectionStringTextBox = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.serverAddressLabel = new System.Windows.Forms.Label();
            this.serverResponseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // connectButton
            // 
            this.connectButton.Location = new System.Drawing.Point(12, 49);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(75, 23);
            this.connectButton.TabIndex = 0;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = true;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // connectionStringTextBox
            // 
            this.connectionStringTextBox.Location = new System.Drawing.Point(12, 23);
            this.connectionStringTextBox.Name = "connectionStringTextBox";
            this.connectionStringTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.connectionStringTextBox.Size = new System.Drawing.Size(100, 20);
            this.connectionStringTextBox.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox2.Location = new System.Drawing.Point(148, 23);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 2;
            // 
            // serverAddressLabel
            // 
            this.serverAddressLabel.AutoSize = true;
            this.serverAddressLabel.Location = new System.Drawing.Point(12, 7);
            this.serverAddressLabel.Name = "serverAddressLabel";
            this.serverAddressLabel.Size = new System.Drawing.Size(79, 13);
            this.serverAddressLabel.TabIndex = 3;
            this.serverAddressLabel.Text = "Server Address";
            // 
            // serverResponseLabel
            // 
            this.serverResponseLabel.AutoSize = true;
            this.serverResponseLabel.Location = new System.Drawing.Point(145, 7);
            this.serverResponseLabel.Name = "serverResponseLabel";
            this.serverResponseLabel.Size = new System.Drawing.Size(89, 13);
            this.serverResponseLabel.TabIndex = 4;
            this.serverResponseLabel.Text = "Server Response";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 93);
            this.Controls.Add(this.serverResponseLabel);
            this.Controls.Add(this.serverAddressLabel);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.connectionStringTextBox);
            this.Controls.Add(this.connectButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.TextBox connectionStringTextBox;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label serverAddressLabel;
        private System.Windows.Forms.Label serverResponseLabel;
    }
}

