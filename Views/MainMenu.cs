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
    public partial class MainMenu : Form
    {
        private bool exit = true;
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(exit)
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
        }
    }
}
