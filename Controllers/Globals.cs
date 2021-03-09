using BloggerCookBook.Exemptions;
using BloggerCookBook.Models;
using BloggerCookBook.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloggerCookBook.Controllers
{
    public static class Globals
    {
        public static User currentUser;
        public static BindingList<MealViewModel> AllUsersMeals;
        public static BindingList<RecipeViewModel> AllUsersRecipes;
        public static BindingList<IngredientViewModel> AllIngredients;
        
        private static int recipeId = 0;

        public static bool LoginCurrentUser(string username, string password)
        {
            bool signedIn = false;
            try
            {
                var database = new SQLiteDataService();
                database.Initialize();
                List<User> signedInUser = database.GetAllUsers().Where(user => user.Username == username).ToList();
                database.Close();

                if(username == "" || password == "")
                {
                    throw new ArgumentNullException();
                }

                if (signedInUser.Count < 1)
                {
                    throw new LoginException("The User Name you entered does not exist.");
                }

                if (signedInUser.First().Password != password)
                {
                    throw new LoginException("The password is incorrect");
                }

                currentUser = signedInUser.First();
                signedIn = true;
            }
            catch(ArgumentNullException)
            {
                throw new LoginException("You must have both User Id and a Password");
            }
            catch (LoginException error)
            {
                throw error;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Instructions", MessageBoxButtons.OK);
            }
            return signedIn;
        }

        public static void CreateNewRecipe(List<IngredientByRecipe> ingredientByRecipeList, Recipe newRecipe)
        {
            recipeId++;
            var database = new SQLiteDataService();
            database.Initialize();
            newRecipe.Id = recipeId;
            database.AddRecipe(newRecipe);
            ingredientByRecipeList.ForEach(ibr =>
            {
                ibr.RecipeId = newRecipe.Id;
                database.AddIngredientByRecipe(ibr);
            });
            database.Close();
            AllUsersRecipes.Add(new RecipeViewModel(newRecipe));
        }

        public static void UpdateRecipe(List<IngredientByRecipe> ingredientByRecipeList, Recipe recipe, RecipeViewModel recipeView)
        {
            var originalRecipe = recipeView.GetRecipe();
            var database = new SQLiteDataService();
            database.Initialize();
            database.UpdateRecipe(recipe);
            database.DeleteIngredientsByRecipe(originalRecipe.Id);
            ingredientByRecipeList.ForEach(ibr =>
            {
                ibr.RecipeId = originalRecipe.Id;
                database.AddIngredientByRecipe(ibr);
            });
            database.Close();
            var allUsersRecipesList = AllUsersRecipes.ToList();
            AllUsersRecipes.Clear();
            var index = allUsersRecipesList.IndexOf(recipeView);
            allUsersRecipesList.RemoveAt(index);
            allUsersRecipesList.Insert(index, new RecipeViewModel(recipe));
            allUsersRecipesList.ForEach(rVM => AllUsersRecipes.Add(rVM));
        }

        public static List<RecipeViewModel> GetAllCurrentUserRecipesFromDB()
        {
            var database = new SQLiteDataService();
            database.Initialize();
            var recipeViewModels = database.GetAllCurrentUserRecipes(currentUser.Id)
                .Select(recipe => {
                    if(recipe.Id > recipeId)
                    {
                        recipeId = recipe.Id;
                    }
                    return new RecipeViewModel(recipe);
                 }).ToList();
            database.Close();
            return recipeViewModels;
        }

        public static void DeleteRecipes(List<RecipeViewModel> recipesToDelete)
        {
            var database = new SQLiteDataService();
            database.Initialize();
            recipesToDelete.ForEach(recipeView =>
            {
                AllUsersRecipes.Remove(recipeView);
                database.DeleteRecipe(recipeView.GetRecipe());
            });
            database.Close();
        }

        public static List<IngredientViewModel> GetAllIngredientsFromDB()
        {
            var database = new SQLiteDataService();
            database.Initialize();
            var allIngredients = database.GetAllIngredients().Select(ingredient => new IngredientViewModel(ingredient)).ToList();
            database.Close();
            return allIngredients;
        }

        public static void CreateNewIngredient(string title, string measureType)
        {
            var database = new SQLiteDataService();
            database.Initialize();
            var newIngredient = new Ingredient { Title = title, MeasureType = measureType, CreatedBy = currentUser.Username, CreatedDate = DateTime.Now };
            database.AddIngredient(newIngredient);
            database.Close();
            AllIngredients.Add(new IngredientViewModel(newIngredient));
        }

        public static List<IngredientByRecipe> GetIngredientsInRecipe(int recipeId)
        {
            var database = new SQLiteDataService();
            database.Initialize();
            var ingredientsByRecipeList = database.GetIngredientsByRecipe(recipeId);
            database.Close();
            return ingredientsByRecipeList;
        }

        public static void CreateNewMeal(Meal meal, List<RecipeViewModel> listOfRecipes)
        {
            var database = new SQLiteDataService();
            database.Initialize();
            database.AddMeal(meal);
            listOfRecipes.Select(recipe => new RecipeByMeal
            {
                RecipeId = recipe.GetRecipe().Id,
                MealId = meal.Id,
                CreatedDate = DateTime.Now,
                CreatedBy = currentUser.Username
            }).ToList().ForEach(rbm => {
                database.AddRecipeByMeal(rbm);
            });
            database.Close();
            AllUsersMeals.Add(new MealViewModel(meal));
        }

        public static List<MealViewModel> GetAllCurrentUserMeals()
        {
            var database = new SQLiteDataService();
            database.Initialize();
            var mealViewModels = database.GetAllCurrentUserMeals(currentUser.Id).Select(meal => new MealViewModel(meal)).ToList();
            database.Close();
            return mealViewModels;
        }

        public static void DeleteMeal(MealViewModel mealView)
        {
            var database = new SQLiteDataService();
            database.Initialize();
            database.DeleteMeal(mealView.GetMeal());
            database.Close();
            AllUsersMeals.Remove(mealView);
        }

        public static void FormatDisplayedData(DataGridView dataGridView)
        {
            bool showFill = true;
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                if(showFill)
                {
                    dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    showFill = false;
                } 
                else
                {
                    dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
            dataGridView.RowHeadersVisible = false;
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ClearSelection();
        }
    }
}
