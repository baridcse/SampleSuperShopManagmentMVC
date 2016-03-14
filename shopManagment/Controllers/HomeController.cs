using shopManagment.Models;
using shopManagment.Models.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace shopManagment.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        ItemGateway aGateway = new ItemGateway();
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult GetSellView()
        {
            return View("Sell");
        }
        
        public ActionResult GetReportView()
        {
            return View("Reports");
        }
        public ActionResult GetItemView()
        {
            
            List<Item> aList = aGateway.GetList();
            return View("Items", aList);
        }
        public ActionResult GetItemView2(string itemName, int itemQuantity, double unitPrice)
        {
            Item aItem = new Item();
            
                aItem.Name = itemName;
                aItem.Quantity = itemQuantity;
                aItem.UnitPrice = unitPrice;
                aGateway.Insert(aItem);
            
            List<Item> aList = aGateway.GetList();
            return View("Items", aList);
        }
    }
}