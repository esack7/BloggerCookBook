using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloggerCookBook.Controllers
{
    public static class Navigation
    {
        private static Stack<Form> AppFormNavigationStack = new Stack<Form>();

        public static void NavigateTo(Form nextForm, Form currentForm)
        {
            AppFormNavigationStack.Push(currentForm);
            nextForm.Show();
            currentForm.Hide();
        }

        public static void NavigateBack(Form currentForm)
        {
            var previousForm = AppFormNavigationStack.Pop();
            currentForm.Close();
            previousForm.Show();
        }
    }
}
