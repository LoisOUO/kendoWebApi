using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Product
    {
        public int Product_ID { get; set; }

        public string Product_Name { get; set; }
        
        public decimal UnitPrice { get; set; }

        public string CategoryName { get; set; }
        

    }
}