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
    public partial class StatisticsForm : Form, IStatisticsView
    {
        public event Action Exit;
        public event Action StatisticClosing;

        private void Invoke(Action action)
        {
            if (action != null) action();
        }

        //private SimulationForm simulationForm;
        public StatisticsForm()
        {
            InitializeComponent();
            ExitButton.Click += (sender, args) => Invoke(Exit);

            Load.Click += (sender, args) => Invoke(StatisticClosing);
            //this.simulationForm = simulationForm;
        }
        public new void Show()
        {
            base.ShowDialog();
        }

        private void StatisticsForm_Load(object sender, EventArgs e)
        {

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
