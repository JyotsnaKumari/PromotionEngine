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

            double sum = 0;
            Dictionary<char, double> finalCart = new Dictionary<char, double>();
            Console.WriteLine("WElcome...!! What would you like to shop? \n");
            Console.WriteLine("A- Price 50 \nB- Price 30 \nC- Price 20 \nD- Price 15 \n");

            Console.WriteLine("How many numbers of Item 'A'. Please press 0 if you dnt want this item.\n");
            string ItemA  = Console.ReadLine();
            ItemBase firstItem = new ItemA(Convert.ToInt32(ItemA));
           
            Console.WriteLine("How many numbers of Item 'B'. Please press 0 if you dnt want this item.\n");
            string ItemB = Console.ReadLine();
            ItemBase secondItem = new ItemB(Convert.ToInt32(ItemB));          

            Console.WriteLine("How many numbers of Item 'C'. Please press 0 if you dnt want this item.\n");
            string ItemC = Console.ReadLine();
            ItemBase thirdItem = new ItemC(Convert.ToInt32(ItemC));

            Console.WriteLine("How many numbers of Item 'D'. Please press 0 if you dnt want this item.\n");
            string ItemD = Console.ReadLine();
            ItemBase fourthItem = new ItemD(Convert.ToInt32(ItemD));


            //Apply promotion1
            Promotion1 promo1 = new Promotion1(firstItem);
            Dictionary<char, double> dataA = promo1.ApplyPromotion1();

            //Apply promotion2
            Promotion2 promo2 = new Promotion2(secondItem);
            Dictionary<char, double> dataB = promo2.ApplyPromotion2();

            //Apply promotion3 
            Promotion3 promo3 = new Promotion3();
            Dictionary<char, double> dataCD = promo3.ApplyPromotion3(thirdItem, fourthItem);


            foreach (KeyValuePair<char, double> cart in dataA)
            {
                Console.WriteLine("{0} = {1}", cart.Key, cart.Value);
            }
            foreach (KeyValuePair<char, double> cart in dataB)
            {
                Console.WriteLine("{0} = {1}", cart.Key, cart.Value);
            }
            foreach (KeyValuePair<char, double> cart in dataCD)
            {
                Console.WriteLine("{0} = {1}", cart.Key, cart.Value);
            }



        }
    }
}
