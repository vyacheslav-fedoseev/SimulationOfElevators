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
        public SetConfigurationForm()
        {
            InitializeComponent();
            NextButton.Click += (sender, args) => Invoke(Next);
        }

        private void Invoke(Action action)
        {
            if (action != null) action();
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
