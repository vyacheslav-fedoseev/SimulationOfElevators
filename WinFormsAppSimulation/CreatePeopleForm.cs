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
    public partial class CreatePeopleForm : Form, ICreatePeopleView
    {
        public event Action Create;

        public CreatePeopleForm()
        {
            InitializeComponent();
            CreateButton.Click += (sender, args) => Invoke(Create);
        }

        private void Invoke(Action action)
        {
            if (action != null) action();
        }
        /*
        private void CreateButton_Click(object sender, EventArgs e)
        {

        }
        */
    }
}
