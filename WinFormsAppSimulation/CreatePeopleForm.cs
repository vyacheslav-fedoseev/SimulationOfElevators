﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presenters;

namespace WinFormsAppSimulation
{
    public partial class CreatePeopleForm : Form, ICreatePeopleView
    {

        public CreatePeopleForm()
        {
            InitializeComponent();
        }

        private void Invoke(Action action)
        {
            if (action != null) action();
        }
    }
}
