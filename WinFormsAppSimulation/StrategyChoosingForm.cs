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
    public partial class StrategyChoosingForm : Form
    {
        public StrategyChoosingForm()
        {
            InitializeComponent();
        }

        private void ОкButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
