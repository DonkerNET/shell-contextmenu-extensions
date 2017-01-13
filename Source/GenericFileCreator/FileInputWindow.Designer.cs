namespace GenericFileCreator
{
    partial class FileInputWindow
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
            this.createButton = new System.Windows.Forms.Button();
            this.fileSizeLabel = new System.Windows.Forms.Label();
            this.fileNameLabel = new System.Windows.Forms.Label();
            this.fileSizeTextBox = new System.Windows.Forms.TextBox();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.unitComboBox = new System.Windows.Forms.ComboBox();
            this.bitValueLabel = new System.Windows.Forms.Label();
            this.bitValue0RadioButton = new System.Windows.Forms.RadioButton();
            this.bitValue1Label = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
            // 
            // createButton
            // 
            this.createButton.Location = new System.Drawing.Point(197, 127);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(75, 23);
            this.createButton.TabIndex = 0;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = true;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // fileSizeLabel
            // 
            this.fileSizeLabel.AutoSize = true;
            this.fileSizeLabel.Location = new System.Drawing.Point(12, 9);
            this.fileSizeLabel.Name = "fileSizeLabel";
            this.fileSizeLabel.Size = new System.Drawing.Size(47, 13);
            this.fileSizeLabel.TabIndex = 1;
            this.fileSizeLabel.Text = "File size:";
            // 
            // fileNameLabel
            // 
            this.fileNameLabel.AutoSize = true;
            this.fileNameLabel.Location = new System.Drawing.Point(12, 81);
            this.fileNameLabel.Name = "fileNameLabel";
            this.fileNameLabel.Size = new System.Drawing.Size(55, 13);
            this.fileNameLabel.TabIndex = 2;
            this.fileNameLabel.Text = "File name:";
            // 
            // fileSizeTextBox
            // 
            this.fileSizeTextBox.Location = new System.Drawing.Point(12, 25);
            this.fileSizeTextBox.MaxLength = 8;
            this.fileSizeTextBox.Name = "fileSizeTextBox";
            this.fileSizeTextBox.Size = new System.Drawing.Size(156, 20);
            this.fileSizeTextBox.TabIndex = 3;
            this.fileSizeTextBox.Text = "1";
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Location = new System.Drawing.Point(12, 97);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(260, 20);
            this.fileNameTextBox.TabIndex = 4;
            this.fileNameTextBox.Text = "New generic file";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(12, 127);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // unitComboBox
            // 
            this.unitComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unitComboBox.FormattingEnabled = true;
            this.unitComboBox.Location = new System.Drawing.Point(174, 24);
            this.unitComboBox.Name = "unitComboBox";
            this.unitComboBox.Size = new System.Drawing.Size(98, 21);
            this.unitComboBox.TabIndex = 6;
            // 
            // bitValueLabel
            // 
            this.bitValueLabel.AutoSize = true;
            this.bitValueLabel.Location = new System.Drawing.Point(12, 53);
            this.bitValueLabel.Name = "bitValueLabel";
            this.bitValueLabel.Size = new System.Drawing.Size(51, 13);
            this.bitValueLabel.TabIndex = 7;
            this.bitValueLabel.Text = "Bit value:";
            // 
            // bitValue0RadioButton
            // 
            this.bitValue0RadioButton.AutoSize = true;
            this.bitValue0RadioButton.Location = new System.Drawing.Point(69, 51);
            this.bitValue0RadioButton.Name = "bitValue0RadioButton";
            this.bitValue0RadioButton.Size = new System.Drawing.Size(31, 17);
            this.bitValue0RadioButton.TabIndex = 8;
            this.bitValue0RadioButton.Text = "0";
            this.bitValue0RadioButton.UseVisualStyleBackColor = true;
            // 
            // bitValue1Label
            // 
            this.bitValue1Label.AutoSize = true;
            this.bitValue1Label.Checked = true;
            this.bitValue1Label.Location = new System.Drawing.Point(106, 51);
            this.bitValue1Label.Name = "bitValue1Label";
            this.bitValue1Label.Size = new System.Drawing.Size(31, 17);
            this.bitValue1Label.TabIndex = 9;
            this.bitValue1Label.TabStop = true;
            this.bitValue1Label.Text = "1";
            this.bitValue1Label.UseVisualStyleBackColor = true;
            // 
            // FileInputWindow
            // 
            this.AcceptButton = this.createButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size(284, 162);
            this.Controls.Add(this.bitValue1Label);
            this.Controls.Add(this.bitValue0RadioButton);
            this.Controls.Add(this.bitValueLabel);
            this.Controls.Add(this.unitComboBox);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.fileNameTextBox);
            this.Controls.Add(this.fileSizeTextBox);
            this.Controls.Add(this.fileNameLabel);
            this.Controls.Add(this.fileSizeLabel);
            this.Controls.Add(this.createButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FileInputWindow";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Create generic file...";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.FileInputWindow_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SettingsWindow_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Label fileSizeLabel;
        private System.Windows.Forms.Label fileNameLabel;
        private System.Windows.Forms.TextBox fileSizeTextBox;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ComboBox unitComboBox;
        private System.Windows.Forms.Label bitValueLabel;
        private System.Windows.Forms.RadioButton bitValue0RadioButton;
        private System.Windows.Forms.RadioButton bitValue1Label;
    }
}

