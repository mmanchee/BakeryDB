using Microsoft.VisualStudio.TestTools.UnitTesting;
using BakeryDB.Models;
using System.Collections.Generic;
using System;

namespace BakeryDB.Tests
{
  [TestClass]
  public class VendorTest
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name);

      //Act
      string result = newVendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }
    [TestMethod]
    public void VendorId_ReturnsVendorId_Int()
    {
      //Arrange

      //Act
      int result = Vendor.VendorId();

      //Assert
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name = "Test Vendor";
      Vendor newVendor = new Vendor(name);

      //Act
      int result = newVendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }
  }
}