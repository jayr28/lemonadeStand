using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace LemonadeStand
{
    public class Player
    {
       
        public double PriceForLemonade;
        public double Wallet;
    
        public void MakingLemonade(ref Inventory inventory)
        {
            //4 lemons, 4 cups of sugar and 20 ice cubes = 1 pitcher = 20 cups
            foreach (var item in inventory.items)
            {
                switch (item.ItemDesc)
                {
                    case "Lemon":
                        item.Quantity -= 4;
                        break;

                    case "Sugar":
                        item.Quantity -= 4;
                        break;

                    //case "IceCubes":
                    //    item.Quantity -= 20;
                    //    break;

                   
                    //case "Cups":
                    //    item.Quantity -= 20;
                    //    break;

                }

                
            }
        }





    }


}
