using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETradeApp.Models
{
    public class Product
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public decimal UnitPrice { get; set; }
        public int StockAmount { get; set; }
        public virtual Category Category { get; set; }
        public virtual List<Picture> Pictures { get; set; }
    }
}
