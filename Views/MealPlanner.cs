using BloggerCookBook.Controllers;
using BloggerCookBook.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloggerCookBook.Views
{
    public partial class MealPlanner : Form
    {
        private bool exit = true;
        private DateTime SelectedDate;
        private BindingList<MealViewModel> MealsList = new BindingList<MealViewModel>();
        public MealPlanner()
        {
            InitializeComponent();
            SelectedDate = DateTime.Now;
            mealsDataGridView.DataSource = MealsList;
            Globals.AllUsersMeals.ToList().ForEach(meal => MealsList.Add(meal));
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

        private void editButton_Click(object sender, EventArgs e)
        {
            var selectedMealView = (MealViewModel)mealsDataGridView.SelectedRows[0].DataBoundItem;
            Navigation.NavigateTo(new AddEditMeal(selectedMealView), this);
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

        private void updateMealsList(DateTime start, DateTime end)
        {
            MealsList.Clear();
            Globals.AllUsersMeals
                .Where(mealView => mealView.GetMeal().Date >= start && mealView.GetMeal().Date <= end).ToList()
                .ForEach(mealView => MealsList.Add(mealView));
        }

        private void dayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var range = new DateFormatter(SelectedDate);
            updateMealsList(range.DayBeginning(), range.DayEnding());

        }

        private void weekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var range = new DateFormatter(SelectedDate);
            updateMealsList(range.WeekBeginning(), range.WeekEnding());
        }

        private void monthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var range = new DateFormatter(SelectedDate);
            updateMealsList(range.MonthBeginning(), range.MonthEnding());
        }

        private void mealPlannerCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {

        }
    }
}
