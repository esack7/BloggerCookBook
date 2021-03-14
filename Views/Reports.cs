using BloggerCookBook.Controllers;
using BloggerCookBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloggerCookBook.Views
{
    public partial class Reports : Form
    {
        private bool exit = true;
        public Reports()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            exit = false;
            Navigation.NavigateBack(this);
        }

        private void Reports_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (exit)
            {
                Application.Exit();
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            var text = new StringBuilder();
            var start = new DateFormatter(startDateTimePicker.Value);
            var end = new DateFormatter(endDateTimePicker.Value);
            var mealsInDateRange = Globals.AllUsersMeals.Select(mealView => mealView.GetMeal())
                .Where(meal => meal.Date > start.DayBeginning() && meal.Date < end.DayEnding()).ToList();

            if (shoppingListRadioButton.Checked)
            {
                text.AppendLine("Shopping List");
                text.AppendLine($"For dates {start} to {end}");
                text.AppendLine();
                
                var mealIdArray = mealsInDateRange.Select(meal => meal.Id).ToHashSet<int>().ToArray();
                Globals.GetListOfIngredientsForMeals(mealIdArray)
                    .ForEach(ingredient => text.AppendLine($"*\t{ingredient}"));
                
                reportTextBox.Text = text.ToString();
            }

            if (topTenRadioButton.Checked)
            {
                text.AppendLine($"Top Recipes for dates {start} to {end}");
                text.AppendLine("(Max 10)");
                text.AppendLine();
                text.AppendLine("Recipe Title\t\t|  Times Recipe Used");
                text.AppendLine("-----------------------------------------------------------------------------------");

                var mealIdArray = mealsInDateRange.Select(meal => meal.Id).ToArray();
                //var groupOfRecipes = Globals.GetListOfRecipesByMealIds(mealIdArray).GroupBy(recipe => recipe);

                //foreach (var group in groupOfRecipes)
                //{
                //    text.AppendLine($"{group.Key.Title}\t\t|  {group.Count()}");
                //}

                reportTextBox.Text = text.ToString();
            }
        }
    }
}
