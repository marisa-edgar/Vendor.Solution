using Microsoft.AspNetCore.Mvc;
using Vendor.Models;
using System.Collections.Generic;

namespace Vendor.Controllers
{
  public class HomeController : Controller
  {

    [Route("/")]
    public ActionResult Index()
    {
    return View;
    }
  }
}