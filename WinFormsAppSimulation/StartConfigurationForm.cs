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

        public StartConfigurationForm()
        {
            InitializeComponent();

            OkButton.Click += (sender, args) => Invoke(Ok);
            SetConfigurationButton.Click += (sender, args) => Invoke(StartConfiguration);
            ExportButton.Click += (sender, args) => Invoke(Export);

        }

        private static void Invoke(Action action) => action?.Invoke();

        public new void Show() => base.ShowDialog();

        public string ExportAddress()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = @"C:\";
            saveFileDialog.Title = "Save text Files";
            saveFileDialog.CheckPathExists = true;
            saveFileDialog.DefaultExt = "txt";
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.RestoreDirectory = true;
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return null;
            return saveFileDialog.FileName;
        }
    }
}
