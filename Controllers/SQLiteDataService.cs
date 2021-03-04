using BloggerCookBook.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BloggerCookBook.Controllers
{
    public class SQLiteDataService: ILocalDataService
    {
        private SQLiteConnection database;
        public bool Initialize()
        {
            bool dbTablesCreated = false;
            if (database == null)
            {
                string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "BloggerCookbookDb.db3");
                database = new SQLiteConnection(dbPath);
            }

            var results = database.CreateTables<User, PersonalRecipe, WebRecipe, BookRecipe, Ingredient>()
                .Results.Select(result => result.Value).ToList();

            results.Add(database.CreateTable<IngredientByRecipe>());
            results.Add(database.CreateTable<RecipeByMeal>());

            foreach (var result in results)
            {
                dbTablesCreated = dbTablesCreated || result == CreateTableResult.Created;
            }

            return dbTablesCreated;
        }

        public void Close()
        {
            database.Close();
        }

        public void AddUser(User newUser)
        {
            database.Insert(newUser);
        }

        public List<User> GetAllUsers()
        {
            return database.Table<User>().ToList();
        }

        public void AddIngredient(Ingredient newIngredient)
        {
            database.Insert(newIngredient);
        }
    }
}
