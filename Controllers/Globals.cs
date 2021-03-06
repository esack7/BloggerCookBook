using BloggerCookBook.Exemptions;
using BloggerCookBook.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloggerCookBook.Controllers
{
    public static class Globals
    {
        public static User currentUser;
        public static BindingList<Ingredient> AllIngredients;

        public static bool LoginCurrentUser(string username, string password)
        {
            bool signedIn = false;
            try
            {
                var database = new SQLiteDataService();
                database.Initialize();
                List<User> signedInUser = database.GetAllUsers().Where(user => user.Username == username).ToList();
                database.Close();

                if(username == "" || password == "")
                {
                    throw new ArgumentNullException();
                }

                if (signedInUser.Count < 1)
                {
                    throw new LoginException("The User Name you entered does not exist.");
                }

                if (signedInUser.First().Password != password)
                {
                    throw new LoginException("The password is incorrect");
                }

                currentUser = signedInUser.First();
                signedIn = true;
            }
            catch(ArgumentNullException)
            {
                throw new LoginException("You must have both User Id and a Password");
            }
            catch (LoginException error)
            {
                throw error;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Instructions", MessageBoxButtons.OK);
            }
            return signedIn;
        }

        public static List<Ingredient> GetAllIngredientsFromDB()
        {
            var database = new SQLiteDataService();
            database.Initialize();
            var allIngredients = database.GetAllIngredients();
            database.Close();
            return allIngredients;
        }

        public static void CreateNewIngredient(string title, string measureType)
        {
            var database = new SQLiteDataService();
            database.Initialize();
            var newIngredient = new Ingredient { Title = title, MeasureType = measureType, CreatedBy = currentUser.Username, CreatedDate = DateTime.Now };
            database.AddIngredient(newIngredient);
            database.Close();
            AllIngredients.Add(newIngredient);
        }

        public static void FormatDisplayedData(DataGridView dataGridView)
        {
            bool showFill = true;
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                if(dataGridView.Columns[i].Visible == true && showFill)
                {
                    dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    showFill = false;
                } 
                else
                {
                    dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
            dataGridView.RowHeadersVisible = false;
            dataGridView.ReadOnly = true;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ClearSelection();
        }
    }
}
