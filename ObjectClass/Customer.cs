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

        public bool CustomerBuyLemonade(Weather weather, Player player)
        {
            if (weather.temperature >= MinTemperature && weather.temperature <= MaxTemperature )
            {
                if(player.PriceForLemonade >= MinPrice && player.PriceForLemonade <= MaxPrice)
                {
                    player.wallet += player.PriceForLemonade;
                    return true;
                }
            }
            return false;
        }

    }
}
