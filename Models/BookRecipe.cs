using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerCookBook.Models
{
    public class BookRecipe : Recipe
    {
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }

        //public BookRecipe(int userId, string title, string category, string instructions, string createdBy, DateTime createdDate, string modifiedBy, DateTime modifiedDate, string bookTitle, string bookAuthor)
        //    : base(userId, title, category, instructions, createdBy, createdDate, modifiedBy, modifiedDate)
        //{
        //    BookTitle = bookTitle;
        //    BookAuthor = bookAuthor;
        //}
    }
}
