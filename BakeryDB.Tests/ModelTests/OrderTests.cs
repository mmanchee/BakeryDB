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
      Order newOrder = new Order("MM-DD-YYYY", "MM-DD-YYYY");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetDate_ReturnsDate_String()
    {
      //Arrange
      string dateOrdered = "MM-DD-YYYY";
      string dateRec = "MM-DD-YYYY";
      Order newOrder = new Order(dateOrdered, dateRec);

      //Act
      string result = newOrder.DateOrdered;

      //Assert
      Assert.AreEqual(dateOrdered, result);
    }
    [TestMethod]
    public void SetDateRec_SetDateRec_String()
    {
      //Arrange
      string dateOrdered = "MM-DD-YYYY";
      string dateRec = "MM-DD-YYYY";
      Order newOrder = new Order(dateOrdered, dateRec);

      //Act
      string updatedDateRec = "09-31-2020";
      newOrder.DateRec = updatedDateRec;
      string result = newOrder.DateRec;

      //Assert
      Assert.AreEqual(updatedDateRec, result);
    }
  }
}