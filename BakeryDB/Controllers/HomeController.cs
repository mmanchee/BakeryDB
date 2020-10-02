using Microsoft.AspNetCore.Mvc;

namespace BakeryDB.Controllers
{
  public class HomeController : Controller
  {

    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}