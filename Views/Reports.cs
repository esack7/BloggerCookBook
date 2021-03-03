using BloggerCookBook.Controllers;
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
    public partial class Reports : Form
    {
        public Reports()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Navigation.NavigateBack(this);
        }
    }
}
