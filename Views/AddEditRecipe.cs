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
    public partial class AddEditRecipe : Form
    {
        private BindingList<IngredientByRecipeViewModel> IngredientsInRecipeView = new BindingList<IngredientByRecipeViewModel>();
        private bool exit = true;
        public AddEditRecipe()
        {
            InitializeComponent();
            listOfIngredientsDataGridView.DataSource = Globals.AllIngredients;
            recipeIngredientsDataGridView.DataSource = IngredientsInRecipeView;
            categoryComboBox.Items.AddRange(new object[]
            {
                "Dressings & Sauces",
                "Appetizers",
                "Salads & Sandwiches",
                "Soups & Stews",
                "Vegetables",
                "Rice, Grains, & Beans",
                "Pasta",
                "Eggs & Breakfast",
                "Meat",
                "Slow Cooker/Pressure Cooker",
                "Bread & Pizza",
                "Quick Breads & Muffins",
                "Cookies",
                "Brownies & Bars",
                "Cake",
                "Pie",
                "Fruit Desserts",
                "Drinks",
                "Preserving",
                "Freezer Meals",
                "Food Storage",
                "Kids in the Kitchen"
            });
        }

        public void AddIngredientToRecipe(IngredientByRecipeViewModel ingredient)
        {
            IngredientsInRecipeView.Add(ingredient);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            exit = false;
            Navigation.NavigateBack(this);
        }

        private void addToRecipeButton_Click(object sender, EventArgs e)
        {
            IngredientViewModel selectedIngredient = (IngredientViewModel)listOfIngredientsDataGridView.SelectedRows[0].DataBoundItem;
            Navigation.NavigateTo(new AddIngedient(selectedIngredient.GetIngredient()), this);
        }

        private void removeIngredientButton_Click(object sender, EventArgs e)
        {
            var selectedRows = recipeIngredientsDataGridView.SelectedRows.Cast<DataGridViewRow>().ToList();
            List<IngredientByRecipeViewModel> selectedIngredientsByRecipeView = selectedRows.Select(row => (IngredientByRecipeViewModel)row.DataBoundItem).ToList();
            selectedIngredientsByRecipeView.ForEach(selected => IngredientsInRecipeView.Remove(selected));
        }

        private void createIngredientButton_Click(object sender, EventArgs e)
        {
            Navigation.NavigateTo(new CreateIngredient(), this);
        }

        private void AddEditRecipe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit)
            {
                Application.Exit();
            }
        }

        private void listOfIngredientsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Globals.FormatDisplayedData(listOfIngredientsDataGridView);
            listOfIngredientsDataGridView.MultiSelect = false;
        }

        private void recipeIngredientsDataGridView_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            Globals.FormatDisplayedData(recipeIngredientsDataGridView);
        }

        private void personalTypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            Point location = typeATextBox.Location;
            secretCheckBox.Location = location;
            secretCheckBox.Visible = true;
            typeALabel.Visible = false;
            typeATextBox.Visible = false;
            typeBLabel.Visible = false;
            typeBTextBox.Visible = false;
        }

        private void webTypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            typeALabel.Text = "URL";
            typeALabel.Visible = true;
            typeATextBox.Visible = true;
            typeBLabel.Visible = false;
            typeBTextBox.Visible = false;
            secretCheckBox.Visible = false;
        }

        private void bookTypeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            typeALabel.Text = "Book";
            typeALabel.Visible = true;
            typeATextBox.Visible = true;
            typeBLabel.Visible = true;
            typeBTextBox.Visible = true;
            secretCheckBox.Visible = false;
        }
    }
}
