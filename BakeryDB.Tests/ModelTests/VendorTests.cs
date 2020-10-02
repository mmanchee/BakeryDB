using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryDB.Models;
using System.Collections.Generic;
using System;

namespace BakeryDB.Tests
{
  [TestClass]
  public class VendorTest : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("starbucks");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Starbucks";
      Vendor newVendor = new Vendor(name);

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name1 = "Starbucks";
      string name2 = "Bob's Coffee";
      Vendor newVendor1 = new Vendor(name1);
      Vendor newVendor2 = new Vendor(name2);

      //Act
      int result1 = newVendor1.Id;
      int result2 = newVendor2.Id;

      //Assert
      Assert.AreEqual(1, result1);
      Assert.AreEqual(2, result2);
    }
    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name1 = "Starbucks";
      string name2 = "Bob's Coffee";
      Vendor newVendor1 = new Vendor(name1);
      Vendor newVendor2 = new Vendor(name2);
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name1 = "Starbucks";
      string name2 = "Bob's Coffee";
      Vendor newVendor1 = new Vendor(name1);
      Vendor newVendor2 = new Vendor(name2);

      //Act
      Vendor result1 = Vendor.Find(1);
      Vendor result2 = Vendor.Find(2);

      //Assert
      Assert.AreEqual(newVendor1, result1);
      Assert.AreEqual(newVendor2, result2);
    }
    public void Search_ReturnsCorrectVendors_Vendors()
    {
      //Arrange
      string name1 = "Starbucks";
      string name2 = "Bob's Coffee";
      Vendor newVendor1 = new Vendor(name1);
      Vendor newVendor2 = new Vendor(name2);

      //Act
      List<Vendor> result1 = Vendor.Search("star");

      //Assert
      Assert.AreEqual(newVendor1, result1);
    }
  }
}