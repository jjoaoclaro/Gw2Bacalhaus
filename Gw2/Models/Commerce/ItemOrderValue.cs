using System;
using System.Collections.Generic;
using System.Text;

namespace Gw2.Models.Commerce
{
    public class ItemOrderValue
    {
        public int Id { get; set; }

        public bool WhiteListed { get; set; }

        public Order Sells { get; set; }

        public Order Buys { get; set; }
    }
}
