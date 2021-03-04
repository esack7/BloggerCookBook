using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerCookBook.Models
{
    public class RecipeByMeal
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public int MealId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
