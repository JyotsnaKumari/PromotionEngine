using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class ItemA : ItemBase
    {

        public ItemA(int quantity)
        {
            this.ItemName = 'A';
            this.ItemPrice = 50;
            this.Quantity = quantity;
        }
        
    }
}
