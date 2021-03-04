using BloggerCookBook.Exemptions;
using BloggerCookBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloggerCookBook.Controllers
{
    public static class Globals
    {
        public static User currentUser;

        public static bool LoginCurrentUser(string username, string password)
        {
            bool signedIn = false;
            try
            {
                var database = new SQLiteDataService();
                database.Initialize();

                List<User> signedInUser = database.GetAllUsers().Where(user => user.Username == username).ToList();

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
                database.Close();
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
    }
}
