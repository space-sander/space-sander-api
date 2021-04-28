using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using space.sander.web.Domain.Catalog;

namespace space_sander_web.Domain.Tests
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Can_Create_New_Item()
        {
            //Arrange
            var item = new Item("Name", "Description", "Brand", "ImageUrl", 10.00m);
            
            //Act - skip because there isn't action on constructor

            //Assert
            Assert.AreEqual("Name", item.Name);
            Assert.AreEqual("Description", item.Description);
            Assert.AreEqual("Brand", item.Brand);
            Assert.AreEqual(10.00m, item.Price);
            Assert.AreEqual("ImageUrl", item.ImageUrl);
        }
        
        
    }
}
