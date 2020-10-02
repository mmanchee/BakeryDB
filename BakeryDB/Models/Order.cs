using System.Collections.Generic;

namespace BakeryDB.Models
{
  public class Order
  {
    //Properties
    public string DateOrdered { get; set; } // "MM-DD-YYYY"
    public Order(string dateOrdered)
    {
      DateOrdered = dateOrdered;
    }
  }
}