using Microsoft.AspNetCore.Mvc;

namespace Vendor.Controllers
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