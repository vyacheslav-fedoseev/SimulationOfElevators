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

        private static void Invoke(Action action) => action?.Invoke();

        public void ShowError(string message) => ErrorMessageLebel.Text = message;

        public void HideError() => ErrorMessageLebel.Text = string.Empty;

        public string PeopleCount => PeopleCountTextBox.Text;

        public string CurrentFloor => CurrentFloorTextBox.Text;

        public string DestinationFloor => DestinationFloorTextBox.Text;
    }
}
