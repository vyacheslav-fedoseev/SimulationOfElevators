﻿using System;
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
        public event Action SimulationClosed;
        public event Action CreatePeople;
        public event Action CheckPeopleStatus;
        public event Action Stop;
        public event Action PlayPause;
        public event Action SpeedUp;
        public event Action SlowDown;
        public event Action Fire;
        public string PeopleCount => PeopleCountTextBox.Text;
        public string CurrentFloor => CurrentFloorTextBox.Text;
        public string DestinationFloor => DestinationFloorTextBox.Text;
        public SimulationForm()
        {
            InitializeComponent();
            FormClosed += (sender, args) => Invoke(SimulationClosed);
            //CreatePeopleToolStripMenuItem.Click += (sender, args) => Invoke(CreatePeople);
            //CheckPeopleStatusToolStripMenuItem.Click += (sender, args) => Invoke(CheckPeopleStatus);
            CreateButton.Click += (sender, args) => Invoke(CreatePeople);
            StopButton.Click += (sender, args) => Invoke(Stop);
            PlayPauseButton.Click += (sender, args) => Invoke(PlayPause);
            SpeedUpButton.Click += (sender, args) => Invoke(SpeedUp);
            SlowDownButton.Click += (sender, args) => Invoke(SlowDown);
            FireButton.Click += (sender, args) => Invoke(Fire);
        }

        private static void Invoke(Action action) => action?.Invoke();

        public void ShowError(string message) => ErrorMessageLebel.Text = message;

        public void HideError() => ErrorMessageLebel.Text = string.Empty;
        public new void Show() => base.ShowDialog();

        public void UpdateElevatorsGrid(bool[,] elevatorsGrid)
        {
            ElevatorsGrid.RowCount = elevatorsGrid.GetLength(0);
            ElevatorsGrid.ColumnCount = elevatorsGrid.GetLength(1);

            for (var i = 0; i < ElevatorsGrid.RowCount; i++)
                for (var j = 0; j < ElevatorsGrid.ColumnCount; j++)
                    ElevatorsGrid.Rows[ElevatorsGrid.RowCount-i-1].Cells[ElevatorsGrid.ColumnCount-j-1].Style.BackColor = elevatorsGrid[i, j] ? Color.Red : Color.White;
        }

        public void UpdatePeopleStatusLabel(string peopleStatus)
        {
            PeopleStatusLabel.Text = peopleStatus;
        }

        public void UpdateView(bool[,] elevatorsGrid, string peopleStatus)
        {
            UpdateElevatorsGrid(elevatorsGrid);
            UpdatePeopleStatusLabel(peopleStatus);
        }
        private void Timer1_Tick(object sender, EventArgs e)
        {

        }

        private void ElevatorsGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {








        }
    }
}
