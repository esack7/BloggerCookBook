using BloggerCookBook.Controllers;
using BloggerCookBook.ViewModels;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace BloggerCookBook.Views
{
    public partial class MainMenu : Form
    {
        private bool exit = true;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit)
            {
                Application.Exit();
            }
        }

        private void recipesButton_Click(object sender, EventArgs e)
        {
            Navigation.NavigateTo(new Recipes(), this);
        }

        private void mealPlannerButton_Click(object sender, EventArgs e)
        {
            Navigation.NavigateTo(new MealPlanner(), this);
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            Navigation.NavigateTo(new Reports(), this);
        }

        private void logoutButton_Click(object sender, EventArgs e)
        {
            exit = false;
            Navigation.NavigateBack(this);
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            Globals.AllIngredients = new BindingList<IngredientViewModel>(Globals.GetAllIngredientsFromDB());
            Globals.AllUsersRecipes = new BindingList<RecipeViewModel>(Globals.GetAllCurrentUserRecipesFromDB());
            Globals.AllUsersMeals = new BindingList<MealViewModel>(Globals.GetAllCurrentUserMeals());
        }
    }
}
