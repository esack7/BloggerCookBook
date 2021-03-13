using BloggerCookBook.Controllers;
using BloggerCookBook.Exemptions;
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
        private MealViewModel _mealView;

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
            _mealView = mealView;
            var meal = mealView.GetMeal();
            Globals.GetMealRecipes(meal.Id).ForEach(recipeView => mealRecipes.Add(recipeView));
            titleTextBox.Text = meal.Title;
            typeComboBox.SelectedItem = meal.Type;
            dateTimePicker.Value = meal.Date;
            notesTextBox.Text = meal.Notes;
        }

        private void addToMealButton_Click(object sender, EventArgs e)
        {
            try
            {
                if(listOfRecipesDataGridView.SelectedRows.Count < 1)
                {
                    throw new SelectionExemption("You must select a recipe to add.");
                }
                var selectedRecipe = (RecipeViewModel)listOfRecipesDataGridView.SelectedRows[0].DataBoundItem;
                if (!mealRecipes.Contains(selectedRecipe))
                {
                    mealRecipes.Add(selectedRecipe);
                }
            }
            catch (SelectionExemption error)
            {
                MessageBox.Show(error.Message, "Instructions", MessageBoxButtons.OK);
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
            try
            {
                if (typeComboBox.SelectedItem == null)
                {
                    throw new InputExemption("You must select a meal type.");
                }
                if(mealRecipes.Count < 1)
                {
                    throw new InputExemption("You must add at least one recipe to a meal.");
                }
                exit = false;
                if (_mealView is null)
                {
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
                }
                else
                {
                    var updatedMeal = _mealView.GetMeal();
                    updatedMeal.Title = titleTextBox.Text;
                    updatedMeal.Type = typeComboBox.SelectedItem.ToString();
                    updatedMeal.Date = dateTimePicker.Value;
                    updatedMeal.Notes = notesTextBox.Text;
                    updatedMeal.ModifiedDate = DateTime.Now;
                    updatedMeal.ModifiedBy = Globals.currentUser.Username;
                    Globals.UpdateMeal(mealRecipes.ToList(), updatedMeal, _mealView);
                }
                var mealPlannerForm = (MealPlanner)Navigation.PeekCurrentForm();
                mealPlannerForm.refreshForm();
                Navigation.NavigateBack(this);
            }
            catch (InputExemption error)
            {
                MessageBox.Show(error.Message, "Instructions", MessageBoxButtons.OK);
            }
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
