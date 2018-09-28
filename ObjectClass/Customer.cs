using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Customer
    {
        Random random;
        double percent = 100;
        public int HowMuchCustomerWantsToPay;
        public double TemperatureFactorToBuy;
        public double ForecastFactorToBuy;
        public double PriceFactorToBuy;
        public int Customers = 30;
     

        public Customer(Weather weather)
        {

        }

        public void TemperatureToBuy(Weather weather)
        {
           if (weather.temperature <= 70)
            {
                
                TemperatureFactorToBuy = percent * 1.15;
            }
           else if (weather.temperature >= 80)
            {
                TemperatureFactorToBuy = percent * 1.50;
            }
        }

        public void ForecastToBuy(Weather weather)
        {
            if (weather.forecast == "Sunny")
            {
                ForecastFactorToBuy = percent * 1.85;
            }
            else if ( weather.forecast == "Cloudy" || weather.forecast == "Partly Cloudy")
            {
                ForecastFactorToBuy = percent * 1.45;
            }
            else if ( weather.forecast == "Rainy" || weather.forecast == "Hazy")
            {
                ForecastFactorToBuy = percent * 1.15;
            }
        }

        public void PriceToBuy(Player player)
        {
            if (player.PriceForLemonade >= .10 && player.PriceForLemonade <= .15)
            {
                PriceFactorToBuy = percent * 1.85;
            }
            else if (player.PriceForLemonade >= .15 && player.PriceForLemonade <= .20)
            {
                PriceFactorToBuy = percent * 1.45;
            }
            else if (player.PriceForLemonade >= .20 && player.PriceForLemonade <= .25)
            {
                PriceFactorToBuy = percent * 1.15;
            }
        }
    }
}
