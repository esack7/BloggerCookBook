using BloggerCookBook.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace BloggerCookBookUnitTests
{
    [TestClass]
    public class RecipeUnitTest
    {
        //Arrange
        WebRecipe web = new WebRecipe { Url = "url" };
        PersonalRecipe personal = new PersonalRecipe { Secret = true };
        BookRecipe book = new BookRecipe { BookAuthor = "Author", BookTitle = "Title" };

        [TestMethod]
        public void WebRecipeIsOfTypeRecipeTest()
        {
            //Act
            var expected = web is Recipe;
            //Assert
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void PersonalRecipeIsOfTypeRecipeTest()
        {
            //Act
            var expected = personal is Recipe;
            //Assert
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void BookRecipeIsOfTypeRecipeTest()
        {
            //Act
            var expected = book is Recipe;
            //Assert
            Assert.IsTrue(expected);
        }

        [TestMethod]
        public void ListOfRecipesCanBeOfDifferentRecipeTypesTest()
        {
            //Arrange
            List<Recipe> listofRecipes = new List<Recipe>();
            listofRecipes.Add(web);
            listofRecipes.Add(personal);
            listofRecipes.Add(book);

            //Act
            var expectedWebTrue = listofRecipes[0] is WebRecipe;
            var expectedWebFalse1 = listofRecipes[0] is PersonalRecipe;
            var expectedWebFalse2 = listofRecipes[0] is BookRecipe;

            var expectedPersonalTrue = listofRecipes[1] is PersonalRecipe;
            var expectedPersonalFalse1 = listofRecipes[1] is WebRecipe;
            var expectedPersonalFalse2 = listofRecipes[1] is BookRecipe;

            var expectedBooklTrue = listofRecipes[2] is BookRecipe;
            var expectedBookFalse1 = listofRecipes[2] is WebRecipe;
            var expectedBookFalse2 = listofRecipes[2] is PersonalRecipe;

            //Assert
            Assert.IsTrue(expectedWebTrue);
            Assert.IsFalse(expectedWebFalse1);
            Assert.IsFalse(expectedWebFalse2);

            Assert.IsTrue(expectedPersonalTrue);
            Assert.IsFalse(expectedPersonalFalse1);
            Assert.IsFalse(expectedPersonalFalse2);

            Assert.IsTrue(expectedBooklTrue);
            Assert.IsFalse(expectedBookFalse1);
            Assert.IsFalse(expectedBookFalse2);
        }
    }
}
