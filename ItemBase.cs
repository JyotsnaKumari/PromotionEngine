using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class ItemBase
    {
        protected char ItemName { get; set; }
        protected double ItemPrice { get; set; }
        protected int Quantity { get; set; }

        public double Add(int quantity)
        {
            return quantity * ItemPrice;
        }
    }
}
