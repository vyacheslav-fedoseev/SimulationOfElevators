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
    public partial class StartForm : Form, IStartView
    {
        private static int _firstLaunch = 0;
        public event Action StartConfiguration;
        public event Action Exit;
        public event Action StrategyChoosing;
        public event Action StartSimulation;
        public event Action CreateEventsList;

        public StartForm()
        {
            InitializeComponent();
            StartConfigurationButton.Click += (sender, args) => Invoke(StartConfiguration);
            ExitButton.Click += (sender, args) => Invoke(Exit);
            StrategyChoosingButton.Click += (sender, args) => Invoke(StrategyChoosing);
            StartSimulationButton.Click += (sender, args) => Invoke(StartSimulation);
            CreateEventsListButton.Click += (sender, args) => Invoke(CreateEventsList);
        }

        public void ShowError(string message) => ErrorMessageLabel.Text = message;

        public void HideError() => ErrorMessageLabel.Text = string.Empty;

        private static void Invoke(Action action) => action?.Invoke();

        public new void Show()
        {
            base.Show();
            if (_firstLaunch++ == 0)
                Application.Run(this);
        }

        /*
        private void CreateEventsListButton_Click(object sender, EventArgs e)
        {
            CreateEventsListForm form = new CreateEventsListForm();
            form.Show();
        }
        */
    }
}
