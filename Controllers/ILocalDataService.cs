using BloggerCookBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerCookBook.Controllers
{
    public interface ILocalDataService
    {
        bool Initialize();
        void Close();
        void AddUser(User newUser);
        List<User> GetAllUsers();
        void AddRecipe(Recipe newRecipe);
        List<Recipe> GetAllCurrentUserRecipes(int userId);
        void UpdateRecipe(Recipe recipe);
        void DeleteRecipe(Recipe recipe);
        void AddIngredient(Ingredient newIngredient);
        List<Ingredient> GetAllIngredients();
        void AddIngredientByRecipe(IngredientByRecipe newIngredientByRecipe);
        List<IngredientByRecipe> GetIngredientsByRecipe(int recipeId);
        void DeleteIngredientsByRecipe(int recipeId);
        void AddMeal(Meal meal);
        void AddRecipeByMeal(RecipeByMeal recipeByMeal);
        List<Meal> GetAllCurrentUserMeals(int userId);
        void UpdateMeal(Meal meal);
        void DeleteMeal(Meal meal);
        List<Recipe> GetRecipesByMeal(int mealId);
        void DeleteRecipesByMeal(int mealId);
        List<string> GetIngredientsByMealIds(int[] mealIds);
    }
}
