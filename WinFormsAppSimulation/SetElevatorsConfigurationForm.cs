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
        public new void Show()
        {
            base.ShowDialog();
        }
        private void Invoke(Action action)
        {
            if (action != null) action();
        }
        public void ShowError(string message)
        {
            ErrorLabel.Text = message;
        }
        public void HideError()
        {
            ErrorLabel.Text = "";
        }

        public string maxSpeed { get { return MaxAccelerationTextBox.Text; } }
        public string maxAcceleration { get { return MaxAccelerationTextBox.Text; } }
        public string capacity { get { return CapacityTextBox.Text; } }
        public bool isTemplate { get { return TamplateCheckBox.Checked; } }
        /*
        private void EndLiftsConfigurationButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void SetElevatorsConfigurationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            setConfigurationForm.Close();
        }
        */
    }
}
