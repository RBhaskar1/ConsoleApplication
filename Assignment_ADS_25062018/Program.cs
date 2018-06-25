using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Assignment_ADS_25062018
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Initializing Objects to access the methods of the classes
            Coffee cfe = new Coffee();
            Snacks snk = new Snacks();
            Staff staff = new Staff();
            Table tab = new Table();
            Order ord = new Order();
            CoffeeMachine cm = new CoffeeMachine();
            Kitchen kit = new Kitchen();
            Crockery ck = new Crockery();
            Payment pmt = new Payment();

            //Continuation bool to handle user flow
            var cont = true;

            List<Snacks> snackOrderedList = new List<Snacks>();
            List<Coffee> CoffeeOrderedList = new List<Coffee>();
            List<Crockery> CrockeryUsed = new List<Crockery>();
            List<Order> TotalOrders = new List<Order>();

            Console.WriteLine("\t\t\t\t\t\tWelcome to LE CAFÉ!\t\t\t");
            Console.WriteLine("\t\t\t\t\t\t-----------------------------\t\t\t\t");

            //Creating Objects of Crockery
            ck.InitializeCrockery();

            //Creating Objects of Coffee to later populate the Coffee List
            cfe.InitializeCoffee();

            //Adding Snacks so that it can be added to snack menu later on
            snk.InitializeSnacks();

            //Adding Staff Members
            staff.InitializeStaff();

            //Adding Tables
            tab.InitializeTables();

            Console.WriteLine("Press any key to see the menu's.");
            Console.Read();

            Console.WriteLine("Please enter the table number you are ordering from");
            int? TableID = Convert.ToInt16(Console.ReadLine());
            try { TableID = Convert.ToInt16(TableID); } catch { TableID = null; }

            cont = true;
            while (cont)
            {
                if (TableID == null)
                {
                    Console.WriteLine("Please try again, enter a valid table number");
                    //TableID = Console.ReadLine();
                    try { TableID = Convert.ToInt16(Console.ReadLine()); } catch { TableID = null; }
                }
                else
                {
                    TableID = tab.Tables.FirstOrDefault(t => t.Key == TableID).Value.TableID;
                    cont = false;
                }
            }

            Console.WriteLine("\t\t\t\t\t\t\t");
            Console.WriteLine("Please Select the number Coffee you would like to have");
            Console.WriteLine("\t\t\t\t\t\t\t");
            Console.WriteLine("Coffee\t\t--\t\tPrice\t\t--\t\tPrepration Time\t\t--\t\tDescription");

            foreach (Coffee c in cfe.CoffeeList)
            {
                Console.WriteLine(c.CoffeeID + "\t" + c.CoffeeName + "\t" + c.Price.ToString() + "\t" + c.PrepareTime.ToString());
                Console.WriteLine(c.Description);
                Console.WriteLine("\t\t\t\t\t\t\t");
            }

            int? CoffeeID = -1;
            cont = true;
            while (cont)
            {
                try { CoffeeID = Convert.ToInt16(Console.ReadLine()); } catch { CoffeeID = null; }

                if (CoffeeID != null)
                {
                    Coffee orderedCoffee = cfe.CoffeeList.FirstOrDefault(c => c.CoffeeID == CoffeeID);
                    CoffeeOrderedList.Add(orderedCoffee);
                    Crockery crok1 = new Crockery();
                    CrockeryUsed.Add(crok1);
                }

                Console.WriteLine("\t\t\t\t\t\t\t");
                Console.WriteLine("To add more coffe press y or enter n and press enter key");
                Console.WriteLine("\t\t\t\t\t\t\t");

                var moreCoffee = Console.ReadLine();

                if (!moreCoffee.Contains("y"))
                {
                    cont = false;
                }
            }

            foreach (Snacks s in snk.SnackList)
            {
                Console.WriteLine(s.SnackID + "\t" + s.SnackName + "\t" + s.Price.ToString() + "\t" + s.ServingSize + "\t" + s.PrepareTime.ToString());
                Console.WriteLine(s.Description);
                Console.WriteLine("\t\t\t\t\t\t\t");
            }

            Console.WriteLine("\t\t\t\t\t\t\t");
            Console.WriteLine("Please Select the number Snack you would like to have");


            int? SnackID = -1;
            cont = true;
            while (cont)
            {
                try { SnackID = Convert.ToInt16(Console.ReadLine()); } catch { SnackID = null; }

                if (SnackID != null)
                {
                    Snacks orderedSnack = snk.SnackList.FirstOrDefault(s => s.SnackID == SnackID);
                    snackOrderedList.Add(orderedSnack);
                    Crockery crok = new Crockery();
                    CrockeryUsed.Add(crok);
                }

                Console.WriteLine("\t\t\t\t\t\t\t");
                Console.WriteLine("To add more snacks press y or enter n and press enter key");
                Console.WriteLine("\t\t\t\t\t\t\t");

                var moreCoffee = Console.ReadLine();

                if (!moreCoffee.Contains("y"))
                {
                    cont = false;
                }
            }

            Order test = new Order
            {
                OrderID = (int)TableID + (int)CoffeeID * (int)SnackID,
                TableID = (int)TableID,
                OrderDate = DateTime.Now,
                SnackOrdered = snackOrderedList,
                CoffeeOrdered = CoffeeOrderedList,
                Waiter = 1,
                ServingTime = 10,
                Served = false,
                CrockeryUsed = CrockeryUsed
            };

            ord.OrderAdded += cm.PrepareCoffee;
            ord.OrderAdded += kit.PrepareSnack;
            cm.CoffeePrepareHandler += ck.PrepareSnack;
            kit.SnackPrepareHandler += ck.PrepareSnack;

            ord.AddOrder(test);
            TotalOrders.Add(test);

            Console.WriteLine("Your order will soon be on your table.");
            Console.WriteLine();
            Thread.Sleep(3000);

            var totalBill = pmt.GenerateBill(test);

            Console.WriteLine("are you an employee with us. you can avail a flat 10 bucks discount by entering your id");
            var id = Console.Read();
            totalBill = pmt.ApplyDiscount(totalBill);
            Console.WriteLine("Your Total comes out to be " + totalBill.ToString());
            Console.WriteLine("Please write your full name as signature to authorise the payment.");
            var sign = Console.Read();

            Console.WriteLine("Thank you for ordering with us " + sign.ToString());

            Console.WriteLine("\t\t\t\t\t\tPRESS numeric 1 Key to enter admin mode\t\t\t");
            Console.WriteLine("\t\t\t\t\t\t-----------------------------\t\t\t\t");

            var input = Console.Read();
            if (input == 1)
            {
                Console.WriteLine("Welcome to Admin mode. Here you can see up-to-the-minute information on the snack items and coffees ordered and breakout percentages showing sales of each item versus total sales");
            }

            decimal total = 0.0m;
            foreach(Order ords in TotalOrders)
            {
                foreach (Snacks s in ords.SnackOrdered)
                {
                    Console.WriteLine(ords.OrderID.ToString() + "\t" + s.SnackName);
                    total += s.Price;
                }
                foreach (Coffee c in ords.CoffeeOrdered)
                {
                    Console.WriteLine(ords.OrderID.ToString() + "\t" + c.CoffeeName);
                    total += c.Price;
                }
            }

            Console.WriteLine("\t\t\t\t\t\t-----------------------------\t\t\t\t");
            Console.WriteLine("Total Sales are " + "\t" + total);
        }
    }
}
