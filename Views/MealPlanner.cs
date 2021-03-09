using BloggerCookBook.Controllers;
using BloggerCookBook.ViewModels;
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
    public partial class MealPlanner : Form
    {
        private bool exit = true;
        public MealPlanner()
        {
            InitializeComponent();
            mealsDataGridView.DataSource = Globals.AllUsersMeals;
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            exit = false;
            Navigation.NavigateBack(this);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Navigation.NavigateTo(new AddEditMeal(), this);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var selectedMeal = (MealViewModel)mealsDataGridView.SelectedRows[0].DataBoundItem;
            Globals.DeleteMeal(selectedMeal);
        }

        private void MealPlanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit)
            {
                Application.Exit();
            }
        }

        private void mealsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Globals.FormatDisplayedData(mealsDataGridView);
            mealsDataGridView.MultiSelect = false;
        }
    }
}
