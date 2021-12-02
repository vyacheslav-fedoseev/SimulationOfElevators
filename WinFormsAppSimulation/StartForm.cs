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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

    

        private void StartConfigurationButton_Click(object sender, EventArgs e)
        {
            StartConfigurationForm startConfigurationForm = new StartConfigurationForm();
            startConfigurationForm.Show();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StrategyChoosingButton_Click(object sender, EventArgs e)
        {
            StrategyChoosingForm strategyChoosingForm = new StrategyChoosingForm();
            strategyChoosingForm.ShowDialog();
        }

        private void StartSimulationButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SimulationForm simulationForm = new SimulationForm(this);
            simulationForm.ShowDialog();
  
        }

        private void CreateEventsListButton_Click(object sender, EventArgs e)
        {

        }
    }
}
