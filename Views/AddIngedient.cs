using BloggerCookBook.Controllers;
using BloggerCookBook.Exemptions;
using BloggerCookBook.Models;
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
    public partial class AddIngedient : Form
    {
        private bool exit = true;
        private Ingredient selectedIngredient;
        public AddIngedient(Ingredient ingredient)
        {
            InitializeComponent();
            nameTextBox.Text = ingredient.Title;
            if(ingredient.MeasureType == "Weight")
            {
                unitComboBox.Items.AddRange(new object[]
                {
                    "lbs",
                    "oz"
                });
            } 
            else if(ingredient.MeasureType == "Volume")
            {
                unitComboBox.Items.AddRange(new object[]
                {
                    "tsp",
                    "tbsp",
                    "fl oz",
                    "cup",
                    "pint",
                    "quart",
                    "gallon"
                });
            }
            else
            {
                unitComboBox.Items.AddRange(new object[]
                {
                    "count"
                });
            }
            selectedIngredient = ingredient;
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            exit = false;
            Navigation.NavigateBack(this);
        }

        private void AddIngedient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit)
            {
                Application.Exit();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (unitComboBox.SelectedItem == null)
                {
                    throw new InputExemption("An ingredient requires a unit of measurement.");
                }
                if (amountTextBox.Text == "")
                {
                    throw new InputExemption("An ingredient requires an amount");
                }

                exit = false;
                var recipe = (AddEditRecipe)Navigation.PeekCurrentForm();
                var ingredientByRecipe = new IngredientByRecipe { IngredientId = selectedIngredient.Id, MeasureUnit = unitComboBox.SelectedItem.ToString(), MeasureAmount = Convert.ToDecimal(amountTextBox.Text), CreatedBy = Globals.currentUser.Username, CreatedDate = DateTime.Now };
                recipe.AddIngredientToRecipe(new ViewModels.IngredientByRecipeViewModel(ingredientByRecipe));
                Navigation.NavigateBack(this);
            }
            catch (InputExemption error)
            {
                MessageBox.Show(error.Message, "Instructions", MessageBoxButtons.OK);
            }
            catch (FormatException)
            {
                MessageBox.Show("The indgredient amount must be a number or decimal.", "Instructions", MessageBoxButtons.OK);
            }
        }
    }
}
