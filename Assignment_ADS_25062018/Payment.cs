using System;
namespace Assignment_ADS_25062018
{
    public class Payment
    {
        public Payment()
        {
        }

        public int OrderID { get; set; }
        public decimal SnackPrice { get; set; }
        public decimal CoffeePrice { get; set; }
        public bool Paid { get; set; }
        public bool Discounted { get; set; }
        public decimal Discount { get; set; }
        public int Handler { get; set; } //StaffID

        public decimal GenerateBill(Order o)
        {
            decimal bill = 0.0m;
            foreach(Snacks s in o.SnackOrdered)
            {
                bill += s.Price;
            }
            foreach(Coffee c in o.CoffeeOrdered)
            {
                bill += c.Price;
            }
            return bill;
        }

        public void ModifyBill()
        {
            throw new NotImplementedException();
        }

        public decimal ApplyDiscount(decimal bill)
        {
            if (bill < 10)
            {
                return 0;
            }
            else
            {
                return bill - 10;
            }
        }
    }
}
