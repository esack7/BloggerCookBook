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
            var mainMenu = new MainMenu();
            mainMenu.Show();
            Hide();
        }
    }
}
