using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Diagnostics;

namespace LemonadeStand
{
    class Game
    {
    
        public List<Item> y = new List<Item>();
        public List<Supply> SupplyList= new List<Supply>();
        public List<Customer> CustomerList = new List<Customer>();
        private double InitialBudget = 20;

        public void RunGame()
        {
            bool playAgain = true;
            while (playAgain)
            {
                DisplayInstruction();
                Days days = new Days();
                InstantiateDays(ref days);
                InstantiateSupply();
                Inventory inventory = new Inventory();
                Player player = new Player();
                player.Wallet = InitialBudget;
                foreach (var day in days.DayList)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Weather - Day: " + day.DOW + " Temp: " + day.Temperature + " Forecast: " + day.Forecast);

                    DisplayWallet(player);
                    GetSupply(ref inventory, ref player);
                    DisplayWallet(player);
                    SetPriceForLemonade(ref inventory, ref player);
                    StartSelling(day, player, ref inventory);
                    DisplayInventory(inventory);
                }


                Console.SetCursorPosition(0, 18);
                Console.WriteLine("                                                                    ");
                Console.WriteLine("**************** Initial Money :" + InitialBudget + "***************");
                if ((player.Wallet - InitialBudget) > 0)
                {
                    Console.SetCursorPosition(0, 19);
                    Console.WriteLine("                                                                               ");
                    Console.WriteLine("**************** Profit :" + (player.Wallet - InitialBudget) + "***************");
                }
                else
                {
                    Console.SetCursorPosition(0, 19);
                    Console.WriteLine("                                                                             ");
                    Console.WriteLine("**************** Loss :" + (player.Wallet - InitialBudget) + "***************");
                }

                Console.WriteLine("Play again (Y/N)?");
                string again = Console.ReadLine();
                Console.Clear();
                if (again.ToUpper()=="N")
                {
                    Console.WriteLine("Thanks for playing. Goodbye.");
                    Console.ReadLine();
                    playAgain = false;
                }
            }


        }

        private void StartSelling(Day day, Player player,  ref Inventory inventory)
        {

            Stopwatch stopWatch = new Stopwatch();
            DisplayTimer(stopWatch, true); 
            Stopwatch NewStopWatch = new Stopwatch();

            int TotalNumberOfCustomers = 0;
            Random rnd = new Random();
            NewStopWatch.Start();
            stopWatch.Start();


            bool loopx = true;
            while (loopx)// 8 minute is equal to 8 hours
            {

                if (NewStopWatch.Elapsed.Seconds == 3) //1 minute is equal to one hour
                {
                    
                    DrawActivity();
                    GenerateNumberOfCustomer(rnd);

                    foreach (var customer in CustomerList)
                    {
                        customer.CustomerBuyLemonade(day, player, ref inventory);
                    }

                    NewStopWatch = new Stopwatch();
                    NewStopWatch.Start();

                    TotalNumberOfCustomers += CustomerList.Count();

                    CustomerList.Clear();
                    if (stopWatch.Elapsed.Seconds >= 24)
                    {
                        loopx = false;
                    }
                }

            }

            Console.SetCursorPosition(0, 60);
            Console.WriteLine("Total Customers: " + TotalNumberOfCustomers);

            Console.SetCursorPosition(10, 60);


            DisplayWallet(player);
        }

        private void DisplayInstruction()
        {
            string rules = "Welcome to Lemonade Stand! \n" +
            "Your goal is to make as much money as you can in 7 days.\n" +
            "Buy cups, lemons, sugar and ice cubes, then set your recipe based on the weather\n" +
            "and conditions. Then, set your price and sell your lemonade at the stand.\n" +
            "At then end of the game, you will see how much money you made. Write it down \n" +
            "and play again to try and beat your score!";
            Console.SetCursorPosition(0, 0);
            Console.WriteLine(rules);
            Console.ReadLine();
            Console.Clear();
        }

        private void DrawActivity()
        {
                     
            int ygoingleft = 100;
            for (int ygoingright = 0; ygoingright < 60; ygoingright++)
            {
                Console.SetCursorPosition(ygoingright,12);
                Console.WriteLine((char)177);

                Console.SetCursorPosition(ygoingright, 12);
                Console.WriteLine(" ");

                Console.SetCursorPosition(ygoingright+1, 12);
                Console.WriteLine((char)177);


                Console.SetCursorPosition(ygoingleft- ygoingright, 12);
                Console.WriteLine((char)177);
                
                Console.SetCursorPosition(ygoingleft - ygoingright, 12);
                Console.WriteLine(" ");
                
                Console.SetCursorPosition(ygoingleft - ygoingright -1, 12);
                Console.WriteLine((char)177);

                Stopwatch NewStopWatch = new Stopwatch();
                NewStopWatch.Start();
                bool isLoop = true;
                while (isLoop)
                {
                    if (NewStopWatch.Elapsed.Milliseconds == 100)
                    {
                        isLoop = false;
                    }
                }

                NewStopWatch.Stop();
            }
            Console.SetCursorPosition(0, 12);
            Console.WriteLine("                                                                               ");

        }

        private void InstantiateDays(ref Days days)
        {
           
            days.Initialize();
          
        }

        private void DisplayWallet(Player player)
        {
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("Player Money: " + player.Wallet);
        }

