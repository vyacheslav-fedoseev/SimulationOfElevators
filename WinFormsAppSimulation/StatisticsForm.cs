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
    public partial class StatisticsForm : Form
    {
        private SimulationForm simulationForm;
        public StatisticsForm(SimulationForm simulationForm)
        {
            InitializeComponent();
            this.simulationForm = simulationForm;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StatisticsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            simulationForm.Close();
        }
    }
}
