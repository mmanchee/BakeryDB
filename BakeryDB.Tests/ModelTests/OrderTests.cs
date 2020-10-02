using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryDB.Models;
using System.Collections.Generic;
using System;

namespace BakeryDB.Tests
{
  [TestClass]
  public class OrderTest
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test order");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      //Arrange
      string date = "Test Vendor";
      Order newOrder = new Order(date);

      //Act
      string result = newOrder.Date;

      //Assert
      Assert.AreEqual(date, result);
    }
  }
}