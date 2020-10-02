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
      Id = VendorId();
      Order = new List<Order> { };
    }
    public static int VendorId()
    {
      return 0;
    }
    public static void ClearAll()
    {
      _vendorList.Clear();
    }
  }
}



