using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public abstract class Item
    {

        Lemons lemons = new Lemons();
        Sugar sugar = new Sugar();
        Cups cups = new Cups();
        IceCubes ice = new IceCubes;

        // member variables (HAS A)
        public double CurrentPrice;
     

        
        // public abstract void GetTotalPrice();
      


    }
}
