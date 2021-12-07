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
    public partial class StartConfigurationForm : Form, IStartConfigurationView
    {
        public event Action Ok;
        public event Action StartConfiguration;
        public StartConfigurationForm()
        {
            InitializeComponent();

            OkButton.Click += (sender, args) => Invoke(Ok);
            SetConfigurationButton.Click += (sender, args) => Invoke(StartConfiguration);
        }
        private void Invoke(Action action)
        {
            if (action != null) action();
        }

        public new void Show()
        {
            base.ShowDialog();
        }

        /* private void OkButton_Click(object sender, EventArgs e)
         {
             this.Close();
         }

         private void SetConfigurationButton_Click(object sender, EventArgs e)
         {
             SetConfigurationForm setConfigurationForm = new SetConfigurationForm();
             setConfigurationForm.ShowDialog();
         }*/
    }
}
