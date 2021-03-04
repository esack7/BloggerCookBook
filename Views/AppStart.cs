using BloggerCookBook.Controllers;
using BloggerCookBook.Exemptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloggerCookBook.Views
{
    public partial class AppStart : Form
    {
        public AppStart()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                bool loggedIn = Globals.LoginCurrentUser(userIdTextBox.Text, passwordTextBox.Text);
                Navigation.NavigateTo(new MainMenu(), this);
            }
            catch (LoginException error)
            {
                MessageBox.Show(error.Message, "Instructions", MessageBoxButtons.OK);
            }
        }
    }
}
