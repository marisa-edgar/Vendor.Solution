using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using VendorOrder.Models;
using System;

namespace VendorOrder.Tests
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
      Order newOrder = new Order("test title", "new order", 1, "01/01/01");
      Assert.AreEqual(typeof(Order), newOrder.GetType());
    }
    [TestMethod]
    public void GetDescription_ReturnsDescription_String()
    {
      string description = "new order";
      Order newOrder = new Order("test title",description, 1, "1");
      string result = newOrder.Description;
      Assert.AreEqual(description, result);
    }

    [TestMethod]
    public void SetDescription_SetDescription_String()
    {
      string description = "new order";
      Order newOrder = new Order("test title",description, 1, "1");
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

    [TestMethod]
    public void GetAll_ReturnsItems_OrderList()
    {
      string description01 = "new order";
      string description02 = "order 2";
      Order newOrder1 = new Order("test title",description01, 1, "1");
      Order newOrder2 = new Order("test title",description02, 1, "1");
      List<Order> newList = new List<Order> { newOrder1, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
    [TestMethod]
    public void GetProperties_ReturnsProperties_String()
    {
      string title = "test title";
      string description = "new order";
      int price = 1;
      string date = "01/01/01";
      Order newOrder = new Order(title, description, price, date);
      Order nextOrder = new Order("test title", "new order", 1, "01/01/01");
      string titleResult = newOrder.Title;
      string descriptionResult = newOrder.Description;
      int priceResult = newOrder.Price;
      string dateResult = newOrder.Date;
      Assert.AreEqual(title, titleResult);
      Assert.AreEqual(description, descriptionResult);
      Assert.AreEqual(price, priceResult);
      Assert.AreEqual(date, dateResult);

    }

  }
}

