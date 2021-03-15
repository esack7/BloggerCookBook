using BloggerCookBook.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace BloggerCookBookTests.ControllerTests
{
    [TestClass]
    public class DateFormatterUnitTest
    {
        [TestMethod]
        public void DateFormatterReturnsCorrectDateWhenDayBeginningCalled()
        {
            //Arrange
            var date = new DateTime(2021, 3, 14, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            //Act
            var newDateFormatter = new DateFormatter(date);
            var actual = newDateFormatter.DayBeginning();
            var expected = new DateTime(2021, 3, 14);
            //Assert
            Assert.AreEqual(expected, actual);
        }

        public void DateFormatterReturnsCorrectToStringMethod()
        {
            //Arrange
            var date = new DateTime(2021, 3, 14, DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            //Act
            var newDateFormatter = new DateFormatter(date);
            var actual = newDateFormatter.ToString();
            var expected = "3-14-2021";
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
