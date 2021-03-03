﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerCookBook.Models
{
    public class IngredientByRecipe
    {
        public int IngredientId { get; set; }
        public int RecipeId { get; set; }
        public string MeasureUnit { get; set; }
        public decimal MeasureAmount { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}