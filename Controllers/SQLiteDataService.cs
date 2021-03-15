using BloggerCookBook.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BloggerCookBook.Controllers
{
    public class SQLiteDataService : ILocalDataService
    {
        private SQLiteConnection database;
        public bool Initialize()
        {
            bool dbTablesCreated = false;
            if (database == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BloggerCookbookDb.db3");
                database = new SQLiteConnection(dbPath);
            }

            var results = database.CreateTables<User, PersonalRecipe, WebRecipe, BookRecipe, Ingredient>()
                .Results.Select(result => result.Value).ToList();

            results.Add(database.CreateTable<IngredientByRecipe>());
            results.Add(database.CreateTable<RecipeByMeal>());
            results.Add(database.CreateTable<Meal>());

            foreach (var result in results)
            {
                dbTablesCreated = dbTablesCreated || result == CreateTableResult.Created;
            }

            return dbTablesCreated;
        }

        public void Close()
        {
            database.Close();
        }

        public void AddUser(User newUser)
        {
            database.Insert(newUser);
        }

        public List<User> GetAllUsers()
        {
            return database.Table<User>().ToList();
        }

        public void AddRecipe(Recipe newRecipe)
        {
            database.Insert(newRecipe);
        }

        public List<Recipe> GetAllCurrentUserRecipes(int userId)
        {
            List<Recipe> listOfRecipes = new List<Recipe>();
            database.Query<PersonalRecipe>($"SELECT * FROM PersonalRecipe WHERE UserId={userId}").ForEach(recipe => listOfRecipes.Add(recipe));
            database.Query<WebRecipe>($"SELECT * FROM WebRecipe WHERE UserId={userId}").ForEach(recipe => listOfRecipes.Add(recipe));
            database.Query<BookRecipe>($"SELECT * FROM BookRecipe WHERE UserId={userId}").ForEach(recipe => listOfRecipes.Add(recipe));
            return listOfRecipes;
        }

        public void UpdateRecipe(Recipe recipe)
        {
            database.Update(recipe);
        }

        public void DeleteRecipe(Recipe recipe)
        {
            database.Execute($"DELETE FROM IngredientByRecipe where RecipeId={recipe.Id}");
            database.Delete(recipe);
        }

        public void AddIngredient(Ingredient newIngredient)
        {
            database.Insert(newIngredient);
        }

        public List<Ingredient> GetAllIngredients()
        {
            return database.Table<Ingredient>().ToList();
        }

        public void AddIngredientByRecipe(IngredientByRecipe newIngredientByRecipe)
        {
            database.Insert(newIngredientByRecipe);
        }

        public List<IngredientByRecipe> GetIngredientsByRecipe(int recipeId)
        {
            return database.Query<IngredientByRecipe>($"SELECT * FROM IngredientByRecipe WHERE RecipeId={recipeId}");
        }

        public void DeleteIngredientsByRecipe(int recipeId)
        {
            database.Execute($"DELETE FROM IngredientByRecipe where RecipeId={recipeId}");
        }

        public void AddMeal(Meal meal)
        {
            database.Insert(meal);
        }

        public void AddRecipeByMeal(RecipeByMeal recipeByMeal)
        {
            database.Insert(recipeByMeal);
        }

        public List<Meal> GetAllCurrentUserMeals(int userId)
        {
            return database.Query<Meal>($"SELECT * FROM Meal WHERE UserId={userId}");
        }

        public void UpdateMeal(Meal meal)
        {
            database.Update(meal);
        }

        public void DeleteMeal(Meal meal)
        {
            database.Execute($"DELETE FROM RecipeByMeal where MealId={meal.Id}");
            database.Delete(meal);
        }

        public List<Recipe> GetRecipesByMeal(int mealId)
        {
            var listOfRecipes = new List<Recipe>();
            var recipes = database.Query<RecipeByMeal>($"SELECT RecipeId FROM RecipeByMeal WHERE MealId={mealId}")
                .Select(rbm => rbm.RecipeId).ToArray();
            var selectWhereStatement = new StringBuilder("WHERE Id in (");
            for (int i = 0; i < recipes.Length; i++)
            {
                selectWhereStatement.Append(recipes[i]);
                if (i < recipes.Length - 1)
                {
                    selectWhereStatement.Append(",");
                }
                else
                {
                    selectWhereStatement.Append(")");
                }
            }

            var whereQuery = selectWhereStatement.ToString();
            var personalRecipeQuery = $"SELECT * FROM PersonalRecipe {whereQuery}";
            var webRecipeQuery = $"SELECT * FROM WebRecipe {whereQuery}";
            var bookRecipeQuery = $"SELECT * FROM BookRecipe {whereQuery}";

            database.Query<PersonalRecipe>(personalRecipeQuery)
                .ForEach(recipe => listOfRecipes.Add(recipe));
            database.Query<WebRecipe>(webRecipeQuery)
                .ForEach(recipe => listOfRecipes.Add(recipe));
            database.Query<BookRecipe>(bookRecipeQuery)
                .ForEach(recipe => listOfRecipes.Add(recipe));
            return listOfRecipes;
        }

        public void DeleteRecipesByMeal(int mealId)
        {
            database.Execute($"DELETE FROM RecipeByMeal where MealId={mealId}");

        }

        public List<string> GetIngredientsByMealIds(int[] mealIds)
        {
            if (mealIds.Length == 0)
            {
                return new List<string>();
            }
            var selectWhereStatement = new StringBuilder
            (
                "SELECT * FROM Ingredient WHERE Id IN (SELECT DISTINCT IngredientId FROM IngredientByRecipe WHERE RecipeId IN (SELECT DISTINCT RecipeId FROM RecipeByMeal WHERE MealId IN ("
            );
            for (int i = 0; i < mealIds.Length; i++)
            {
                selectWhereStatement.Append(mealIds[i]);
                if (i < mealIds.Length - 1)
                {
                    selectWhereStatement.Append(",");
                }
                else
                {
                    selectWhereStatement.Append(")))");
                }
            }
            return database.Query<Ingredient>(selectWhereStatement.ToString()).Select(ingredient => ingredient.Title).ToList();
        }
    }
}
