// using Microsoft.AspNetCore.Mvc;
// using Vendor.Models;
// using System.Collections.Generic;

// namespace Vendor.Controllers
// {
//   public class OrderController : Controller
//   {
//   [HttpGet("/vendors")]
//     public ActionResult Index()
//     {
//       List<Vendor> allVendor = Vendor.GetAll();
//       return View(allVendor);
//     }

//   //   [HttpGet("/vendors/new")]
//   //   public ActionResult New()
//   //   {
//   //     return View();
//   //   }

//   //   [HttpPost("/vendors")]
//   //   public ActionResult Create(string vendorName)
//   //   {
//   //     Vendor newVendor = new Vendor(vendorName);
//   //     return RedirectToAction("Index");
//   //   }

//   //   [HttpGet("/vendors/{id}")]
//   //   public ActionResult Show(int id)
//   //   {
//   //     Dictionary<string, object> model = new Dictionary<string, object>();
//   //     Vendor selectedVendor = Vendor.Find(id);
//   //     List<Order> vendorItems = selectedVendor.Orders;
//   //     model.Add("vendor", selectedVendor);
//   //     model.Add("orders", vendorOrders);
//   //     return View(model);
//   //   }

//   //   [HttpPost("/vendors/{vendorId}/orders")]
//   //   public ActionResult Create(int vendorId, string orderDescription)
//   //   {
//   //     Dictionary<string, object> model = new Dictionary<string, object>();
//   //     Vendor foundVendor = Vendor.Find(VendorId);
//   //     Order newOrder = new Order(orderDescription);
//   //     foundVendor.AddOrder(newOrder);
//   //     List<Order> vendorOrders = foundVendor.Orders;
//   //     model.Add("orders", vendorOrders);
//   //     model.Add("vendor", foundVendor);
//   //     return View("Show", model);
//   //   }

//   // }
//   }
// }