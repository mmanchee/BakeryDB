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
    public List<Order> Orders { get; set; }
    
    public Vendor(string name)
    {
      Name = name;
      _vendorList.Add(this);
      _vendorCount++;
      Id = _vendorCount;
      Orders = new List<Order> { };
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
    public void AddOrder(Order order)
    {
      Orders.Add(order);
    }
    public static List<Vendor> Search(string search)
    {
      search = search.ToLower();
      List<Vendor> searchList = new List<Vendor> { };
      foreach(Vendor vendor in _vendorList)
      {
        string name = vendor.Name.ToLower();
        if (name.Contains(search))
        {
          searchList.Add(vendor); 
        }
      }
      return searchList;
    }
    public static void Delete(int id)
    {

    }
  }
}



