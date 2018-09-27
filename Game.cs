using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        public List<Days> x = new List<Days>();
        public List<Item> y = new List<Item>();
        public List<ObjectClass.ItemSelection> itemSelections = new List<ObjectClass.ItemSelection>();


        public void RunGame()
        {
            Cups item = new Cups();
            item.CurrentPrice = 20;


            Item item1 = new Item();




            Player player = new Player();
            player.wallet.Budget = 20;


            player.wallet = new Wallet();
            player.wallet.Budget1 = "";


            Wallet w = new Wallet();
            w.Budget1 = "";

        }

        private void InsantiateDays()
        {
            Days x = new Days();
            x.Day = List "Sunday";
            x.weather = new Weather();
            x.weather.temperature =
            x.weather.Temperature =
            return x;
        }

        private void InstantiateItems()
        {

            Console.WriteLine("What are the items that you need to Buy?");
            Console.WriteLine("press 1 for cups");
            Console.WriteLine("press 2 for Lemonade");
            Console.WriteLine("press 3 for cups of sugar");
            Console.WriteLine("press 4 for ice cubes");

            Item item = new Item();

            item.ItemId = "A";
            item.ItemDesc = "cups";
            item.Price = 0.06;
            int userInput;
            item.Quantity = userInput;

            item.ItemId = "B";
            item.ItemDesc = "Lemonde";
            item.Price = 0.06;
            int userInput;
            item.Quantity = userInput;

            item.ItemId = "C";
            item.ItemDesc = "Sugar";
            item.Price = 0.06;
            int userInput;
            item.Quantity = userInput;

            item.ItemId = "D";
            item.ItemDesc = "IceCubes";
            item.Price = 0.06;
            int userInput;
            item.Quantity = userInput;


        }

        private void InstantiateItemSelection()
        {
            ObjectClass.ItemSelection itemSelections = new ObjectClass.ItemSelection();
            itemSelections.id = "A";
            itemSelections.quantity = 25;
            itemSelections.price = 0.96;

            itemSelections.id = "A";
            itemSelections.quantity = 50;
            itemSelections.price = 1.96;

            itemSelections.id = "A";
            itemSelections.quantity = 100;
            itemSelections.price = 2.81;

            itemSelections.id = "B";
            itemSelections.quantity = 10;
            itemSelections.price = 0.91;

            itemSelections.id = "B";
            itemSelections.quantity = 30;
            itemSelections.price = 2.16;

            itemSelections.id = "B";
            itemSelections.quantity = 75;
            itemSelections.price = 4.40;

            itemSelections.id = "C";
            itemSelections.quantity = 8;
            itemSelections.price = 0.52;

            itemSelections.id = "C";
            itemSelections.quantity = 20;
            itemSelections.price = 1.61;

            itemSelections.id = "C";
            itemSelections.quantity = 48;
            itemSelections.price = 3.34;

            itemSelections.id = "D";
            itemSelections.quantity = 100;
            itemSelections.price = 0.95;

            itemSelections.id = "D";
            itemSelections.quantity = 250;
            itemSelections.price = 0.95;

            itemSelections.id = "D";
            itemSelections.quantity = 500;
            itemSelections.price = 3.64;












        }










        Store store = new Store();
       
        Player player = new Player();
        //List<string> days = new Days List<string>();
        //Item item = new Item();


      //go to the store and get inventory before starting the game with only $20

    
      //subtracting the amount of money paid for the supplies from $20
      //able to set a random weather and random numbers of customers
      //set the price of the lemonade before the day
      //set different kinds of customers
      //set how many days to sell lemonade
      //calculate the total profit or loss at the end of the day
      //keep track of the record throughout the entire week









    }

    public class Days
    {
    }
}
