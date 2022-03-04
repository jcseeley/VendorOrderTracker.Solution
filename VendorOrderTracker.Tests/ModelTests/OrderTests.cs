using Microsoft.VisualStudio.TestTools.UnitTesting;
using System; 
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class OrderTests
  {
    
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Object()
    {
      Order newOrder = new Order("test", "test");
      Assert.AreEqual(typeof(Order), newOrder.GetType()); 
    }

    [TestMethod]
    public void GetTitle_ReturnsOrderTitle_String()
    {
      string orderTitle = "Order Title";
      Order newOrder = new Order(orderTitle, "test");
      string result = newOrder.Title;
      Assert.AreEqual(orderTitle, result);
    }

    [TestMethod]
    public void SetTitle_ChangesOrderTitle_String()
    {
      string orderTitle = "Order Title";
      Order newOrder = new Order(orderTitle, "test");
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
      Order newOrder = new Order(orderTitle, orderDescription);
      string result = newOrder.Description;
      Assert.AreEqual(orderDescription, result);
    }

    [TestMethod]
    public void SetDescription_ChangesOrderDescription_String()
    {
      string orderTitle = "Order Title";
      string orderDescription = "Order Description";
      Order newOrder = new Order(orderTitle, orderDescription);
      string updatedDescription = "Different Order Description";
      newOrder.Description = updatedDescription;
      string result = newOrder.Description;
      Assert.AreEqual(updatedDescription, result);
    }
  }
}

// [TestMethod]
// public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
// {
//   // any necessary logic to prep for test; instantiating new classes, etc.
//   Assert.AreEqual(EXPECTED RESULT, CODE TO TEST);
// }