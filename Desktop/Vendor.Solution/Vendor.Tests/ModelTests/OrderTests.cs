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
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order newOrder = new Order("test");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
  }
}
