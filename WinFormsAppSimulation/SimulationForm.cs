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
    public partial class SimulationForm : Form, ISimulationView
    {
         //private StartForm startForm;
        public event Action SimulationClosed;
        public event Action CreatePeople;
        public event Action CheckPeopleStatus;
        public event Action Stop;
        public event Action PlayPause;
        public event Action SpeedUp;
        public event Action SlowDown;
        public event Action Fire;
        public SimulationForm()
        {
            InitializeComponent();
             //this.startForm = startForm;
            FormClosed += (sender, args) => Invoke(SimulationClosed);
            CreatePeopleToolStripMenuItem.Click += (sender, args) => Invoke(CreatePeople);
            CheckPeopleStatusToolStripMenuItem.Click += (sender, args) => Invoke(CheckPeopleStatus);
            StopButton.Click += (sender, args) => Invoke(Stop);
            PlayPauseButton.Click += (sender, args) => Invoke(PlayPause);
            SpeedUpButton.Click += (sender, args) => Invoke(SpeedUp);
            SlowDownButton.Click += (sender, args) => Invoke(SlowDown);
            FireButton.Click += (sender, args) => Invoke(Fire);
        }
        private void Invoke(Action action)
        {
            if (action != null) action();
        }

        public new void Show()
        {
            base.ShowDialog();
        }

        public void UpdateElevatorsGrid( bool[,] elevatorsGrid )
        {
            ElevatorsGrid.RowCount = elevatorsGrid.GetLength(0); 
            ElevatorsGrid.ColumnCount = elevatorsGrid.GetLength(1);

            for(int i =0; i< ElevatorsGrid.RowCount; i++)
            {
                for(int j=0; j< ElevatorsGrid.ColumnCount; j++)
                {
                    if (elevatorsGrid[i, j]) ElevatorsGrid.Rows[i].Cells[j].Style.BackColor = Color.Red ;
                    else ElevatorsGrid.Rows[i].Cells[j].Style.BackColor = Color.White;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        /* private void SimulationForm_FormClosed(object sender, FormClosedEventArgs e)
{
startForm.Show();
}

private void CreatePeopleToolStripMenuItem_Click(object sender, EventArgs e)
{
CreatePeopleForm createPeopleForm = new CreatePeopleForm();
createPeopleForm.Show();
}

private void CheckPeopleStatusToolStripMenuItem_Click(object sender, EventArgs e)
{
CheckPeopleStatusForm checkPeopleStatusForm = new CheckPeopleStatusForm();
checkPeopleStatusForm.Show();
}

private void StopButton_Click(object sender, EventArgs e)
{
this.Hide();
StatisticsForm statisticsForm = new StatisticsForm(this);
statisticsForm.ShowDialog();
}

private void PlayPauseButton_Click(object sender, EventArgs e)
{

}

private void SpeedUpButton_Click(object sender, EventArgs e)
{

}

private void SlowDownButton_Click(object sender, EventArgs e)
{

}

private void FireButton_Click(object sender, EventArgs e)
{

}*/
    }
}
