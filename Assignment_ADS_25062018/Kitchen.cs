using System;
using System.Linq;

namespace Assignment_ADS_25062018
{
    public class Kitchen
    {
        public int StaffID { get; set; }
        public int OrderID { get; set; }
        public int SnackID { get; set; }

        public event EventHandler<int> SnackPrepareHandler;

        public void PrepareSnack(object Source, Order o)
        {
            if (o.SnackOrdered != null)
            {
                Console.WriteLine("Snack Order Registered. Preparing Snack ");
                SnackPrepared(o.CrockeryUsed.Count());
            }
        }

        public  void SnackIsReady()
        {
            throw new NotImplementedException();
        }

        public void SnackPrepared(int i)
        {
            Console.WriteLine("Snack Prepared. Sending Through!");
            onSnackPrepared(i);        }

        protected virtual void onSnackPrepared(int i)
        {
            SnackPrepareHandler?.Invoke(this, i);
        }
    }
}
