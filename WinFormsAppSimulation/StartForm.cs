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
    public partial class StartForm : Form, IStartView
    {
        public event Action StartConfiguration;
        public event Action Exit;
        public event Action StrategyChoosing;
        public event Action StartSimulation;
        public event Action CreateEventsList;

        private void Invoke(Action action)
        {
            if (action != null) action();
        }

        public StartForm()
        {
            InitializeComponent();
            StartConfigurationButton.Click += (sender, args) => Invoke(StartConfiguration);
            ExitButton.Click += (sender, args) => Invoke(Exit);
            StrategyChoosingButton.Click += (sender, args) => Invoke(StrategyChoosing);
            StartConfigurationButton.Click += (sender, args) => Invoke(StartConfiguration);
            CreateEventsListButton.Click += (sender, args) => Invoke(CreateEventsList);
            //var presenter = new StartFormPresenter(this);
        }

        /*
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
        */
    }
}
