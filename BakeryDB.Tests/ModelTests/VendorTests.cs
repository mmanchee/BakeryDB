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
    public void GetId_ReturnsVendorId_Int()
    {
      //Arrange
      string name1 = "Test Vendor 1";
      string name2 = "Test Vendor 2";
      Vendor newVendor1 = new Vendor(name1);
      Vendor newVendor2 = new Vendor(name2);

      //Act
      int result1 = newVendor1.Id;
      int result2 = newVendor2.Id;

      //Assert
      Assert.AreEqual(1, result1);
      Assert.AreEqual(2, result2);
    }
  }
}