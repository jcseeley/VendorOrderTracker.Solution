using Microsoft.VisualStudio.TestTools.UnitTesting;
using System; 
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Tests
{
  [TestClass]
  public class VendorTests
  {
    
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
  }
}