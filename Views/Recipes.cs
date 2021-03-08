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
        public Recipes()
        {
            InitializeComponent();
            recipesDataGridView.DataSource = Globals.AllUsersRecipes;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Navigation.NavigateTo(new AddEditRecipe(), this);
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            var selectedRecipeView = (RecipeViewModel)recipesDataGridView.SelectedRows[0].DataBoundItem;
            Navigation.NavigateTo(new AddEditRecipe(selectedRecipeView), this);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            var selectedRecipes = recipesDataGridView.SelectedRows.Cast<DataGridViewRow>().Select(row => (RecipeViewModel)row.DataBoundItem).ToList();
            Globals.DeleteRecipes(selectedRecipes);
        }

        private void mainMenuButton_Click(object sender, EventArgs e)
        {
            exit = false;
            Navigation.NavigateBack(this);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

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
    }
}
