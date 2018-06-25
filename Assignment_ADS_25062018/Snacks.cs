using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment_ADS_25062018
{
    public class Snacks
    {
        public int SnackID { get; set; }
        public string SnackName { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public string ServingSize { get; set; }
        public int PrepareTime { get; set; }
        public bool InStock { get; set; }

        public List<Snacks> SnackList = new List<Snacks>();

        public void AddSnack(Snacks s)
        {
            SnackList.Add(s);
        }

        public void ModifySnack(Snacks s)
        {
            Snacks snack = SnackList.FirstOrDefault(sc => sc.SnackID == s.SnackID);
            snack = s;
        }

        public void DeleteSnack(Snacks s)
        {
            SnackList.Remove(s);
        }

        public void InitializeSnacks()
        {
            Snacks s1 = new Snacks
            {
                SnackID = 1,
                SnackName = "Pumpkin SpicedÂ",
                Description = "Skip the sugar-laden pumpkin spice latte and opt for these lightly seasoned seeds instead.",
                Price = 12.99m,
                ServingSize = "small",
                PrepareTime = 5,
                InStock = true
            };
            Snacks s2 = new Snacks
            {
                SnackID = 2,
                SnackName = "Cranberry-Pistachio Granola",
                Description = "Whip up a batch of this easy granola and you'll have a lightly sweet grab-and-go snack to last you for days. ",
                Price = 9.65m,
                ServingSize = "small",
                PrepareTime = 4,
                InStock = true
            };
            Snacks s3 = new Snacks
            {
                SnackID = 3,
                SnackName = "Ozery Bakery Morning Rounds",
                Description = "A cross between pita bread and scones, these fluffy, moist fruit-and-grain buns are a healthier alternative to a bakery treat.",
                Price = 3.99m,
                ServingSize = "Two Pieces",
                PrepareTime = 8,
                InStock = true
            };
            Snacks s4 = new Snacks
            {
                SnackID = 4,
                SnackName = "Berry Cream Cheese",
                Description = "For a bagel-shop-like treat. Slather onÂ whole grain crackers,Â flatbread, waffles, orÂ mini bagels.",
                Price = 4.5m,
                ServingSize = "Two Pieces",
                PrepareTime = 6,
                InStock = true
            };
            Snacks s5 = new Snacks
            {
                SnackID = 5,
                SnackName = "Kind Snacks Healthy Grains Clusters",
                Description = "You can get a good sense of the deliciousness of these gluten-free granola clusters by their flavor names, including Oats & Honey with Toasted Coconut, Maple Quinoa with Chia Seeds, Vanilla Blueberry with Flax, Cinnamon Oat with Flax, and Peanut Butter Whole Grain.",
                Price = 7.5m,
                ServingSize = "small",
                PrepareTime = 4,
                InStock = true
            };
            Snacks s6 = new Snacks
            {
                SnackID = 6,
                SnackName = "Vitalicious Wild Blueberry VitaTops",
                Description = "Instead of grabbing a blueberry muffin from the coffee shop, try one of these wholesome snacks",
                Price = 6.75m,
                ServingSize = "Two Pieces",
                PrepareTime = 9,
                InStock = true
            };
            Snacks s7 = new Snacks
            {
                SnackID = 7,
                SnackName = "Lesley Stowe Raincoast Crisps",
                Description = "Made in small batches, these crispy cracker-like snacks are sweet and nutty, loaded with seeds, nuts, and dried fruits. ",
                Price = 5.5m,
                ServingSize = "small",
                PrepareTime = 3,
                InStock = true
            };
            Snacks s8 = new Snacks
            {
                SnackID = 8,
                SnackName = "Apple Pie Parfaits",
                Description = "Like an apple pieâ€”but lower in sugar and fat (with an added dose of protein).",
                Price = 8.99m,
                ServingSize = "non-vege",
                PrepareTime = 7,
                InStock = true
            };

            SnackList.Add(s1);
            SnackList.Add(s2);
            SnackList.Add(s3);
            SnackList.Add(s4);
            SnackList.Add(s5);
            SnackList.Add(s6);
            SnackList.Add(s7);
            SnackList.Add(s8);
        }
    }
}
