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
      _vendorCount++;
      Id = _vendorCount;
      Order = new List<Order> { };
    }
    public static void ClearAll()
    {
      _vendorCount = 0;
      _vendorList.Clear();
    }
    public static List<Vendor> GetAll()
    {
      return _vendorList;
    }
    public static Vendor Find(int searchId)
    {
      return _vendorList.Find(x => x.Id == searchId);
    }
  }
}



