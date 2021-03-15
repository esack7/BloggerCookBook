using BloggerCookBook.Controllers;
using BloggerCookBook.Models;
using BloggerCookBook.Views;
using System;
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
            InitializeData();
            Application.Run(new AppStart());
        }

        private static void InitializeData()
        {
            var db = new SQLiteDataService();
            bool addData = db.Initialize();

            if (addData)
            {
                db.AddUser(new User { Username = "test", Password = "test", CreatedBy = "tester", CreatedDate = DateTime.Now });
            }
            db.Close();
        }
    }
}
