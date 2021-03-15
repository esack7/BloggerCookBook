using SQLite;
using System;

namespace BloggerCookBook.Models
{
    public class Meal
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Type { get; set; }
        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
