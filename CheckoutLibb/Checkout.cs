using System;

namespace CheckoutLibb
{
    public class Checkout
    {
        public decimal GetTotal() 
        {
            return 0.00M;
        }

        public void ScanItem(Item item) 
        {
        
        }


    }


    public class Item
    {
        public string SKU { get; set; }
        public decimal UnitPrice { get; set; }
    }

    public class SpecialOffer1
    {
        public string SKU { get; set; }

        public int Quantity { get; set; }
        public decimal OfferPrice { get; set; }
    }

}
