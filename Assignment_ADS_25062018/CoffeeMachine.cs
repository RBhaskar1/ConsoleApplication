using System;
using System.Linq;

namespace Assignment_ADS_25062018
{
    public class CoffeeMachine
    {
        public int CoffeeID { get; set; }
        public int OrderID { get; set; }
        public int StaffID { get; set; }

        public event EventHandler<int> CoffeePrepareHandler;

        public void PrepareCoffee(object Source, Order o)
        {
            if (o.CoffeeOrdered != null)
            {
                Console.WriteLine("Coffee Order Registered. Preparing Coffee ");
                CoffeePrepared(o.CrockeryUsed.Count());
            }    
        }

        public void CoffeeIsReady()
        {
            throw new NotImplementedException();
        }

        public void CoffeePrepared(int i)
        {
            Console.WriteLine("Coffe Prepared. Sending Through!");
            onCoffeePrepared(i);
        }

        protected virtual void onCoffeePrepared(int i)
        {
            CoffeePrepareHandler?.Invoke(this, i);
        }
    }
}
