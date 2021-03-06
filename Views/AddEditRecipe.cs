using BloggerCookBook.Controllers;
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
        private bool exit = true;
        public AddEditRecipe()
        {
            InitializeComponent();
            listOfIngredientsDataGridView.DataSource = Globals.AllIngredients;
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

        private void cancelButton_Click(object sender, EventArgs e)
        {
            exit = false;
            Navigation.NavigateBack(this);
        }

        private void addToRecipeButton_Click(object sender, EventArgs e)
        {
            Navigation.NavigateTo(new AddIngedient(), this);
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
            listOfIngredientsDataGridView.Columns["Id"].Visible = false;
            listOfIngredientsDataGridView.Columns["CreatedBy"].Visible = false;
            listOfIngredientsDataGridView.Columns["CreatedDate"].Visible = false;
            listOfIngredientsDataGridView.Columns["ModifiedBy"].Visible = false;
            listOfIngredientsDataGridView.Columns["ModifiedDate"].Visible = false;
            Globals.FormatDisplayedData(listOfIngredientsDataGridView);
        }
    }
}
