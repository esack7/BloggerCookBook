using BloggerCookBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerCookBook.ViewModels
{
    public class IngredientViewModel
    {
        public string Ingredient { get; set; }
        public string Measurement { get; set; }

        private Ingredient _ingredient;

        public IngredientViewModel(Ingredient ingredient)
        {
            _ingredient = ingredient;
            Ingredient = ingredient.Title;
            Measurement = ingredient.MeasureType;
        }

        public Ingredient GetIngredient()
        {
            return _ingredient;
        }
    }
}
