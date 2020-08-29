using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class Promotion1
    {
        private ItemBase items;

        public Promotion1(ItemBase item)
        {
            this.items = item;
        }

        /// <summary>
        /// 3 A's -> 130
        /// </summary>
        /// <returns>Dictionary of A final sum </returns>
        public Dictionary<char, double> ApplyPromotion1()
        {
            Dictionary<char, double> dic = new Dictionary<char, double>();
            double sum= 0;
            int quantity = items.Quantity;
            while (quantity != 0)
            {
                if (quantity % 3 == 0)
                {
                    sum += 130;
                    quantity = quantity - 3;
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
