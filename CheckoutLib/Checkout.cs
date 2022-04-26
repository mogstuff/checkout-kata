using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckoutLibb
{
    public class Checkout
    {

        public List<Item> Items { get; set; } = new List<Item>();
        public decimal GetTotal(List<Item> Items) 
        {
            if(!Items.Any())
            return 0.00M;

            return Items.Select(x => x.UnitPrice).Sum();
        }

        public void ScanItem(Item item) 
        {
            Items.Add(item);
        }


    }

}
