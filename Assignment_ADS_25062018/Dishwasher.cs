using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Assignment_ADS_25062018
{
    public class Dishwasher
    {
        public int CrockeryID { get; set; }
        public int WashTime { get; set; }
        public bool Washed { get; set; }
        public int Count { get; set; }

        List<Dishwasher> dw = new List<Dishwasher>();

        public void StartWash(int time)
        {
            Thread.Sleep(time*100);
            FinishWash();
        }

        public static void FinishWash()
        {
            Console.WriteLine("Dishwashing Finished!!!");
        }

        public void IsFull()
        {
            if (dw.Count(dish => dish.Washed == false) == 25)
            {
                var dishesToWash = dw.Where(ds => ds.Washed == false).ToList();
                int TotalTime = 0;
                foreach (Dishwasher croc in dishesToWash)
                {
                    TotalTime += croc.WashTime;
                }

                StartWash(TotalTime);
            }        
        }

        public void AddCrockery(object Source, Crockery c)
        {
            Dishwasher d = new Dishwasher
            {
                CrockeryID = c.CrockeryID,
                WashTime = 5,
                Washed = false,
                Count = 1
            };

            dw.Add(d);

            IsFull();
        }

        public void RemoveCrockery()
        {
            foreach(Dishwasher d in dw)
            {
                if (Count != 100)
                {
                    d.Washed = true;
                    Count++;
                }
                else{
                    Console.WriteLine("Crockery ID {0} is now out of service",d.CrockeryID);
                }
            }
        }
    }
}
