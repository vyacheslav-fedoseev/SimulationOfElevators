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
    public partial class SetElevatorsConfigurationForm : Form, ISetElevatorsConfigurationView
    {
        public event Action EndLiftsConfiguration;
        public event Action SetElevatorsConfigurationClosing;
        public event Action AddElevator;

        public SetElevatorsConfigurationForm()
        {
            InitializeComponent();
            EndLiftsConfigurationButton.Click += (sender, args) => Invoke(EndLiftsConfiguration);
            AddElevatorButton.Click += (sender, args) => Invoke(AddElevator);
            FormClosing += (sender, args) => Invoke(SetElevatorsConfigurationClosing);
        }
        public new void Show() => base.ShowDialog();

        public void Invoke(Action action) => action?.Invoke();

        public void ShowError(string message) => ErrorLabel.Text = message;

        public void HideError() => ErrorLabel.Text = string.Empty;

        public string MaxSpeed => MaxAccelerationTextBox.Text;

        public string MaxAcceleration => MaxAccelerationTextBox.Text;

        public string Capacity => CapacityTextBox.Text;

        public bool IsTemplate => TamplateCheckBox.Checked;
    }
}
