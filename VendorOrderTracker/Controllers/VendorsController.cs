using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class VendorsController : Controller
  {
    [HttpGet("/vendors")]
    public ActionResult Index()
    {
      List<Vendor> allVendors = Vendor.GetAll();
      return View(allVendors);
    }

    [HttpGet("/vendors/new")]
    public ActionResult New()
    {
      return View();
    }

    [HttpPost("/vendors")]
    public ActionResult Create(string vendorName, string vendorDescription)
    {
      Vendor newVendor = new Vendor(vendorName, vendorDescription);
      return RedirectToAction("Index");
    }

    [HttpGet("/vendors/{id}/orders")]
    public ActionResult Show(int id)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor selectedVendor = Vendor.Find(id);
      List<Order> vendorOrders = selectedVendor.Orders;
      model.Add("Vendor", selectedVendor);
      model.Add("Orders", vendorOrders);
      return View(model);
    }

    [HttpPost("/vendors/{id}/orders")]
    public ActionResult Create( int vendorId, string orderTitle, string orderDescription, int orderPrice, string orderDate)
    {
      Dictionary<string, object> model = new Dictionary<string, object>();
      Vendor vendor = Vendor.Find(vendorId);
      Order newOrder = new Order(orderTitle, orderDescription, orderPrice, orderDate);
      vendor.AddOrder(newOrder);
      List<Order> vendorOrders = vendor.Orders;
      model.Add("Orders", vendorOrders);
      model.Add("Vender", vendor);
      return View("Show", model);
    }

    [HttpPost("/vendors/delete")]
    public ActionResult Delete(int id)
    {
    Vendor.RemoveVendor(id);
    return View();
    }
  }
}