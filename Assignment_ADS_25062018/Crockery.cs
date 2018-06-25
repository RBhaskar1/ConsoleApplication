using System;
using System.Collections.Generic;

namespace Assignment_ADS_25062018
{
    public class Crockery
    {
        public event EventHandler<Crockery> WashDishes;

        public int CrockeryID { get; set; }
        public int CrockeryType { get; set; }
        public bool InUse { get; set; }
        CoffeeMachine cm = new CoffeeMachine();

        public Stack<Crockery> CrockeryStack = new Stack<Crockery>(); 
        List<Crockery> UsedCrockery = new List<Crockery>();

        //public Stack<Crockery> CrockeryStack2 = new Stack<Crockery>();

        //public Stack<Crockery> DirtyCrockeryStack1 = new Stack<Crockery>();
        //public Stack<Crockery> DirtyCrockeryStack2 = new Stack<Crockery>();


        public void PrepareSnack(object Source, int i)
        {
            int cont = 0;
            while (cont != i)
            {
                var temp = CrockeryStack.Pop();
                UsedCrockery.Add(temp);
                SnackIsReady(Source);
                onWashDishes(temp);
                cont++;
            }

            foreach(Crockery k in UsedCrockery)
            {
                CrockeryStack.Push(k);
            }
        }

        public void SnackIsReady(object Source)
        {
            if (Source.Equals(cm))
                Console.WriteLine("Crockery delegate passed.");
            else
                Console.WriteLine("Crockery delegate passed.");
        }

        protected virtual void onWashDishes(Crockery c)
        {
            WashDishes?.Invoke(this, c);
        }

        public void InitializeCrockery()
        {
            //50 cups added
            for (int i = 1; i <= 50; i++)
            {
                Crockery c1 = new Crockery
                {
                    CrockeryID = i,
                    CrockeryType = 1,
                    InUse = false
                };

                CrockeryStack.Push(c1);
            }

            //50 plates added
            for (int i = 1; i <= 50; i++)
            {
                Crockery c2 = new Crockery
                {
                    CrockeryID = i,
                    CrockeryType = 2,
                    InUse = false
                };

                CrockeryStack.Push(c2);
            }
        }
    }
}
