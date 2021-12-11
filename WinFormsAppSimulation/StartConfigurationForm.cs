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

        public StartConfigurationForm()
        {
            InitializeComponent();

            OkButton.Click += (sender, args) => Invoke(Ok);
            SetConfigurationButton.Click += (sender, args) => Invoke(StartConfiguration);
        }

        private static void Invoke(Action action) => action?.Invoke();

        public new void Show() => base.ShowDialog();
    }
}
