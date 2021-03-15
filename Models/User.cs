using SQLite;
using System;

namespace BloggerCookBook.Models
{
    public class User
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }
}
