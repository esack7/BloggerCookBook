﻿using BloggerCookBook.Controllers;
using BloggerCookBook.Exemptions;
using BloggerCookBook.Models;
using BloggerCookBook.ViewModels;
using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace BloggerCookBook.Views
{
    public partial class AddEditRecipe : Form
    {
        private BindingList<IngredientByRecipeViewModel> IngredientsInRecipeView = new BindingList<IngredientByRecipeViewModel>();
        private Recipe _recipe;
        private RecipeViewModel _recipeView;
        private bool exit = true;
        private string[] categoryList = new string[]
        {
            "Dressings & Sauces", "Appetizers", "Salads & Sandwiches", "Soups & Stews", "Vegetables", "Rice, Grains, & Beans",
            "Pasta", "Eggs & Breakfast", "Meat", "Slow Cooker/Pressure Cooker", "Bread & Pizza", "Quick Breads & Muffins", "Cookies",
            "Brownies & Bars", "Cake", "Pie", "Fruit Desserts", "Drinks", "Preserving", "Freezer Meals", "Food Storage", "Kids in the Kitchen"
        };
        public AddEditRecipe()
        {
            InitializeComponent();
            listOfIngredientsDataGridView.DataSource = Globals.AllIngredients;
            recipeIngredientsDataGridView.DataSource = IngredientsInRecipeView;
            categoryComboBox.Items.AddRange(categoryList);
        }

        public AddEditRecipe(RecipeViewModel recipeView)
        {
            InitializeComponent();
            _recipeView = recipeView;
            _recipe = recipeView.GetRecipe();
            listOfIngredientsDataGridView.DataSource = Globals.AllIngredients;
            recipeIngredientsDataGridView.DataSource = IngredientsInRecipeView;
            Globals.GetIngredientsInRecipe(_recipe.Id).ForEach(ibr => IngredientsInRecipeView.Add(new IngredientByRecipeViewModel(ibr)));
            categoryComboBox.Items.AddRange(categoryList);
            titleTextBox.Text = _recipe.Title;
            categoryComboBox.SelectedItem = _recipe.Category;
            instructionsTextBox.Text = _recipe.Instructions;
            if (_recipe.GetType() == typeof(PersonalRecipe))
            {
                var personalRecipe = (PersonalRecipe)_recipe;
                personalTypeRadioButton.Checked = true;
                secretCheckBox.Checked = personalRecipe.Secret;
            }
            if (_recipe.GetType() == typeof(WebRecipe))
            {
                var webRecipe = (WebRecipe)_recipe;
                webTypeRadioButton.Checked = true;
                typeATextBox.Text = webRecipe.Url;
            }
            if (_recipe.GetType() == typeof(BookRecipe))
            {
                var bookRecipe = (BookRecipe)_recipe;
                bookTypeRadioButton.Checked = true;
                typeATextBox.Text = bookRecipe.BookTitle;
                typeBTextBox.Text = bookRecipe.BookAuthor;
            }
        }

        public void AddIngredientToRecipe(IngredientByRecipeViewModel ingredient)
        {
            IngredientsInRecipeView.Add(ingredient);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (titleTextBox.Text == "")
                {
                    throw new InputExemption("You must supply a title.");
                }
                if (categoryComboBox.SelectedItem == null)
                {
                    throw new InputExemption("You must select a category.");
                }
                if (IngredientsInRecipeView.Count < 1)
                {
                    throw new InputExemption("You must add at least one ingredient to a recipe.");
                }
                if (!personalTypeRadioButton.Checked && !webTypeRadioButton.Checked && !bookTypeRadioButton.Checked)
                {
                    throw new InputExemption("You must select a recipe type.");
                }
                if (webTypeRadioButton.Checked && typeATextBox.Text == "")
                {
                    throw new InputExemption("A web recipe requires a URL.");
                }
                if (bookTypeRadioButton.Checked && typeATextBox.Text == "")
                {
                    throw new InputExemption("A book recipe requires a book title.");
                }
                if (bookTypeRadioButton.Checked && typeBTextBox.Text == "")
                {
                    throw new InputExemption("A book recipe requires an author.");
                }
                if (instructionsTextBox.Text == "")
                {
                    throw new InputExemption("A recipe requires instructions.");
                }
                exit = false;
                bool editing = true;
                if (_recipe is null)
                {
                    editing = false;
                }
                var ingredientsByRecipeList = IngredientsInRecipeView.Select(iir => iir.GetIngredientByRecipe()).ToList();
                if (personalTypeRadioButton.Checked)
                {
                    if (editing)
                    {
                        var _precipe = (PersonalRecipe)_recipe;
                        _precipe.Title = titleTextBox.Text;
                        _precipe.Category = categoryComboBox.SelectedItem.ToString();
                        _precipe.Instructions = instructionsTextBox.Text;
                        _precipe.ModifiedBy = Globals.currentUser.Username;
                        _precipe.ModifiedDate = DateTime.Now;
                        _precipe.Secret = secretCheckBox.Checked;
                        _recipe = _precipe;
                    }
                    else
                    {
                        _recipe = new PersonalRecipe
                        {
                            UserId = Globals.currentUser.Id,
                            Title = titleTextBox.Text,
                            Category = categoryComboBox.SelectedItem.ToString(),
                            Instructions = instructionsTextBox.Text,
                            CreatedBy = Globals.currentUser.Username,
                            CreatedDate = DateTime.Now,
                            Secret = secretCheckBox.Checked
                        };
                    }
                }
                else if (webTypeRadioButton.Checked)
                {
                    if (editing)
                    {
                        var _wrecipe = (WebRecipe)_recipe;
                        _wrecipe.Title = titleTextBox.Text;
                        _wrecipe.Category = categoryComboBox.SelectedItem.ToString();
                        _wrecipe.Instructions = instructionsTextBox.Text;
                        _wrecipe.ModifiedBy = Globals.currentUser.Username;
                        _wrecipe.ModifiedDate = DateTime.Now;
                        _wrecipe.Url = typeATextBox.Text;
                        _recipe = _wrecipe;
                    }
                    else
                    {
                        _recipe = new WebRecipe
                        {
                            UserId = Globals.currentUser.Id,
                            Title = titleTextBox.Text,
                            Category = categoryComboBox.SelectedItem.ToString(),
                            Instructions = instructionsTextBox.Text,
                            CreatedBy = Globals.currentUser.Username,
                            CreatedDate = DateTime.Now,
                            Url = typeATextBox.Text
                        };
                    }
                }
                else
                {
                    if (editing)
                    {
                        var _brecipe = (BookRecipe)_recipe;
                        _brecipe.Title = titleTextBox.Text;
                        _brecipe.Category = categoryComboBox.SelectedItem.ToString();
                        _brecipe.Instructions = instructionsTextBox.Text;
                        _brecipe.ModifiedBy = Globals.currentUser.Username;
                        _brecipe.ModifiedDate = DateTime.Now;
                        _brecipe.BookTitle = typeATextBox.Text;
                        _brecipe.BookAuthor = typeBTextBox.Text;
                        _recipe = _brecipe;
                    }
                    else
                    {
                        _recipe = new BookRecipe
                        {
                            UserId = Globals.currentUser.Id,
                            Title = titleTextBox.Text,
                            Category = categoryComboBox.SelectedItem.ToString(),
                            Instructions = instructionsTextBox.Text,
                            CreatedBy = Globals.currentUser.Username,
                            CreatedDate = DateTime.Now,
                            BookTitle = typeATextBox.Text,
                            BookAuthor = typeBTextBox.Text
                        };
                    }
                }
                if (editing)
                {
                    Globals.UpdateRecipe(ingredientsByRecipeList, _recipe, _recipeView);
                    var recipesForm = (Recipes)Navigation.PeekCurrentForm();
                    recipesForm.resetForm();
                    Navigation.NavigateBack(this);
                }
                else
                {
                    Globals.CreateNewRecipe(ingredientsByRecipeList, _recipe);
                    var recipesForm = (Recipes)Navigation.PeekCurrentForm();
                    recipesForm.resetForm();
                    Navigation.NavigateBack(this);
                }
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

        private void addToRecipeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (listOfIngredientsDataGridView.SelectedRows.Count < 1)
                {
                    throw new SelectionExemption("You must select an ingredient to add to the recipe.");
                }
                IngredientViewModel selectedIngredient = (IngredientViewModel)listOfIngredientsDataGridView.SelectedRows[0].DataBoundItem;
                Navigation.NavigateTo(new AddIngedient(selectedIngredient.GetIngredient()), this);
            }
            catch (SelectionExemption error)
            {
                MessageBox.Show(error.Message, "Instructions", MessageBoxButtons.OK);
            }
        }

        private void removeIngredientButton_Click(object sender, EventArgs e)
        {
            recipeIngredientsDataGridView.SelectedRows.Cast<DataGridViewRow>().ToList()
                .Select(row => (IngredientByRecipeViewModel)row.DataBoundItem).ToList()
                .ForEach(selected => IngredientsInRecipeView.Remove(selected));
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
