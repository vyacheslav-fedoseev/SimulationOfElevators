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
    public partial class StrategyChoosingForm : Form, IStrategyChoosingView
    {
        public event Action Ok;
        public string Strategy => StrategyComboBox.SelectedItem.ToString();
        public StrategyChoosingForm()
        {
            InitializeComponent();
            StrategyComboBox.SelectedIndex = 0;
            ОкButton.Click += (sender, args) => Invoke(Ok);
        }

        private static void Invoke(Action action) => action?.Invoke();

        public new void Show() => base.ShowDialog();
    }
}
