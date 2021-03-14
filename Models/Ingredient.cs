using SQLite;
using System;

namespace BloggerCookBook.Models
{
    public class Ingredient
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Title { get; set; }
        public string MeasureType { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }

        //public Ingredient(string title, string measureType, string createdBy, DateTime createdDate, string modifiedBy, DateTime modifiedDate)
        //{
        //    Title = title;
        //    MeasureType = measureType;
        //    CreatedBy = createdBy;
        //    CreatedDate = createdDate;
        //    ModifiedBy = modifiedBy;
        //    ModifiedDate = modifiedDate;
        //}
    }
}
