using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using VendorOrderTracker.Models;

namespace VendorOrderTracker.Controllers
{
  public class OrdersController : Controller
  {
    [HttpGet("/vendors/{id}/orders/new")]
    public ActionResult New()
    {
      return View();
    }
  }
}