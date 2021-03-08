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
    public partial class CreateIngredient : Form
    {
        private bool exit = true;
        public CreateIngredient()
        {
            InitializeComponent();
            measurementComboBox.Items.AddRange(new object[] { "Weight", "Volume", "Quantity"});
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            exit = false;
            Navigation.NavigateBack(this);
        }

        private void CreateIngredient_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(exit)
            {
                Application.Exit();
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            exit = false;
            Globals.CreateNewIngredient(nameTextBox.Text, measurementComboBox.SelectedItem.ToString());
            Navigation.NavigateBack(this);
        }
    }
}
