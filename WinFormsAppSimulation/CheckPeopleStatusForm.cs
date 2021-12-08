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
    public partial class CheckPeopleStatusForm : Form, ICheckPeopleStatusView
    {
        public event Action CloseProgram;

        public CheckPeopleStatusForm()
        {
            InitializeComponent();
            CloseButton.Click += (sender, args) => Invoke(CloseProgram);
        }
        private void Invoke(Action action)
        {
            if (action != null) action();
        }


        /*
        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        */
    }
}
