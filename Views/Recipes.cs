﻿using BloggerCookBook.Controllers;
using System;
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
    public partial class Recipes : Form
    {
        public Recipes()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addEditRecipe = new AddEditRecipe();
            Navigation.NavigateTo(addEditRecipe, this);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var addEditRecipe = new AddEditRecipe();
            Navigation.NavigateTo(addEditRecipe, this);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            Navigation.NavigateBack(this);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }
    }
}