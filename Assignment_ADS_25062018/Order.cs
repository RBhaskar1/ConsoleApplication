using System;
using System.Collections.Generic;

namespace Assignment_ADS_25062018
{
    public class Order
    {
        public event EventHandler<Order> OrderAdded;

        public int OrderID { get; set; }
        public int TableID { get; set; }
        public DateTime OrderDate { get; set; }
        public List<Snacks> SnackOrdered { get; set; }
        public List<Coffee> CoffeeOrdered { get; set; }
        public int Waiter { get; set; } //StaffID
        public List<Crockery> CrockeryUsed { get; set; }
        public int ServingTime { get; set; }
        public bool Served { get; set; }

        public Queue<Order> Orders = new Queue<Order>();

        public void AddOrder(Order o)
        {
            Orders.Enqueue(o);
            onOrderAdded(o);
        }

        protected virtual void onOrderAdded(Order o)
        {
            OrderAdded?.Invoke(this, o);
        }

        public void ModifyOrder(Order o)
        {
            Order ord = Orders.Peek();
            ord = o;
        }

        public void DeleteOrder(Order o)
        {
            Orders.Dequeue();
        }
    }
}
