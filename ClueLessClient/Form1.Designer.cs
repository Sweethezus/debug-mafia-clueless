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
            this.queryButton = new System.Windows.Forms.Button();
            this.serverURL_Box = new System.Windows.Forms.TextBox();
            this.responseBox = new System.Windows.Forms.TextBox();
            this.serverURL_Label = new System.Windows.Forms.Label();
            this.responseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // queryButton
            // 
            this.queryButton.Location = new System.Drawing.Point(138, 217);
            this.queryButton.Name = "queryButton";
            this.queryButton.Size = new System.Drawing.Size(75, 23);
            this.queryButton.TabIndex = 0;
            this.queryButton.Text = "Query";
            this.queryButton.UseVisualStyleBackColor = true;
            this.queryButton.Click += new System.EventHandler(this.queryButton_Click);
            // 
            // serverURL_Box
            // 
            this.serverURL_Box.Location = new System.Drawing.Point(138, 176);
            this.serverURL_Box.Name = "serverURL_Box";
            this.serverURL_Box.Size = new System.Drawing.Size(189, 20);
            this.serverURL_Box.TabIndex = 1;
            this.serverURL_Box.Text = "https://clueless.azure-api.net";
            // 
            // responseBox
            // 
            this.responseBox.Location = new System.Drawing.Point(381, 176);
            this.responseBox.Multiline = true;
            this.responseBox.Name = "responseBox";
            this.responseBox.ReadOnly = true;
            this.responseBox.Size = new System.Drawing.Size(282, 125);
            this.responseBox.TabIndex = 2;
            // 
            // serverURL_Label
            // 
            this.serverURL_Label.AutoSize = true;
            this.serverURL_Label.Location = new System.Drawing.Point(69, 176);
            this.serverURL_Label.Name = "serverURL_Label";
            this.serverURL_Label.Size = new System.Drawing.Size(63, 13);
            this.serverURL_Label.TabIndex = 3;
            this.serverURL_Label.Text = "Server URL";
            // 
            // responseLabel
            // 
            this.responseLabel.AutoSize = true;
            this.responseLabel.Location = new System.Drawing.Point(378, 160);
            this.responseLabel.Name = "responseLabel";
            this.responseLabel.Size = new System.Drawing.Size(89, 13);
            this.responseLabel.TabIndex = 4;
            this.responseLabel.Text = "Server Response";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.responseLabel);
            this.Controls.Add(this.serverURL_Label);
            this.Controls.Add(this.responseBox);
            this.Controls.Add(this.serverURL_Box);
            this.Controls.Add(this.queryButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button queryButton;
        private System.Windows.Forms.TextBox serverURL_Box;
        private System.Windows.Forms.TextBox responseBox;
        private System.Windows.Forms.Label serverURL_Label;
        private System.Windows.Forms.Label responseLabel;
    }
}

