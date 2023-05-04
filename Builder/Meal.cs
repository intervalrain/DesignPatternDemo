using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Data.Common;

namespace Builder
{
    public class Meal
    {
        private List<Item> items = new List<Item>();
        public void Add(Item item)
        {
            items.Add(item);
        }
        public float GetCost()
        {
            float cost = 0.0f;
            foreach (Item item in items)
            {
                cost += item.GetPrice();
            }
            return cost;
        }

        public void Bill()
        {
            foreach (Item item in items)
            {
                System.Console.Write("Item: " + item.GetName());
                System.Console.Write(", Packing : " + item.GetPacking().pack());
                System.Console.WriteLine(", Price : " + item.GetPrice());
                System.Console.WriteLine("===========================");
            }
            System.Console.WriteLine("Total : " + this.GetCost());
        }
    }
}