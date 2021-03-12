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
    public partial class Recipes : Form
    {
        private bool exit = true;
        private BindingList<RecipeViewModel> recipesList = new BindingList<RecipeViewModel>();
        private HashSet<string> categories = new HashSet<string>() { "" };
        public Recipes()
        {
            InitializeComponent();
            recipesDataGridView.DataSource = recipesList;
            Globals.AllUsersRecipes.ToList().ForEach(recipeView => 
            {
                recipesList.Add(recipeView);
                categories.Add(recipeView.GetRecipe().Category);
            });
            categoryComboBox.Items.AddRange(categories.ToArray());
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Navigation.NavigateTo(new AddEditRecipe(), this);
            resetForm();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var selectedRecipeView = (RecipeViewModel)recipesDataGridView.SelectedRows[0].DataBoundItem;
            Navigation.NavigateTo(new AddEditRecipe(selectedRecipeView), this);
            resetForm();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var selectedRecipes = recipesDataGridView.SelectedRows.Cast<DataGridViewRow>().Select(row => (RecipeViewModel)row.DataBoundItem).ToList();
            Globals.DeleteRecipes(selectedRecipes);
            resetForm();
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            exit = false;
            Navigation.NavigateBack(this);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var searchTerm = searchTextBox.Text.ToUpper().Trim();
            categoryComboBox.SelectedItem = "";
            if (searchTerm == "")
            {
                recipesList.Clear();
                Globals.AllUsersRecipes.ToList().ForEach(recipeView => recipesList.Add(recipeView));
            }
            else
            {
                var updatedRecipesList = Globals.AllUsersRecipes.Where(recipeView => recipeView.GetRecipe().Title.ToUpper().Contains(searchTerm)).ToList();
                recipesList.Clear();
                updatedRecipesList.ForEach(recipeView => recipesList.Add(recipeView));
            }
        }

        private void Recipes_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(exit)
            {
                Application.Exit();
            }
        }

        private void recipesDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Globals.FormatDisplayedData(recipesDataGridView);
        }

        private void categoryComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            recipesList.Clear();
            searchTextBox.Text = "";
            var selectedValue = (string)categoryComboBox.SelectedItem;
            if(selectedValue == "")
            {
                Globals.AllUsersRecipes.ToList().ForEach(recipeView => recipesList.Add(recipeView));
            } 
            else
            {
                var updatedRecipesList = Globals.AllUsersRecipes.Where(recipeView => recipeView.GetRecipe().Category == selectedValue).ToList();
                updatedRecipesList.ForEach(recipeView => recipesList.Add(recipeView));
            }
        }

        private void resetForm()
        {
            recipesList.Clear();
            Globals.AllUsersRecipes.ToList().ForEach(recipeView => recipesList.Add(recipeView));
            searchTextBox.Text = "";
            categoryComboBox.SelectedItem = "";
        }
    }
}
