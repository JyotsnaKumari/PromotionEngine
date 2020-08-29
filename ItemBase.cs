using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class ItemBase
    {
        public char ItemName { get; set; }
        public double ItemPrice { get; set; }
        public int Quantity { get; set; }

        public double Add(int quantity)
        {
            return quantity * ItemPrice;
        }
    }
}
