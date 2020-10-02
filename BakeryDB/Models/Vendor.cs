using System.Collections.Generic;

namespace BakeryDB.Models
{
  public class Vendor
  {
    //Properties
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Order { get; set; }
    
    public Vendor(string name)
    {
      Name = name;
    }
  }
}



