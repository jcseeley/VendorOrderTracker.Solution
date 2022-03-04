using System.Collections.Generic;

namespace VendorOrderTracker.Models
{
  public class Order
  {
    public string Title { get; set; }
    public string Description { get; }
    public Order(string title, string description)
    {
      Title = title;
      Description = "no";
    }
  }
}