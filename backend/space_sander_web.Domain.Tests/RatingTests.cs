using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using space.sander.web.Domain.Catalog;

namespace space_sander_web.Domain.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Create_New_Rating()
        {
            //Arrange
            var rating = new Rating(1, "Mike", "Great fit!");

            //Act - skip because there isn't action on constructor

            //Assert
            Assert.AreEqual(1, rating.Star);
            Assert.AreEqual("Mike", rating.UserName);
            Assert.AreEqual("Great fit!", rating.Review);
        }
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_With_Bad_Start_Trows_Error()
        {
            var rating = new Rating (0, "Name", "Review");
        }

        [TestMethod]
        public void Can_Create_Add_Rating()
        {
            //Arrange
            var item = new Item("Name", "Description", "Brand", "ImageUrl", 10.00m);
            var rating = new Rating(5,"Name","Review");
            //Act
            item.AddRating(rating);
            //Assert
            Assert.AreEqual(rating, item.Ratings[0]);
        } 

    }
}
