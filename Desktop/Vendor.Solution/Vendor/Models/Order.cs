using System.Collections.Generic;

namespace Vendor.Models
{
  public class Order
  {
    public string Description { get; }
    public Order(string description)
    {
      Description = description;
    }
  }
}