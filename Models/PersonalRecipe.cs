using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerCookBook.Models
{
    public class PersonalRecipe : Recipe
    {
        public bool Secret { get; set; }

        public PersonalRecipe(int userId, string title, string category, string instructions, string createdBy, DateTime createdDate, string modifiedBy, DateTime modifiedDate, bool secret)
            :base(userId, title, category, instructions, createdBy, createdDate, modifiedBy, modifiedDate)
        {
            Secret = secret;
        }
    }
}
