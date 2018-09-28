using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
    
        public List<Item> y = new List<Item>();
        public List<Supply> SupplyList= new List<Supply>();


        public void RunGame()
        {
          
            Console.WriteLine("Welcome to Lemonade Stand Game");
            InstantiateDays();
            InstantiateSupply();
            GetSupply();
            

        }

        private void InstantiateDays()
        {
            Days days = new Days();
            days.Initialize();
        }

        //private void InstantiateItems()
        //{

        //    Console.WriteLine("What are the items that you need to Buy?");
        //    Console.WriteLine("press 1 for Cups");
        //    Console.WriteLine("press 2 for Lemonade");
        //    Console.WriteLine("press 3 for Cups of sugar");
        //    Console.WriteLine("press 4 for Ice cubes");

        //    Item item = new Item();

        //    item.ItemId = "1";
        //    item.ItemDesc = "cups";
        //    item.Price = 0.06;
        //    int userInput = int Console.ReadLine();
        //    item.Quantity = userInput;

        //    item.ItemId = "2";
        //    item.ItemDesc = "Lemonde";
        //    item.Price = 0.06;
        //    int userInput;
        //    item.Quantity = userInput;

        //    item.ItemId = "3";
        //    item.ItemDesc = "Sugar";
        //    item.Price = 0.06;
        //    int userInput;
        //    item.Quantity = userInput;

        //    item.ItemId = "4";
        //    item.ItemDesc = "IceCubes";
        //    item.Price = 0.06;
        //    int userInput;
        //    item.Quantity = userInput;


        //}

        private void InstantiateSupply()
        {
            //cups
            SetSupply("1", "Cups", 25, 0.96);
            SetSupply("1", "Cups", 50, 1.96);
            SetSupply("1", "Cups", 100, 2.81);
            //lemon
            SetSupply("2", "Lemon", 10, 0.91);
            SetSupply("2", "Lemon", 30, 2.16);
            SetSupply("2", "Lemon", 75, 4.40);
            //sugar
            SetSupply("3", "Sugar", 8, 0.52);
            SetSupply("3", "Sugar", 20, 1.61);
            SetSupply("3", "Sugar", 48, 3.34);
            //ice cubes
            SetSupply("4", "Ice cubes", 100, 0.95);
            SetSupply("4", "Ice cubes", 250, 2.03);
            SetSupply("4", "Ice cubes", 500, 3.64);
                                                        
        }

        private void SetSupply(string id, string desc, int quantity, double price)
        {
            Supply Supply = new Supply();
            Supply.Id = id;
            Supply.Description = desc;
            Supply.Quantity = quantity;
            Supply.Price = price;
            SupplyList.Add(Supply);
        }

        private void GetSupply()
        {

            Console.WriteLine("What are the items that you need to Buy?");
            Console.WriteLine("press 1 for Cups");
            Console.WriteLine("press 2 for Lemonade");
            Console.WriteLine("press 3 for Cups of sugar");
            Console.WriteLine("press 4 for Ice cubes");


            Console.WriteLine("Which one would you like to choose? (1,2,3,4)");
            string id = Console.ReadLine();
            

            var supplyByIdList = SupplyList.Where(x => x.Id == id);

            Console.WriteLine("Select supply option.");
            int i = 1;
            foreach (var supply in supplyByIdList)
            {
                string unitDesc;

                if (supply.Id == "3") //sugar
                {
                    unitDesc = " cups of ";
                }
                else
                {
                    unitDesc = " pieces of ";
                }

                Console.WriteLine(i + ". " + supply.Quantity + unitDesc + supply.Description + " for " + supply.Price +".");
                i += 1;
            }
            Console.WriteLine("Which one would you like to choose? (1,2,3)");
            string supplyOption = Console.ReadLine();


           



            //add to imventory
            Inventory invetory = new Inventory();
            invetory.Day = "";
            invetory.PlayerId = 1;
            invetory.items = new List<Item>();

            // search for it in the supplyByIdList
            i = 1;
            foreach (var supply in supplyByIdList)
            {
                if (i == int.Parse(supplyOption))
                {
                    Item itemSelected = new Item();
                    itemSelected.ItemDesc = supply.Description;
                    itemSelected.ItemId = supply.Id;
                    itemSelected.Price = supply.Price;
                    itemSelected.Quantity = supply.Quantity;
                    invetory.items.Add(itemSelected);
                }
                i += 1;
            }

        }




      










    }


}
