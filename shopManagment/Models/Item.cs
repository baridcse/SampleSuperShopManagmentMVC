using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace shopManagment.Models
{
    public class Item
    {
        public int Id { set; get; }
        public string Name { set; get; }
        public int Quantity { set; get; }
        public double UnitPrice { set; get; }
    }
}