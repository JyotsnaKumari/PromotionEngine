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

        public Dictionary<char,double> Add(int quantity)
        {
            Dictionary<char, double> data = new Dictionary<char, double>();
            data.Add(ItemName, quantity * ItemPrice);
            return data;
        }
    }
}
