using System;
using System.Collections.Generic;
using System.Text;

namespace Gw2.Models.Tracker
{
    public class TrackerItem
    {
        public int Id { get; set; }

        public string Rarity { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public int Amount { get; set; }

        public override bool Equals(object obj)
        {
            return obj is TrackerItem item &&
                   Id == item.Id &&
                   Rarity == item.Rarity &&
                   Type == item.Type &&
                   Name == item.Name &&
                   Amount == item.Amount;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Rarity, Type, Name, Amount);
        }
    }
}
