using BloggerCookBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerCookBook.ViewModels
{
    public class MealViewModel
    {
        public string Type { get; set; }
        public string Title { get; set; }
        public string Day { get; set; }
        private Meal _meal;

        public MealViewModel(Meal meal)
        {
            _meal = meal;
            Type = meal.Type;
            Title = meal.Title;
            Day = meal.Date.DayOfWeek.ToString();
        }

        public Meal GetMeal()
        {
            return _meal;
        }
    }
}
