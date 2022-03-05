using Microsoft.VisualStudio.TestTools.UnitTesting;
using System; 
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }
    
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Object()
    {
      Order newOrder = new Order("test", "test", 0, "date");
      Assert.AreEqual(typeof(Order), newOrder.GetType()); 
    }

    [TestMethod]
    public void GetTitle_ReturnsOrderTitle_String()
    {
      string orderTitle = "Order Title";
      Order newOrder = new Order(orderTitle, "test", 0, "date");
      string result = newOrder.Title;
      Assert.AreEqual(orderTitle, result);
    }

    [TestMethod]
    public void SetTitle_ChangesOrderTitle_String()
    {
      string orderTitle = "Order Title";
      Order newOrder = new Order(orderTitle, "test", 0, "date");
      string updatedTitle = "Different Order Title";
      newOrder.Title = updatedTitle;
      string result = newOrder.Title;
      Assert.AreEqual(updatedTitle, result);
    }

    [TestMethod]
    public void GetDescription_GetsOrderDescription_String()
    {
      string orderTitle = "Order Title";
      string orderDescription = "Order Description";
      Order newOrder = new Order(orderTitle, orderDescription, 0, "date");
      string result = newOrder.Description;
      Assert.AreEqual(orderDescription, result);
    }

    [TestMethod]
    public void SetDescription_ChangesOrderDescription_String()
    {
      string orderTitle = "Order Title";
      string orderDescription = "Order Description";
      Order newOrder = new Order(orderTitle, orderDescription, 0, "date");
      string updatedDescription = "Different Order Description";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetPrice_GetsOrderPrice_Int()
    {
      int orderPrice = 50;
      Order newOrder = new Order("test", "test", orderPrice, "date");
      int result = newOrder.Price;
      Assert.AreEqual(orderPrice, result);
    }

    [TestMethod]
    public void SetPrice_ChangesOrderPrice_Int()
    {
      int orderPrice = 50;
      Order newOrder = new Order("test", "test", orderPrice, "date");
      int updatedPrice = 40;
      newOrder.Price = updatedPrice;
      int result = newOrder.Price;
      Assert.AreEqual(updatedPrice, result);
    }

    [TestMethod]
    public void GetDate_GetsOrderDate_String()
    {
      string date = "3-4-22";
      Order newOrder = new Order("test", "test", 0, date);
      string result = newOrder.Date;
      Assert.AreEqual(date, result);
    }

    [TestMethod]
    public void SetDate_ChangesOrderDate_String()
    {
      string date = "3-4-22";
      Order newOrder = new Order("test", "test", 0, date);
      string updatedDate = "Different Date";
      newOrder.Date = updatedDate;
      string result = newOrder.Date;
      Assert.AreEqual(updatedDate, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllOrderObjects_OrderList()
    {
      Order newOrder = new Order("title", "description", 0, "date");
      Order newOrder2 = new Order("title", "description", 0, "date");
      List<Order> newList = new List<Order> { newOrder, newOrder2 };
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void ClearAll_ClearsAllOrderObjects_OrderList()
    {
      Order newOrder = new Order("title", "description", 0, "date");
      Order newOrder2 = new Order("title", "description", 0, "date");
      List<Order> newList = new List<Order> { };
      Order.ClearAll();
      List<Order> result = Order.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

  }
}