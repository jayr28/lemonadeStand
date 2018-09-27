using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{

    class Store
    {
        public double quantity;
        public double totalPrice;

        //choose item that player needs
        public static List<string> GetItems()
        {
            List<string> Items = new List<string>();
            Items.Add("lemons");
            Items.Add("cups");
            Items.Add("sugar");
            Items.Add("ice cubes");
            return Items;

        }

        public string DisplayItems(items)
        {
            GetItems();
            foreach(string item in Item)
            {
                Console.WriteLine(item);
            }
        }

        //how many quantity does it need
        //payfor the item

    }
}
