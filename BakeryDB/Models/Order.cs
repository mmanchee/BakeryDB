using System.Collections.Generic;

namespace BakeryDB.Models
{
  public class Order
  {
    //Properties
    private static List<Order> _orderList = new List<Order> { };
    private static int _invoice = 0;
    public string DateOrdered { get; set; } // "MM-DD-YYYY"
    public string DateRec { get; set; }     // "MM-DD-YYYY"
    public int Id { get; }

  
    public Order(string dateOrdered, string dateRec)
    {
      DateOrdered = dateOrdered;
      DateRec = dateRec;
      _orderList.Add(this);
      _invoice++;
      Id = _invoice;
    }
    public static List<Order> GetAll()
    {
      return _orderList;
    }
    public static void ClearAll()
    {
      _invoice = 0;
      _orderList.Clear();
    }
    
  }
}