using System.Collections.Generic;

namespace Vendor.Models
{
  public class Order
  {
    public string Description { get; set; }
    private static List<Order> _instances = new List<Order> {};
    public Order(string description)
    {
      Description = description;
      _instances.Add(this); 
    }

    public static List<Order> GetAll()
    {
      return _instances;
    }
  }
}