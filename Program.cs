using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PromotionEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            ItemBase items;
            double sum = 0;
            Console.WriteLine("WElcome to this website. What would you like to shop? \n");
            Console.WriteLine("A- Price 50 \nB- Price 30 \nC- Price 20 \nD- Price 15 \n");

            Console.WriteLine("How many numbers of Item 'A'. Please press 0 if you dnt want this item.\n");
            string ItemA  = Console.ReadLine();
            items = new ItemA(Convert.ToInt32(ItemA));
            sum += items.Add(Convert.ToInt32(ItemA));

            //Apply promotion1
            Promotion1 promo1 = new Promotion1(items);
            Dictionary<char, double> dataA = promo1.ApplyPromotion1();

            Console.WriteLine("How many numbers of Item 'B'. Please press 0 if you dnt want this item.\n");
            string ItemB = Console.ReadLine();
            items = new ItemB(Convert.ToInt32(ItemB));
            sum += items.Add(Convert.ToInt32(ItemB));

            Console.WriteLine("How many numbers of Item 'C'. Please press 0 if you dnt want this item.\n");
            string ItemC = Console.ReadLine();
            items = new ItemC(Convert.ToInt32(ItemC));
            sum += items.Add(Convert.ToInt32(ItemC));

            Console.WriteLine("How many numbers of Item 'D'. Please press 0 if you dnt want this item.\n");
            string ItemD = Console.ReadLine();
            items = new ItemD(Convert.ToInt32(ItemD));
             sum += items.Add(Convert.ToInt32(ItemD));

            Console.WriteLine("Amount to be paid"+ sum);

        }
    }
}
