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
    public partial class CreateEventsListForm : Form, ICreateEventsListView
    {
        public event Action CreatePeople;
        public event Action CreateFireAlarm;
        public event Action OK;

        public CreateEventsListForm()
        {
            InitializeComponent();
            CreatePeopleButton.Click += (sender, args) => Invoke(CreatePeople);
            CreateFireAlarmButton.Click += (sender, args) => Invoke(CreateFireAlarm);
            Ok.Click += (sender, args) => Invoke(OK);
        }

        private static void Invoke(Action action) => action?.Invoke();

        public void ShowErrorCreatePeople(string message) => ErrorCreatePeopleMessageLabel.Text = message;

        public void ShowErrorFireAlarm(string message) => ErrorFireAlarmMessageLabel.Text = message;
        
        public void HideCreatePeopleError() => ErrorCreatePeopleMessageLabel.Text = string.Empty;

        public void HideFireAlarmError() => ErrorFireAlarmMessageLabel.Text = string.Empty;

        public string PeopleCount => PeopleCountTextBox.Text;

        public string CurrentFloor => CurrentFloorTextBox.Text;

        public string DestinationFloor => DestinationFloorTextBox.Text;

        public string CreatePeopleTime => CreatePeopleTimeTextBox.Text;

        public string TurnOnFireAlarmTime => TurnOnFireAlarmTimeTextBox.Text;

        public string DurationTimeFireAlarm => DurationTimeFireAlarmTextBox.Text;

        // public new void Show() => base.ShowDialog();

        public void AddEventInList(string eventData) => EventsListLabel.Text += eventData + "\n";
    }
}
