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

        public StatisticsForm()
        {
            InitializeComponent();
            ExitButton.Click += (sender, args) => Invoke(Exit);
            FormClosed += (sender, args) => Invoke(StatisticClosing);
        }

        public void ShowStatistics( string statistics )
        {
            StatisticsLabel.Text = statistics;
        }
        private static void Invoke(Action action) => action?.Invoke();

        public new void Show() => base.ShowDialog();
    }
}