        private void DisplayTimer(Stopwatch stopWatch, bool StartGame)
        {
            if (StartGame)
            {
                stopWatch.Start();
                Console.SetCursorPosition(0, 2);
                //Console.WriteLine("Time: " + stopWatch.ElapsedTicks);
            }

        }



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
            SetSupply("4", "IceCubes", 100, 0.95);
            SetSupply("4", "IceCubes", 250, 2.03);
            SetSupply("4", "IceCubes", 500, 3.64);
                                                        
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

        private void GetSupply(ref Inventory inventory, ref Player player)
        {
            if (inventory.items is null )
            {
                inventory.items = new List<Item>();
            }
            
            bool MoreSupply = true;
            while(MoreSupply)
            {
                Console.SetCursorPosition(0, 8);
                Console.WriteLine("What are the items that you need to Buy?");
                Console.WriteLine("press 1 for Cups");
                Console.WriteLine("press 2 for Lemonade");
                Console.WriteLine("press 3 for Cups of sugar");
                Console.WriteLine("press 4 for Ice cubes");

                string id ="";
                Console.WriteLine("Which one would you like to choose? (1,2,3,4,X)");
                id = AskQuestion(4);
                

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

                    Console.WriteLine(i + ". " + supply.Quantity + unitDesc + supply.Description + " for " + supply.Price + ".");
                    i += 1;
                }
                Console.WriteLine("Which one would you like to choose? (1,2,3,X)");

                string supplyOption = "";

                supplyOption = AskQuestion(3);


                //add to imventory
                //Inventory inventory = new Inventory();
                inventory.Day = "";
                inventory.PlayerId = 1;
               

                // search for it in the supplyByIdList
                i = 1;
                foreach (var supply in supplyByIdList)
                {
                    if (i == int.Parse(supplyOption))
                    {
                        if (inventory.items.Where(x => x.ItemId == supply.Id).ToList().Count == 0)
                        {
                            Item itemSelected = new Item();
                            itemSelected.ItemDesc = supply.Description;
                            itemSelected.ItemId = supply.Id;
                            itemSelected.Price = supply.Price;
                            player.Wallet -= supply.Price;
                            itemSelected.Quantity += supply.Quantity;
                            inventory.items.Add(itemSelected);

                        }
                        else
                        {
                            player.Wallet -= supply.Price;
                            inventory.items.Where(x => x.ItemId == supply.Id).ToArray()[0].Quantity += supply.Quantity;                         
                        }


                    }
                    i += 1;
                }

                string answer = "";
                while (answer != "Y" && answer != "N")
                {
                    Console.WriteLine("Do you need anymore supply (Y/N)?");
                    answer = Console.ReadLine().ToUpper();
                    switch (answer)
                    {
                        case "Y":
                            MoreSupply = true;
                            break;
                        case "N":
                            MoreSupply = false;
                            break;                      
                        default:
                            MoreSupply = false;
                            break;

                    }
                }

                DisplayClearScreenSection();
                DisplayInventory(inventory);
                
                Console.SetCursorPosition(8, 0);

            }
           
           
        
        }

        private string  AskQuestion(int numberOfOptions)
        {
            bool isAnswerCorrect = false;
            List<string> answerInput = new List<string>();
            for (int i = 1; i <= numberOfOptions; i++)
            {
                answerInput.Add(i.ToString());            
            }
            answerInput.Add("X");

            string id = "";
            while (!isAnswerCorrect)
            {
                id = Console.ReadLine();
                if (answerInput.Contains(id.ToUpper()))
                {
                    isAnswerCorrect = true;
                }
                else { Console.WriteLine("Invalid option."); }
            }
            return id;
        }

        public void SetPriceForLemonade(ref Inventory inventory, ref Player player)
        {
            
            player.MakingLemonade(ref inventory);
            DisplayInventory(inventory);
            Console.SetCursorPosition(0, 8);
            Console.WriteLine("How much do you want to sell your Lemonade for?");
            player.PriceForLemonade = double.Parse(Console.ReadLine());
        }

        private void DisplayInventory(Inventory inventory)
        {

            DisplayBox(inventory);

            int screenLocation = 1;
            foreach (var item in inventory.items)
            {
                Console.SetCursorPosition(75, screenLocation);
                Console.WriteLine("Item: " + item.ItemDesc + " Qty: " + item.Quantity);
                screenLocation += 1;

            }
        }

        private void DisplayBox(Inventory inventory)
        {
            Console.SetCursorPosition(70, 0);
            Console.WriteLine("*************INVENTORY***************");
            int YScreenPosition = 1;
            foreach (var item in inventory.items)
            {
                Console.SetCursorPosition(70, YScreenPosition);
                Console.WriteLine("*                                   *");
                YScreenPosition += 1;
            }
            Console.SetCursorPosition(70, YScreenPosition);
            Console.WriteLine("*************************************");
        }

        private void DisplayClearScreenSection()
        {
            for( int i = 8; i < 75; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.WriteLine("                                                                                        ");

            }
        }


         private void GenerateNumberOfCustomer(Random rnd)
        {

            int NumberOfCustomers = rnd.Next(1, 20);
            
            for (int i=1; i < NumberOfCustomers; i++)
            {
                Customer customer = new Customer();
                customer.MinTemperature = rnd.Next(50, 74);
                customer.MaxTemperature = rnd.Next(75, 99);
                int minP = rnd.Next(10, 20);
                customer.MinPrice = Double.Parse((minP / 100.00).ToString());
                int maxP = rnd.Next(21, 50);
                customer.MaxPrice = Double.Parse((maxP / 100.00).ToString());
                CustomerList.Add(customer);
               
            }
        }




    }


}
