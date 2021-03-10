using BloggerCookBook.Controllers;
using BloggerCookBook.Models;
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
    public partial class AddEditMeal : Form
    {
        private BindingList<RecipeViewModel> mealRecipes = new BindingList<RecipeViewModel>();
        private bool exit = true;
        private string[] typeList = new string[] { "Breakfast", "Brunch", "Lunch", "Dinner", "Snack", "Special Occasion" };
        private Meal _meal;
        public AddEditMeal()
        {
            InitializeComponent();
            listOfRecipesDataGridView.DataSource = Globals.AllUsersRecipes;
            mealRecipesDataGridView.DataSource = mealRecipes;
            typeComboBox.Items.AddRange(typeList);
        }

        public AddEditMeal(MealViewModel mealView)
        {
            InitializeComponent();
            listOfRecipesDataGridView.DataSource = Globals.AllUsersRecipes;
            mealRecipesDataGridView.DataSource = mealRecipes;
            typeComboBox.Items.AddRange(typeList);
            _meal = mealView.GetMeal();
            Globals.GetMealRecipes(_meal.Id).ForEach(recipeView => mealRecipes.Add(recipeView));
            titleTextBox.Text = _meal.Title;
            typeComboBox.SelectedItem = _meal.Type;
            dateTimePicker.Value = _meal.Date;
            notesTextBox.Text = _meal.Notes;
        }

        private void addToMealButton_Click(object sender, EventArgs e)
        {
            var selectedRecipe = (RecipeViewModel)listOfRecipesDataGridView.SelectedRows[0].DataBoundItem;
            if (!mealRecipes.Contains(selectedRecipe))
            {
                mealRecipes.Add(selectedRecipe);
            }
        }

        private void removeRecipeButton_Click(object sender, EventArgs e)
        {
            mealRecipesDataGridView.SelectedRows.Cast<DataGridViewRow>()
                .Select(row => (RecipeViewModel)row.DataBoundItem).ToList()
                .ForEach(selected => mealRecipes.Remove(selected));
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            exit = false;
            var meal = new Meal
            {
                UserId = Globals.currentUser.Id,
                Title = titleTextBox.Text,
                Type = typeComboBox.SelectedItem.ToString(),
                Date = dateTimePicker.Value,
                Notes = notesTextBox.Text,
                CreatedDate = DateTime.Now,
                CreatedBy = Globals.currentUser.Username
            };
            Globals.CreateNewMeal(meal, mealRecipes.ToList());
            Navigation.NavigateBack(this);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            exit = false;
            Navigation.NavigateBack(this);
        }

        private void AddEditMeal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit)
            {
                Application.Exit();
            }
        }

        private void listOfRecipesDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Globals.FormatDisplayedData(listOfRecipesDataGridView);
            listOfRecipesDataGridView.MultiSelect = false;
        }

        private void mealRecipesDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Globals.FormatDisplayedData(mealRecipesDataGridView);
        }
    }
}
