using Microsoft.VisualStudio.TestTools.UnitTesting;
using System; 
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
    
    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Object()
    {
      Vendor newVendor = new Vendor("name", "description");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_GetsNameOfVendor_String()
    {
      string vendorName = "Vendor";
      Vendor newVendor = new Vendor(vendorName, "description");
      string result = newVendor.Name;
      Assert.AreEqual(vendorName, result);
    }

    [TestMethod]
    public void SetVendorName_ChangesNameOfVendor_String()
    {
      string vendorName = "Vendor";
      Vendor newVendor = new Vendor(vendorName, "description");
      string updatedName = "Different Name";
      newVendor.Name = updatedName;
      string result = newVendor.Name;
      Assert.AreEqual(updatedName, result);
    }

    [TestMethod]
    public void GetVendorDescription_GetsDescriptionOfVendor_String()
    {
      string vendorDescription = "Description";
      Vendor newVendor = new Vendor("name", vendorDescription);
      string result = newVendor.Description;
      Assert.AreEqual(vendorDescription, result);
    }

    [TestMethod]
    public void SetVendorDescription_ChangesDescriptionOfVendor_String()
    {
      Vendor newVendor = new Vendor("name", "description");
      string updatedDescription = "Different Description";
      newVendor.Description = updatedDescription;
      string result = newVendor.Description;
      Assert.AreEqual(updatedDescription, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      Vendor newVendor = new Vendor("name", "description");
      Vendor newVendor2 = new Vendor("name", "description");
      List<Vendor> newList = new List<Vendor> { newVendor, newVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void ClearAll_ReturnsEmptyList_VendorList()
    {
      Vendor newVendor = new Vendor("name", "description");
      Vendor newVendor2 = new Vendor("name", "description");
      List<Vendor> newList = new List<Vendor> { };
      Vendor.ClearAll();
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetId_ReturnsVendorId_Int()
    {
      Vendor newVendor = new Vendor("name", "description");
      int result = newVendor.Id;
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      Vendor newVendor = new Vendor("name", "description");
      Vendor newVendor2 = new Vendor("name", "description");
      Vendor result = Vendor.Find(1);
      Assert.AreEqual(newVendor, result);
    }

    [TestMethod]
    public void AddOrder_AddsOrderToVendor_OrderList()
    {
      Order newOrder = new Order("title", "description", 0, "date");
      Vendor newVendor = new Vendor("name", "description");
      List<Order> newList = new List<Order> { newOrder };
      newVendor.AddOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void RemoveOrder_RemovesOrderFromVendor_OrderList()
    {
      Order newOrder = new Order("title", "description", 0, "date");
      Vendor newVendor = new Vendor("name", "description");
      List<Order> newList = new List<Order> {  };
      newVendor.AddOrder(newOrder);
      newVendor.RemoveOrder(newOrder);
      List<Order> result = newVendor.Orders;
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void RemoveVendor_RemovesVendorFromList_VendorList()
    {
      Vendor newVendor = new Vendor("name", "description");
      Vendor newVendor2 = new Vendor("name", "description");
      List<Vendor> newList = new List<Vendor> { newVendor2 };
      Vendor.RemoveVendor(newVendor);
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(newList, result);
    }
  }
}