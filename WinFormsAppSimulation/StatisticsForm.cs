using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenters;

namespace WinFormsAppSimulation
{
    public partial class StatisticsForm : Form, IStatisticsView
    {
        public event Action Exit;
        public event Action StatisticClosing;

        private void Invoke(Action action)
        {
            if (action != null) action();
        }

        //private SimulationForm simulationForm;
        public StatisticsForm(SimulationForm simulationForm)
        {
            InitializeComponent();
            ExitButton.Click += (sender, args) => Invoke(Exit);

            // проверить позже !!!!!!!!!
            FormClosing += (sender, args) => Invoke(StatisticClosing);// проверить позже !!!!!!!!!

            //this.simulationForm = simulationForm;
        }

       /* private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StatisticsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            simulationForm.Close();
        }*/
    }
}
