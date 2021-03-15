using BloggerCookBook.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace BloggerCookBookUnitTests
{
    [TestClass]
    public class RecipeUnitTest
    {
        [TestMethod]
        public void WebRecipeIsOfTypeRecipeTest()
        {
            //Arrange
            WebRecipe actual = new WebRecipe();
            List<Recipe> listofRecipes = new List<Recipe>();
            //Act
            listofRecipes.Add(actual);
            var expected = listofRecipes[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void PersonalRecipeIsOfTypeRecipeTest()
        {
            //Arrange
            PersonalRecipe actual = new PersonalRecipe();
            List<Recipe> listofRecipes = new List<Recipe>();
            //Act
            listofRecipes.Add(actual);
            var expected = listofRecipes[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void BookRecipeIsOfTypeRecipeTest()
        {
            //Arrange
            BookRecipe actual = new BookRecipe();
            List<Recipe> listofRecipes = new List<Recipe>();
            //Act
            listofRecipes.Add(actual);
            var expected = listofRecipes[0];
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
