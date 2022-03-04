using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Vendor.Models;
using System;

namespace Vendor.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
    
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "new order";
      Order newOrder = new Order(description);
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "new order";
      Order newOrder = new Order(description);
      string updatedDescription = "order 2";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsEmptyList_OrderList()
    {
      List<Order> newList = new List<Order> { };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
}


  }
}
