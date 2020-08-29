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
            Console.WriteLine("A- Price 50 \n B- Price 30 \n C- Price 20 \n D- Price 15 \n");

            Console.WriteLine("How many numbers of Item 'A'. Please press 0 if you dnt want this item. Press  * to exit \n");
            string ItemA  = Console.ReadLine();
            items = new ItemA(Convert.ToInt32(ItemA));
            sum += items.Add(Convert.ToInt32(ItemA));

            Console.WriteLine("How many numbers of Item 'B'. Please press 0 if you dnt want this item. Press  * to exit \n");
            string ItemB = Console.ReadLine();
            items = new ItemB(Convert.ToInt32(ItemB));
            sum += items.Add(Convert.ToInt32(ItemB));

            Console.WriteLine("How many numbers of Item 'C'. Please press 0 if you dnt want this item. Press  * to exit \n");
            string ItemC = Console.ReadLine();
            items = new ItemC(Convert.ToInt32(ItemC));
            sum += items.Add(Convert.ToInt32(ItemC));

            Console.WriteLine("How many numbers of Item 'D'. Please press 0 if you dnt want this item. Press  * to exit \n");
            string ItemD = Console.ReadLine();
            items = new ItemD(Convert.ToInt32(ItemD));
             sum += items.Add(Convert.ToInt32(ItemD));

            Console.WriteLine("Amount to be paid"+ sum);

        }
    }
}
