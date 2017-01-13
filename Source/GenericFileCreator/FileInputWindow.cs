using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace GenericFileCreator
{
    public partial class FileInputWindow : Form
    {
        private readonly string _directory;
        private readonly string[] _units;

        public FileInputWindow()
        {
            InitializeComponent();
            _units = new[] { "B", "KiB", "MiB", "GiB", "TiB" }; // terrabytes... should be fun  :-)

            // Get the directory from the arguments
            string[] args = Environment.GetCommandLineArgs();
            if (args.Length == 2)
                _directory = args[1];

            // Remove the last slash from the directory
            if (!string.IsNullOrEmpty(_directory))
            {
                int lastSlashIndex = _directory.LastIndexOf('/');
                if (lastSlashIndex < 0)
                    lastSlashIndex = _directory.LastIndexOf('\\');
                _directory = _directory.Substring(0, lastSlashIndex);
            }

            // Use the working directory if no directory was specified
            if (_directory == null || !Directory.Exists(_directory))
                _directory = string.Empty;
        }

        private void FileInputWindow_Load(object sender, EventArgs e)
        {
            // Bind the selectable units
            unitComboBox.DataSource = _units;
            unitComboBox.SelectedIndex = 2;
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            // File size is required
            if (string.IsNullOrEmpty(fileSizeTextBox.Text))
            {
                ValidationError("Specify a file size!");
                return;
            }

            // Determine the actual file size and the value of the bytes to write
            long multiplier = (long)Math.Pow(1024, unitComboBox.SelectedIndex);
            long fileSize = long.Parse(fileSizeTextBox.Text);
            byte byteValue = bitValue0RadioButton.Checked ? byte.MinValue : byte.MaxValue;
            
            // File name is required
            string fileName = fileNameTextBox.Text;
            if (string.IsNullOrEmpty(fileName))
            {
                ValidationError("Specify a file name!");
                return;
            }

            // If a file exists the user should confirm to overwrite
            string filePath = Path.Combine(_directory, fileName);
            if (File.Exists(filePath))
            {
                DialogResult overwriteResult = MessageBox.Show(
                    "The file already exists. Overwrite?",
                    "File exists.",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2);

                if (overwriteResult == DialogResult.No)
                    return;
            }

            // Disable any input from the user
            Enabled = false;

            // Perform the file creation on a separate thread

            BackgroundWorker bgWorker = new BackgroundWorker
            {
                WorkerReportsProgress = true
            };

            bgWorker.DoWork += (o, args) =>
            {
                using (FileStream stream = File.Create(filePath))
                {
                    long multiplierUpdateValue = multiplier / 100L;

                    for (long m = 1; m <= multiplier; ++m)
                    {
                        for (long b = 0; b < fileSize; ++b)
                        {
                            stream.WriteByte(byteValue);
                        }
                        
                        if (m % multiplierUpdateValue == 0)
                            bgWorker.ReportProgress((int)(m / multiplierUpdateValue));
                    }

                    stream.Flush();
                }
            };

            const string statusUpdateFormat = "{0}% - Creating generic file...";

            // Set the updated percentage in the Window title
            bgWorker.ProgressChanged += (o, args) => Text = string.Format(statusUpdateFormat, args.ProgressPercentage.ToString("000"));
            
            // Exit the application when the file has been created without any problems
            bgWorker.RunWorkerCompleted += (o, args) => Exit();
            
            // Set the initial percentage in the Window title
            Text = string.Format(statusUpdateFormat, "000");
            
            // Start file creation
            bgWorker.RunWorkerAsync();
        }

        // Exit when the cancel button is clicked
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Exit();
        }

        // Exit when the user presses the Escape button
        private void SettingsWindow_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Exit();
        }

        // Exits the application
        private void Exit()
        {
            Application.Exit();
        }

        // Shows a message box with a validation error
        private void ValidationError(string message)
        {
            MessageBox.Show(
                message,
                "Validation error!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning,
                MessageBoxDefaultButton.Button1);
        }
    }
}
