using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class ItemB : ItemBase
    {
        public ItemB(int quantity)
        {
            this.ItemName = 'B';
            this.ItemPrice = 30;
            this.Quantity = quantity;
        }
    }
}
