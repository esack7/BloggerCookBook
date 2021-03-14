using BloggerCookBook.Controllers;
using BloggerCookBook.Exemptions;
using System;
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
                userIdTextBox.Text = "test"; //remove after building
                passwordTextBox.Text = "test"; //remove after building
                bool loggedIn = Globals.LoginCurrentUser(userIdTextBox.Text, passwordTextBox.Text);
                userIdTextBox.Text = "";
                passwordTextBox.Text = "";
                Navigation.NavigateTo(new MainMenu(), this);
            }
            catch (LoginException error)
            {
                MessageBox.Show(error.Message, "Instructions", MessageBoxButtons.OK);
            }
        }
    }
}
