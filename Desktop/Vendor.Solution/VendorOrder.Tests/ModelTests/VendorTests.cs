using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{

    [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor newVendor = new Vendor("test vendor", "test description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      string name = "test vendor";
      Vendor newVendor = new Vendor(name, "test description");
      string result = newVendor.Name;
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      string name = "test vendor";
      Vendor newVendor = new Vendor(name, "test description");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      string name01 = "vendor1";
      string name02 = "vendor2";
      Vendor newVendor1 = new Vendor(name01, "test description");
      Vendor newVendor2 = new Vendor(name02, "test description");
      List<Vendor> newList = new List<Vendor> { newVendor1, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      string name01 = "vendor1";
      string name02 = "vendor2";
      Vendor newVendor1 = new Vendor(name01, "test description");
      Vendor newVendor2 = new Vendor(name02, "test description");
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(newVendor2, result);
    }

    [TestMethod]
    public void AddItem_AssociatesItemWithVendor_OrderList()
    {
      string description = "test vendor";
      Order newOrder = new Order("test title", description, 1, "1");
      List<Order> newList = new List<Order> { newOrder };
      string name = "vendor1";
      Vendor newVendor = new Vendor(name, "test description");
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Getdescription_ReturnsDescripton_String()
    {
      string name = "test vendor";
      string description = "test vendor";
      Vendor newVendor = new Vendor(name, description);
      Vendor nextVendor = new Vendor("test vendor", "test vendor");
      string nameResult = newVendor.Name;
      string descriptionResult = newVendor.Description;
      Assert.AreEqual(name, nameResult);
      Assert.AreEqual(description, descriptionResult);

    }
  }
}