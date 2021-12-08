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
        public string elevatorsCount { get { return elevatorsCountTextBox.Text;} }
        public string floorsCount { get { return floorsCountTextBox.Text;} }
        public SetConfigurationForm()
        {
            InitializeComponent();
            NextButton.Click += (sender, args) => Invoke(Next);
        }

        public void ShowError(string message)
        {
            errorLabel.Text = message;
        }
        public void HideError()
        {
            errorLabel.Text = "";
        }


        private void Invoke(Action action)
        {
            if (action != null) action();
        }
        public new void Show()
        {
            base.ShowDialog();
        }
        /*
        private void NextButton_Click(object sender, EventArgs e)
        {
            Form setElevatorsConfigurationForm = new SetElevatorsConfigurationForm(this);
            setElevatorsConfigurationForm.ShowDialog();
        }
        */

    }
}
