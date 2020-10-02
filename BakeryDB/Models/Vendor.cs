using System.Collections.Generic;

namespace BakeryDB.Models
{
  public class Vendor
  {
    //Properties
    private static List<Vendor> _vendorList = new List<Vendor> { };
    private static int _vendorCount = 0;
    public string Name { get; set; }
    public int Id { get; }
    public List<Order> Order { get; set; }
    
    public Vendor(string name)
    {
      Name = name;
      _vendorList.Add(this);
      Id = _vendorCount;
      _vendorCount++;
      Order = new List<Order> { };
    }
  }
}



