using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenters.IViews;

namespace WinFormsAppSimulation
{
    public partial class StartConfigurationForm : Form, IStartConfigurationView
    {
        public event Action Ok;
        public event Action StartConfiguration;
        public event Action Export;
        public event Action Import;

        public StartConfigurationForm()
        {
            InitializeComponent();

            OkButton.Click += (sender, args) => Invoke(Ok);
            SetConfigurationButton.Click += (sender, args) =>
            {
                Invoke(StartConfiguration);
                ExportButton.Enabled = true;
                ErrorImportLabel.Text = string.Empty;
            };
            ExportButton.Click += (sender, args) => Invoke(Export);
            ImportButton.Click += (sender, args) => Invoke(Import);
        }

        private static void Invoke(Action action) => action?.Invoke();

        public new void Show() => base.ShowDialog();

        public string ExportAddress()
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.Title = "Save text Files";
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            return saveFileDialog.ShowDialog() == DialogResult.Cancel ? null : saveFileDialog.FileName;
        }

        public string ImportAddress()
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = @"C:\";
            openFileDialog.Title = "Save text Files";
            openFileDialog.CheckPathExists = true;
            openFileDialog.CheckFileExists = true;
            openFileDialog.DefaultExt = "txt";
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.FilterIndex = 2;
            openFileDialog.RestoreDirectory = true;
            if (openFileDialog.ShowDialog() != DialogResult.Cancel)
            {
                ErrorImportLabel.Text = string.Empty;
                ExportButton.Enabled = true;
                return openFileDialog.FileName;
            }
            // ErrorImportLabel.Text = string.Empty;
            return null;
        }
        
        public void ShowError(string message) => ErrorImportLabel.Text = message;
    }
}
