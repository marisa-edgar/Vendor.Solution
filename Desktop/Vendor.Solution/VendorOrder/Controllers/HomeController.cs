using Microsoft.AspNetCore.Mvc;

namespace VendorOrder.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
    return View();
    }
  }
}