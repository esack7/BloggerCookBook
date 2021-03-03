using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerCookBook.Models
{
    public class WebRecipe : Recipe
    {
        public string Url { get; set; }

        //public WebRecipe(int userId, string title, string category, string instructions, string createdBy, DateTime createdDate, string modifiedBy, DateTime modifiedDate, string url)
        //    : base(userId, title, category, instructions, createdBy, createdDate, modifiedBy, modifiedDate)
        //{
        //    Url = url;
        //}
    }
}
