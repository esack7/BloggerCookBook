using BloggerCookBook.Controllers;
using BloggerCookBook.Exemptions;
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
            try
            {
                if(recipesDataGridView.SelectedRows.Count < 1)
                {
                    throw new SelectionExemption("You must select a recipe to edit.");
                }
                if (recipesDataGridView.SelectedRows.Count > 1)
                {
                    throw new SelectionExemption("You can only edit one recipe at a time.");
                }
                var selectedRecipeView = (RecipeViewModel)recipesDataGridView.SelectedRows[0].DataBoundItem;
                Navigation.NavigateTo(new AddEditRecipe(selectedRecipeView), this);
                resetForm();
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
                if (recipesDataGridView.SelectedRows.Count < 1)
                {
                    throw new SelectionExemption("You must select at least one recipe to delete");
                }
                DialogResult confirmDelete = MessageBox.Show("Are you sure you want to delete the selected recipes/s?", "Confirmation", MessageBoxButtons.YesNo);
                if (confirmDelete == DialogResult.Yes)
                {
                    var selectedRecipes = recipesDataGridView.SelectedRows.Cast<DataGridViewRow>().Select(row => (RecipeViewModel)row.DataBoundItem).ToList();
                    Globals.DeleteRecipes(selectedRecipes);
                    resetForm();
                }
            }
            catch (SelectionExemption error)
            {
                MessageBox.Show(error.Message, "Instructions", MessageBoxButtons.OK);
            }
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

        public void resetForm()
        {
            recipesList.Clear();
            Globals.AllUsersRecipes.ToList().ForEach(recipeView =>
            {
                recipesList.Add(recipeView);
                categories.Add(recipeView.GetRecipe().Category);
            });
            searchTextBox.Text = "";
            categoryComboBox.SelectedItem = "";
            categoryComboBox.Items.Clear();
            categoryComboBox.Items.AddRange(categories.ToArray());
        }
    }
}
