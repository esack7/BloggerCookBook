using BloggerCookBook.Controllers;
using BloggerCookBook.Models;
using BloggerCookBook.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloggerCookBook
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            InitializeData(); // remove
            Application.Run(new AppStart());
        }

        private static void InitializeData()
        {
            var db = new SQLiteDataService();
            bool addData = db.Initialize();

            if (addData)
            {
                db.AddUser(new User { Username = "test", Password = "test", CreatedBy = "tester", CreatedDate = DateTime.Now });
                db.AddIngredient(new Ingredient { Title = "Flour", MeasureType = "Volume", CreatedBy = "test", CreatedDate = DateTime.Now });
                db.AddIngredient(new Ingredient { Title = "Baking Powder", MeasureType = "Volume", CreatedBy = "test", CreatedDate = DateTime.Now });
                db.AddIngredient(new Ingredient { Title = "Salt", MeasureType = "Volume", CreatedBy = "test", CreatedDate = DateTime.Now });
                db.AddIngredient(new Ingredient { Title = "Butter", MeasureType = "Volume", CreatedBy = "test", CreatedDate = DateTime.Now });
                db.AddIngredient(new Ingredient {  Title = "Milk", MeasureType = "Volume", CreatedBy = "test", CreatedDate = DateTime.Now });
            }
            db.Close();
        }
    }
}
