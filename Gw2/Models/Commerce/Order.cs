using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Gw2.Models.Commerce
{
    public class Order
    {
        /// <summary>
        /// Unit price 
        /// </summary>
        [JsonPropertyName("unit_price")]
        public int UnitPrice { get; set; }

        /// <summary>
        /// Total quantity of this listing
        /// </summary>
        [JsonPropertyName("quantity")]
        public int Quantity { get; set; }
    }
}
