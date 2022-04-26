using System;
using System.Collections.Generic;
using System.Linq;

namespace CheckoutLibb
{

    public class Checkout
    {
        public List<Item> Items { get; set; } = new List<Item>();
        public List<SpecialOffer> Offers { get; set; } = new List<SpecialOffer>();

        public void ScanItem(Item item)
        {
            Items.Add(item);
        }


        public decimal GetTotal(List<Item> Items, List<SpecialOffer> Offers)
        {
            if (!Items.Any())
                return 0.00M;
            if (!Offers.Any())
                return Items.Select(x => x.UnitPrice).Sum();
            decimal discountedTotal = Items.Select(x => x.UnitPrice).Sum();

            // any discount ?
            foreach (var offer in Offers)
            {
                bool applyDiscount = Items.Where(x => x.SKU == offer.SKU).Count() > offer.Quantity;

                if (applyDiscount)
                {                    
                    int itemsToDiscount = Items.Where(x => x.SKU == offer.SKU).Count() / offer.Quantity;
                    
                    decimal FullItemPrice = Items.Where(x => x.SKU == offer.SKU).First().UnitPrice;

                    decimal discountToApply = (FullItemPrice * offer.Quantity) - (itemsToDiscount * offer.OfferPrice);
                    
                    discountedTotal -= discountToApply;                    
                }

            }

            return discountedTotal;
        }



    }
}