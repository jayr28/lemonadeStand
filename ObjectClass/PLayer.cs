using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public class Player
    {
        public int PlayerId;
        public double Budget;
        public double PriceForLemonade;
        public int wallet = 20;

        public Player()
        {

        }

        public void SetPriceForLemonade()
        {
            Console.WriteLine("How much do you want to sell your Lemonade for?");
            PriceForLemonade =  double.Parse(Console.ReadLine());
        }

        public void MakingLemonade(Inventory inventory, Item item)
        {

        }
        


    }


}
