using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace RunExeWithArguments
{
    public partial class ArgInputWindow : Form
    {
        private readonly string _filePath;

        public ArgInputWindow()
        {
            InitializeComponent();

            string[] args = Environment.GetCommandLineArgs();

            if (args.Length == 2)
            {
                _filePath = args[1];
            }
        }

        private void ArgInputWindow_Load(object sender, EventArgs e)
        {
            // Check if the file actually exists
            if (!File.Exists(_filePath))
            {
                Error("The file was not found.");
                Exit();
            }
            else
                Text = string.Format("Run {0}...", Path.GetFileName(_filePath));
        }

        // Starts the process with the arguments when the run button is clicked and exits this application
        private void runButton_Click(object sender, EventArgs e)
        {
            // Check if the file has not been removed in the mean time
            if (!File.Exists(_filePath))
            {
                Error("The file can no longer be found.");
            }
            else
            {
                Process process = new Process
                {
                    StartInfo = new ProcessStartInfo(_filePath, argumentsTextBox.Text)
                };

                process.Start();
            }
            
            Exit();
        }

        // Exit when the cancel button is clicked
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Exit();
        }

        // Exit when the user presses the Escape button
        private void ArgInputWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Exit();
        }

        // Exits the application
        private void Exit()
        {
            Application.Exit();
        }

        // Shows a message box with an error
        private void Error(string message)
        {
            MessageBox.Show(
                message,
                "Error!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error,
                MessageBoxDefaultButton.Button1);
        }
    }
}
