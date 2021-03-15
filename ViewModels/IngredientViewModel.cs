using BloggerCookBook.Models;

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
