using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace space_sander_web.Domain.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Create_With_Bad_Start_Trows_Error()
        {
            var rating = new Rating (0, "Name", "Review");
        }
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
    }
}
