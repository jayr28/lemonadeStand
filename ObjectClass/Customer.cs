using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {

        public int MinTemperature;

        public int MaxTemperature;

        public double MinPrice;

        public double MaxPrice;

        public bool CustomerBuyLemonade(Day day, Player player, ref Inventory inventory)
        {
            if (day.Temperature >= MinTemperature && day.Temperature <= MaxTemperature )
            {
                if (player.PriceForLemonade >= MinPrice && player.PriceForLemonade <= MaxPrice)
                {
                    if (inventory.items.Where(x => x.ItemId == "1").ToArray()[0].Quantity == 0 ||
                        inventory.items.Where(x => x.ItemId == "2").ToArray()[0].Quantity == 0 ||
                        inventory.items.Where(x => x.ItemId == "3").ToArray()[0].Quantity == 0 ||
                        inventory.items.Where(x => x.ItemId == "4").ToArray()[0].Quantity == 0)
                    {
                        return false;
                    }
                    player.Wallet += player.PriceForLemonade;
                    inventory.items.Where(x => x.ItemId == "1").ToArray()[0].Quantity -= 1; //cups to be deducted with 1
                    inventory.items.Where(x => x.ItemId == "4").ToArray()[0].Quantity -= 4; //ice cubes to be deducted with 4
                    return true;
                }
            }
            return false;
        }

    }
}
