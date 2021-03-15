using BloggerCookBook.Models;
using BloggerCookBook.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BloggerCookBookTests.ViewModelTests
{
    [TestClass]
    public class MealViewModelUnitTest
    {
        [TestMethod]
        public void MealViewModelWillReturnMealWhenGetMealCalled()
        {
            //Arrange
            var expected = new Meal();
            var mealView = new MealViewModel(expected);
            //Act
            var actual = mealView.GetMeal();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RecipeViewModelHasCorrectTitle()
        {
            //Arrange
            var meal = new Meal { Title = "test title", Type = "test type", Date = DateTime.Now };
            var mealView = new MealViewModel(meal);
            var expected = meal.Title;
            //Act
            var actual = mealView.Title;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RecipeViewModelHasCorrectType()
        {
            //Arrange
            var meal = new Meal { Title = "test title", Type = "test type", Date = DateTime.Now };
            var mealView = new MealViewModel(meal);
            var expected = meal.Type;
            //Act
            var actual = mealView.Type;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RecipeViewModelHasCorrectDay()
        {
            //Arrange
            var meal = new Meal { Title = "test title", Type = "test type", Date = DateTime.Now };
            var mealView = new MealViewModel(meal);
            var expected = meal.Date.DayOfWeek.ToString();
            //Act
            var actual = mealView.Day;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
