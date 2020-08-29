using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    public class Promotion3
    {

        public Promotion3()
        {
        }

        /// <summary>
        /// 1 C + 1 D -> 30
        /// </summary>
        /// <returns>Dictionary of A final sum </returns>
        public Dictionary<char, double> ApplyPromotion3(ItemBase itemC, ItemBase itemD)
        {
            Dictionary<char, double> dic = new Dictionary<char, double>();
            double sumC= 0;
            double sumD = 0;
            int quantityC = itemC.Quantity;
            int quantityD = itemD.Quantity;
            if (quantityC <= quantityD)
            {
                sumC += quantityC * 30;
                quantityD = quantityD - quantityC;
                quantityC = 0;
                sumD += quantityD * itemD.ItemPrice;
            }
            else
            {
                sumD += quantityD * 30;
                quantityC = quantityC - quantityD;
                quantityD = 0;
                sumC += quantityC * itemC.ItemPrice;
            }
            dic.Add(itemC.ItemName, sumC);
            dic.Add(itemD.ItemName, sumD);
            return dic;
        }
    }
}
