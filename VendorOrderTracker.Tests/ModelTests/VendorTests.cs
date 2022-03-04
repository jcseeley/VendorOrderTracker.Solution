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
      Vendor newVendor = new Vendor("name");
      Assert.AreEqual(typeof(Vendor), newVendor.GetType());
    }

    [TestMethod]
    public void GetVendorName_GetsNameOfVendor_String()
    {
      string vendorName = "Vendor";
      Vendor newVendor = new Vendor(vendorName);
      string result = newVendor.Name;
      Assert.AreEqual(vendorName, result);
    }
  }
}