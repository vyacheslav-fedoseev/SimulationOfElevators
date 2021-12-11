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
    public partial class SetConfigurationForm : Form, ISetConfigurationView
    {
        public event Action Next;
        public string ElevatorsCount => elevatorsCountTextBox.Text;
        public string FloorsCount => floorsCountTextBox.Text;

        public SetConfigurationForm()
        {
            InitializeComponent();
            NextButton.Click += (sender, args) => Invoke(Next);
        }
        public void ShowError(string message) => errorLabel.Text = message;

        public void HideError() => errorLabel.Text = string.Empty;

        private static void Invoke(Action action) => action?.Invoke();

        public new void Show() => base.ShowDialog();
    }
}
