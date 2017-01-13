namespace RunExeWithArguments
{
    partial class ArgInputWindow
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
            this.runButton = new System.Windows.Forms.Button();
            this.argumentsTextBox = new System.Windows.Forms.TextBox();
            this.argumentsLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // runButton
            // 
            this.runButton.Location = new System.Drawing.Point(297, 70);
            this.runButton.Name = "runButton";
            this.runButton.Size = new System.Drawing.Size(75, 23);
            this.runButton.TabIndex = 1;
            this.runButton.Text = "Run";
            this.runButton.UseVisualStyleBackColor = true;
            this.runButton.Click += new System.EventHandler(this.runButton_Click);
            // 
            // argumentsTextBox
            // 
            this.argumentsTextBox.Location = new System.Drawing.Point(12, 35);
            this.argumentsTextBox.Name = "argumentsTextBox";
            this.argumentsTextBox.Size = new System.Drawing.Size(360, 20);
            this.argumentsTextBox.TabIndex = 0;
            // 
            // argumentsLabel
            // 
            this.argumentsLabel.AutoSize = true;
            this.argumentsLabel.Location = new System.Drawing.Point(12, 9);
            this.argumentsLabel.Name = "argumentsLabel";
            this.argumentsLabel.Size = new System.Drawing.Size(60, 13);
            this.argumentsLabel.TabIndex = 2;
            this.argumentsLabel.Text = "Arguments:";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 70);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 3;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // ArgInputWindow
            // 
            this.AcceptButton = this.runButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(384, 105);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.argumentsLabel);
            this.Controls.Add(this.argumentsTextBox);
            this.Controls.Add(this.runButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ArgInputWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ArgInputWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ArgInputWindow_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button runButton;
        private System.Windows.Forms.TextBox argumentsTextBox;
        private System.Windows.Forms.Label argumentsLabel;
        private System.Windows.Forms.Button cancelButton;
    }
}

