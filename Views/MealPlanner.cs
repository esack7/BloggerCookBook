﻿using BloggerCookBook.Controllers;
using BloggerCookBook.Exemptions;
using BloggerCookBook.ViewModels;
using System;
using System.ComponentModel;
using System.Data;
using System.Linq;
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
            dayRadioButton.Checked = true;
        }

        public void refreshForm()
        {
            SelectedDate = DateTime.Now;
            MealsList.Clear();
            Globals.AllUsersMeals.ToList().ForEach(meal => MealsList.Add(meal));
            dayRadioButton.Checked = true;
            updateMealsList(new DateFormatter(SelectedDate));
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
            try
            {
                if (mealsDataGridView.SelectedRows.Count < 1)
                {
                    throw new SelectionExemption("You must select a meal to edit");
                }
                var selectedMealView = (MealViewModel)mealsDataGridView.SelectedRows[0].DataBoundItem;
                Navigation.NavigateTo(new AddEditMeal(selectedMealView), this);
            }
            catch (SelectionExemption error)
            {
                MessageBox.Show(error.Message, "Instructions", MessageBoxButtons.OK);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (mealsDataGridView.SelectedRows.Count < 1)
                {
                    throw new SelectionExemption("You must select a meal to delete");
                }
                DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete the selected meal?", "Confirmation", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    var selectedMeal = (MealViewModel)mealsDataGridView.SelectedRows[0].DataBoundItem;
                    Globals.DeleteMeal(selectedMeal);
                }
            }
            catch (SelectionExemption error)
            {
                MessageBox.Show(error.Message, "Instructions", MessageBoxButtons.OK);
            }
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

        private void updateMealsList(DateFormatter dateFormatter)
        {
            DateTime start;
            DateTime end;
            if (dayRadioButton.Checked)
            {
                start = dateFormatter.DayBeginning();
                end = dateFormatter.DayEnding();
            }
            else if (weekRadioButton.Checked)
            {
                start = dateFormatter.WeekBeginning();
                end = dateFormatter.WeekEnding();
            }
            else
            {
                start = dateFormatter.MonthBeginning();
                end = dateFormatter.MonthEnding();
            }
            MealsList.Clear();
            Globals.AllUsersMeals
                .Where(mealView => mealView.GetMeal().Date >= start && mealView.GetMeal().Date <= end).ToList()
                .ForEach(mealView => MealsList.Add(mealView));
        }

        private void dayRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updateMealsList(new DateFormatter(SelectedDate));
        }

        private void weekRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updateMealsList(new DateFormatter(SelectedDate));
        }

        private void monthRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            updateMealsList(new DateFormatter(SelectedDate));
        }

        private void mealPlannerCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            SelectedDate = mealPlannerCalendar.SelectionStart;
            updateMealsList(new DateFormatter(SelectedDate));
        }
    }
}
