using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class ItemC : ItemBase
    {

        public ItemC( int quantity)
        {
            this.ItemName = 'C';
            this.ItemPrice = 20;
            this.Quantity = quantity;
        }

    }
}
