using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WinFormsAppSimulation
{
    public partial class SetConfigurationForm : Form
    {
        public SetConfigurationForm()
        {
            InitializeComponent();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            Form setElevatorsConfigurationForm = new SetElevatorsConfigurationForm(this);
            setElevatorsConfigurationForm.ShowDialog();
        }

    }
}
