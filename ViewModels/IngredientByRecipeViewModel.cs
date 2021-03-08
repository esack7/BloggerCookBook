using BloggerCookBook.Controllers;
using BloggerCookBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerCookBook.ViewModels
{
    public class IngredientByRecipeViewModel
    {
        public string Ingredient { get; set; }
        public decimal Amount { get; set; }
        public string Unit { get; set; }

        private IngredientByRecipe _ingredientByRecipe;

        public IngredientByRecipeViewModel(IngredientByRecipe ingredientByRecipe)
        {
            _ingredientByRecipe = ingredientByRecipe;
            Ingredient = Globals.AllIngredients.Where(ingr => ingr.GetIngredient().Id == ingredientByRecipe.IngredientId).Single().GetIngredient().Title;
            Amount = ingredientByRecipe.MeasureAmount;
            Unit = ingredientByRecipe.MeasureUnit;
        }

        public IngredientByRecipe GetIngredientByRecipe()
        {
            return _ingredientByRecipe;
        }
    }
}
