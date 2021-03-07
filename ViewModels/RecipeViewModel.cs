using BloggerCookBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerCookBook.ViewModels
{
    public class RecipeViewModel
    {
        public string Title { get; set; }
        public string Category { get; set; }

        private Recipe _recipe;

        public RecipeViewModel(Recipe recipe)
        {
            _recipe = recipe;
            Title = recipe.Title;
            Category = recipe.Category;
        }

        public Recipe GetRecipe()
        {
            return _recipe;
        }
    }
}
