﻿using BloggerCookBook.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerCookBook.Controllers
{
    public class SQLiteDataService: ILocalDataService
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
    }
}
