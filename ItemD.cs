using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class ItemD : ItemBase
    {

        public ItemD(int quantity)
        {
            this.ItemName = 'D';
            this.ItemPrice = 15;
            this.Quantity = quantity;
        }

    }
}
