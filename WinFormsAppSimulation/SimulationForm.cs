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
    public partial class SimulationForm : Form
    {
        private StartForm startForm;
        public SimulationForm(StartForm startForm)
        {
            InitializeComponent();
            this.startForm = startForm;
        }

        private void SimulationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            startForm.Show();
        }

        private void CreatePeopleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreatePeopleForm createPeopleForm = new CreatePeopleForm();
            createPeopleForm.Show();
        }

        private void CheckPeopleStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckPeopleStatusForm checkPeopleStatusForm = new CheckPeopleStatusForm();
            checkPeopleStatusForm.Show();
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            StatisticsForm statisticsForm = new StatisticsForm(this);
            statisticsForm.ShowDialog();
        }
    }
}
