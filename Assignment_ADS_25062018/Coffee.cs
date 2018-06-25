using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_ADS_25062018
{
    public class Coffee
    {
        public int CoffeeID { get; set; }
        public string CoffeeName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int PrepareTime { get; set; }
        public bool InStock { get; set; }

        public List<Coffee> CoffeeList = new List<Coffee>();

        public void AddCoffee(Coffee c)
        {
            CoffeeList.Add(c);
        }

        public void ModifyCoffee(Coffee cf)
        {
            Coffee c1 = CoffeeList.FirstOrDefault(c => c.CoffeeID == cf.CoffeeID);
            if (c1 != null)
            {
                c1.CoffeeName = cf.CoffeeName;
                c1.Description = cf.Description;
                c1.InStock = cf.InStock;
                c1.PrepareTime = cf.PrepareTime;
                c1.Price = cf.PrepareTime;
            }
        }

        public void DeleteCoffee(Coffee c)
        {
            CoffeeList.Remove(c);
        }

        public void InitializeCoffee()
        {
            Coffee c1 = new Coffee
            {
                CoffeeID = 1,
                CoffeeName = "Caramel Macchiato",
                Description = "So bewitched are they, youâ€™d think it was some kind of magical elixir. Well thereâ€™s no hocus pocus here. Weâ€™ll tell you exactly what goes into it: creamy vanilla-flavoured syrup, freshly steamed milk with a topping of velvety-rich foam, an intense hit of our Espresso Roast, a finishing of buttery caramel drizzle",
                Price = 4.99m,
                PrepareTime = 5,
                InStock = true
            };
            Coffee c2 = new Coffee
            {
                CoffeeID = 2,
                CoffeeName = "CaffÃ¨ Americano",
                Description = "To create a caffÃ¨ americano â€“ a coffee that satisfies the American preference for more sips in every cup â€“ Europeans simply add hot water to their espresso. While the americano is similar in strength and taste to American-style brewed coffee, there are subtle differences achieved by pulling a fresh shot of espresso for the beverage base. The best way to discover these nuances, of course, is to try a cup yourself.",
                Price = 3.5m,
                PrepareTime = 5,
                InStock = true
            };
            Coffee c3 = new Coffee
            {
                CoffeeID = 3,
                CoffeeName = "CaffÃ¨ Latte",
                Description = "And like most classics, part of its appeal comes from its simplicity. A caffÃ¨ latte is simply a shot or two of bold, tasty espresso with fresh, sweet steamed milk over it. Some prefer to add syrup or extra espresso to the recipe. Some maintain that it is entirely perfect as is.",
                Price = 4.5m,
                PrepareTime = 6,
                InStock = true
            };
            Coffee c4 = new Coffee
            {
                CoffeeID = 4,
                CoffeeName = "CaffÃ¨ Mocha",
                Description = "Both are rich and full of depth. Where one is creamy, the other is roasty. They complement each other perfectly. And when they come together under a fluffy cloud of sweetened whipped cream, youâ€™ll wish their union would last forever.",
                Price = 4.5m,
                PrepareTime = 6,
                InStock = true
            };
            Coffee c5 = new Coffee
            {
                CoffeeID = 5,
                CoffeeName = "White Chocolate Mocha",
                Description = "That its smooth subtlety makes it a perfect complement to bolder flavours. Well, there arenâ€™t many flavours bolder than our rich, full-bodied espresso. And as it turns out, there arenâ€™t many better ways to experience the decadence of white chocolate than in this delicious beverage.",
                Price = 5.5m,
                PrepareTime = 4,
                InStock = true
            };
            Coffee c6 = new Coffee
            {
                CoffeeID = 6,
                CoffeeName = "Cappuccino",
                Description = "To make it properly requires much skill and attentiveness. Arguably the most important part is frothing the foam to velvety perfection as the milk steams â€“ something our baristas take great care to achieve. The milky moustache that clings to your upper lip is proof weâ€™ve made yours right. And may we say, you wear it well.",
                Price = 4.99m,
                PrepareTime = 5,
                InStock = true
            };
            Coffee c7 = new Coffee
            {
                CoffeeID = 7,
                CoffeeName = "Flat White",
                Description = "Expertly steamed milk poured over a double shot of our signature espresso and finished with a thin layer of velvety microfoam.",
                Price = 3.5m,
                PrepareTime = 3,
                InStock = true
            };
            Coffee c8 = new Coffee
            {
                CoffeeID = 8,
                CoffeeName = "Espresso",
                Description = "Its rich flavour, lingering aroma and caramelly sweetness make it the perfect foundation for lattes, cappuccinos and all our espresso-based beverages. But you can also enjoy it all by itself â€“ indeed, that might be the best way to discover its nuances.",
                Price = 3.99m,
                PrepareTime = 7,
                InStock = true
            };

            CoffeeList.Add(c1);
            CoffeeList.Add(c2);
            CoffeeList.Add(c3);
            CoffeeList.Add(c4);
            CoffeeList.Add(c5);
            CoffeeList.Add(c6);
            CoffeeList.Add(c7);
            CoffeeList.Add(c8);
        }
    }
}
