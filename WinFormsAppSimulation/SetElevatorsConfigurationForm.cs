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


        private SetConfigurationForm setConfigurationForm;
        public SetElevatorsConfigurationForm(SetConfigurationForm setConfigurationForm)
        {
            InitializeComponent();
            this.setConfigurationForm = setConfigurationForm;
            EndLiftsConfigurationButton.Click += (sender, args) => Invoke(EndLiftsConfiguration);
            FormClosing += (sender, args) => Invoke(SetElevatorsConfigurationClosing);
        }
        
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
