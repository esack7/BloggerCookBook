﻿using System.Collections.Generic;
using System.Windows.Forms;

namespace BloggerCookBook.Controllers
{
    public static class Navigation
    {
        private static Stack<Form> AppFormNavigationStack = new Stack<Form>();

        public static void StartNavigation(Form startForm)
        {
            AppFormNavigationStack.Push(startForm);
        }
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

        public static Form PeekCurrentForm()
        {
            return AppFormNavigationStack.Peek();
        }
    }
}
