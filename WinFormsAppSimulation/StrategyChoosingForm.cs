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
        public StrategyChoosingForm()
        {
            InitializeComponent();
            ОкButton.Click += (sender, args) => Invoke(Ok);
        }

        private void Invoke(Action action)
        {
            if (action != null) action();
        }

        public new void Show()
        {
            base.ShowDialog();
        }

        /*private void ОкButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/
    }
}
