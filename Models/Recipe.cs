using SQLite;
using System;

namespace BloggerCookBook.Models
{
    public abstract class Recipe
    {
        [PrimaryKey]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Instructions { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
