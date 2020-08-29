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
            Dictionary<char, double> dataA = null;
            Dictionary<char, double> dataB = null;
            Dictionary<char, double> dataC = null;
            Dictionary<char, double> dataD = null;
            Console.WriteLine("Welcome...!! What would you like to shop? \n");
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

                switch (firstItem.Quantity >= 3 ? 'A' : (secondItem.Quantity >= 2 ? 'B' : 'C'))
                {
                    case 'A':
                        //Apply promotion1
                        Console.WriteLine("Congratulations.. Applied Promotion1 3A -> 130");
                        Promotion1 promo1 = new Promotion1(firstItem);
                        dataA = promo1.ApplyPromotion1();
                        dataB = secondItem.Add(Convert.ToInt32(ItemB));
                        dataC = thirdItem.Add(Convert.ToInt32(ItemC));
                        dataD = fourthItem.Add(Convert.ToInt32(ItemD));
                        break;
                    case 'B':
                        //Apply promotion2
                        Console.WriteLine("Congratulations.. Applied Promotion2 2B -> 45");
                        Promotion2 promo2 = new Promotion2(secondItem);
                        dataB = promo2.ApplyPromotion2();
                        dataA = firstItem.Add(Convert.ToInt32(ItemA));
                        dataC = thirdItem.Add(Convert.ToInt32(ItemC));
                        dataD = fourthItem.Add(Convert.ToInt32(ItemD));
                        break;

                    case 'C':
                        //Apply promotion3
                        Console.WriteLine("Congratulations.. Applied Promotion3 C+D -> 30");
                        Promotion3 promo3 = new Promotion3();
                        dataC = promo3.ApplyPromotion3(thirdItem, fourthItem);
                        dataA = firstItem.Add(Convert.ToInt32(ItemA));
                        dataB = secondItem.Add(Convert.ToInt32(ItemB));
                        break;
                    default:
                        // default case taken care in case 'C'
                        break;
                }


                foreach (KeyValuePair<char, double> cart in dataA)
                {
                    Console.WriteLine("{0} = {1}", cart.Key, cart.Value);
                    sum += cart.Value;
                }
                foreach (KeyValuePair<char, double> cart in dataB)
                {
                    Console.WriteLine("{0} = {1}", cart.Key, cart.Value);
                    sum += cart.Value;
                }
                foreach (KeyValuePair<char, double> cart in dataC)
                {
                    Console.WriteLine("{0} = {1}", cart.Key, cart.Value);
                    sum += cart.Value;
                }
                foreach (KeyValuePair<char, double> cart in dataD)
                {
                    Console.WriteLine("{0} = {1}", cart.Key, cart.Value);
                    sum += cart.Value;
                }
                Console.WriteLine("Total= " + sum);
        }
    }
}
