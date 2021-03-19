using BloggerCookBook.Controllers;
using BloggerCookBook.Models;
using BloggerCookBook.Views;
using System;
using System.Windows.Forms;

namespace BloggerCookBook
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitializeData();
            Application.Run(new AppStart());
        }

        private static void InitializeData()
        {
            var db = new SQLiteDataService();
            bool addData = db.Initialize();

            if (addData)
            {
                var user = new User { Username = "test", Password = "test", CreatedBy = "tester", CreatedDate = DateTime.Now };
                db.AddUser(user);

                var flour = new Ingredient { Title = "Flour", MeasureType = "Volume", CreatedBy = "test", CreatedDate = DateTime.Now };
                var bakingPowder = new Ingredient { Title = "Baking Powder", MeasureType = "Volume", CreatedBy = "test", CreatedDate = DateTime.Now };
                var salt = new Ingredient { Title = "Salt", MeasureType = "Volume", CreatedBy = "test", CreatedDate = DateTime.Now };
                var butter = new Ingredient { Title = "Butter", MeasureType = "Volume", CreatedBy = "test", CreatedDate = DateTime.Now };
                var milk = new Ingredient { Title = "Milk", MeasureType = "Volume", CreatedBy = "test", CreatedDate = DateTime.Now };
                db.AddIngredient(flour);
                db.AddIngredient(bakingPowder);
                db.AddIngredient(salt);
                db.AddIngredient(butter);
                db.AddIngredient(milk);

                var recipe = new WebRecipe {
                    Url = "https://www.food.com/recipe/biscuit-crust-17853",
                    Title = "Biscuit Crust",
                    Category = "Bread & Pizza",
                    Instructions = "In a medium bowl whisk together flour, salt and baking powder.\r\nCut in the butter to resemble coarse cornmeal.\r\nAdd the milk and quickly stir to gather dough into a ball.\r\nGently, on a lightly floured board roll out to fit the pie plate or top of a deep dish pie.\r\n* *Ifyou need this partially baked roll the biscuit dough 1 / 4 inch thick, place lined pie plate / dish in a 350 degree oven for 10 minutes, fill and continue recipe for pie.",
                    CreatedBy = "test",
                    CreatedDate = DateTime.Now,
                    UserId = user.Id
                };
                db.AddRecipe(recipe);

                var ingredientByRecipe1 = new IngredientByRecipe { IngredientId = flour.Id, MeasureAmount = Convert.ToDecimal(1), MeasureUnit = "cup", RecipeId = recipe.Id, CreatedDate = DateTime.Now, CreatedBy = "test" };
                var ingredientByRecipe2 = new IngredientByRecipe { IngredientId = bakingPowder.Id, MeasureAmount = Convert.ToDecimal(2), MeasureUnit = "tsp", RecipeId = recipe.Id, CreatedDate = DateTime.Now, CreatedBy = "test" };
                var ingredientByRecipe3 = new IngredientByRecipe { IngredientId = salt.Id, MeasureAmount = Convert.ToDecimal(0.5), MeasureUnit = "tsp", RecipeId = recipe.Id, CreatedDate = DateTime.Now, CreatedBy = "test" };
                var ingredientByRecipe4 = new IngredientByRecipe { IngredientId = butter.Id, MeasureAmount = Convert.ToDecimal(0.25), MeasureUnit = "cup", RecipeId = recipe.Id, CreatedDate = DateTime.Now, CreatedBy = "test" };
                var ingredientByRecipe5 = new IngredientByRecipe { IngredientId = milk.Id, MeasureAmount = Convert.ToDecimal(0.25), MeasureUnit = "cup", RecipeId = recipe.Id, CreatedDate = DateTime.Now, CreatedBy = "test" };
                db.AddIngredientByRecipe(ingredientByRecipe1);
                db.AddIngredientByRecipe(ingredientByRecipe2);
                db.AddIngredientByRecipe(ingredientByRecipe3);
                db.AddIngredientByRecipe(ingredientByRecipe4);
                db.AddIngredientByRecipe(ingredientByRecipe5);

                var meal1 = new Meal { Title = "Sample Meal1", Type = "Special Occasion", Notes = "Sample Notes", Date = DateTime.Now, UserId = user.Id, CreatedBy = "test", CreatedDate = DateTime.Now };
                var meal2 = new Meal { Title = "Sample Meal2", Type = "Lunch", Notes = "Sample Notes", Date = DateTime.Now.AddDays(1), UserId = user.Id, CreatedBy = "test", CreatedDate = DateTime.Now };
                db.AddMeal(meal1);
                db.AddMeal(meal2);

                var recipeByMeal1 = new RecipeByMeal { MealId = meal1.Id, RecipeId = recipe.Id, CreatedDate = DateTime.Now, CreatedBy = "test" };
                var recipeByMeal2 = new RecipeByMeal { MealId = meal2.Id, RecipeId = recipe.Id, CreatedDate = DateTime.Now, CreatedBy = "test" };
                db.AddRecipeByMeal(recipeByMeal1);
                db.AddRecipeByMeal(recipeByMeal2);
            }
            db.Close();
        }
    }
}
