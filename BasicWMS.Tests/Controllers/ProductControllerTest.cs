using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicWMS.Data.Infrastructure;
using BasicWMS.Data.Repositories;
using BasicWMS.Model;
using BasicWMS.Service;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace BasicWMS.Tests.Controllers
{
    [TestClass]
    public class ProductControllerTest
    {
        [TestMethod]
        public void GetProduct_ValidId()
        {
            //Arrange
            /*
            const int Id = 1;
            const string Name = "Fan";
            const string PartNumber = "S987";
            const string Label = "Daewoo Fan";
            const string Description = "Fan for the wall";
            const int StartingInventory = 10;
            const int InventoryOnHand = 5;
            const int InventoryReceived = 3;
            const int InventoryShipped = 2;
            const int MinimumRequired = 1;
             */

           Product mockProduct = new Product
            {
                Id = 1,
                Name = "Fan",
                PartNumber = "S987",
                Label = "Daewoo Fan",
                Description = "Fan for the wall",
                StartingInventory = 10,
                InventoryOnHand = 5,
                InventoryReceived = 3,
                InventoryShipped = 2,
                MinimumRequired = 1,
            };

            var mockRepository = new Mock<IProductRepository>();
            mockRepository.Setup(p => p.GetById(1)).Returns(mockProduct);

            //Act
            var productReturned = mockRepository.Object.GetById(1);

            //Assert
            Assert.AreEqual(mockProduct, productReturned);

        }
    }
}
