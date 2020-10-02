using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryDB.Models;
using System.Collections.Generic;
using System;

namespace BakeryDB.Tests
{
  [TestClass]
  public class OrderTest : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
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
    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string dateOrdered1 = "MM-DD-YYYY";
      string dateOrdered2 = "MM-DD-YYYY";
      string dateRec1 = "MM-DD-YYYY";
      string dateRec2 = "MM-DD-YYYY";
      Order newOrder1 = new Order(dateOrdered1, dateRec1);
      Order newOrder2 = new Order(dateOrdered2, dateRec2);
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetId_OrdersInstantiateWithAnIdAndGetterReturns_Int()
    {
      //Arrange
      string dateOrdered = "MM-DD-YYYY";
      string dateRec = "MM-DD-YYYY";
      Order newOrder = new Order(dateOrdered, dateRec);

      //Act
      int result = newOrder.Id;

      //Assert
      Assert.AreEqual(1, result);
    }
  }
}