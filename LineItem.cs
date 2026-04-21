using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuko
{
    public class LineItem
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string CupSize { get; set; }
        public int Quantity { get; set; }
        public decimal UnitPrice { get; set; }

        public decimal TotalPrice
        {
            get { return Quantity * UnitPrice; }
        }

        public LineItem(int productId, string productName, string cupSize, int quantity, decimal unitPrice)
        {
            ProductId = productId;
            ProductName = productName;
            CupSize = cupSize;
            Quantity = quantity;
            UnitPrice = unitPrice;
        }
    }
}