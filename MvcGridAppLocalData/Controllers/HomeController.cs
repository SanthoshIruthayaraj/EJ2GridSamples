using MvcGridWebApp.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MvcGridWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            List<Order> orders = Order.GenerateOrdersList(200); // Change 10 to the desired count

            ViewBag.Orders = orders;

            return View();
        }
    }
}