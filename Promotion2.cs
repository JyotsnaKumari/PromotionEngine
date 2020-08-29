using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class Promotion2
    {
        private ItemBase items;

        public Promotion2(ItemBase item)
        {
            this.items = item;
        }

        /// <summary>
        /// 2 B's -> 45
        /// </summary>
        /// <returns>Dictionary of B final sum </returns>
        public Dictionary<char, double> ApplyPromotion2()
        {
            Dictionary<char, double> dic = new Dictionary<char, double>();
            double sum= 0;
            int quantity = items.Quantity;
            while (quantity != 0)
            {
                if (quantity % 2 == 0)
                {
                    sum += 45;
                    quantity = quantity - 2;
                }
                else
                {
                    sum += (items.ItemPrice);
                    quantity--;
                }
            }
            dic.Add(items.ItemName, sum);
            return dic;
        }
    }
}
