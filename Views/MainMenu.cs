﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloggerCookBook.Views
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void recipesButton_Click(object sender, EventArgs e)
        {

        }

        private void mealPlannerButton_Click(object sender, EventArgs e)
        {

        }

        private void reportsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
