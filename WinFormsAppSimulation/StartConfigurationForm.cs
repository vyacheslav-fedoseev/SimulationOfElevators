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
    public partial class StartConfigurationForm : Form
    {
        public StartConfigurationForm()
        {
            InitializeComponent();
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StartConfigurationForm_Load(object sender, EventArgs e)
        {

        }

        private void SetConfigurationButton_Click(object sender, EventArgs e)
        {
            SetConfigurationForm setConfigurationForm = new SetConfigurationForm();
            setConfigurationForm.ShowDialog();
        }
    }
}
