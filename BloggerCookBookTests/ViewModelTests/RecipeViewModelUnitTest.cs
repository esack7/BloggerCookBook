using BloggerCookBook.Models;
using BloggerCookBook.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BloggerCookBookTests.ViewModelTests
{
    [TestClass]
    public class RecipeViewModelUnitTest
    {
        [TestMethod]
        public void RecipeViewModelWillReturnRecipeWhenGetRecipeCalled()
        {
            //Arrange
            var expected = new WebRecipe();
            var recipeView = new RecipeViewModel(expected);
            //Act
            var actual = recipeView.GetRecipe();
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RecipeViewModelHasCorrectTitle()
        {
            //Arrange
            var recipe = new WebRecipe { Title = "test title", Category = "test category" };
            var recipeView = new RecipeViewModel(recipe);
            var expected = recipe.Title;
            //Act
            var actual = recipeView.Title;
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void RecipeViewModelHasCorrectCategory()
        {
            //Arrange
            var recipe = new WebRecipe { Title = "test title", Category = "test category" };
            var recipeView = new RecipeViewModel(recipe);
            var expected = recipe.Category;
            //Act
            var actual = recipeView.Category;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
